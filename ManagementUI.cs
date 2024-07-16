using IWAU_QuickPackUtility.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IWAU_QuickPackUtility
{
    public partial class ManagementUI : Form
    {
        public ManagementUI()
        {
            GetIWAU();
            InitializeComponent();
        }

        public async void GetIWAU()
        {
            string IWAUPath = System.IO.Directory.GetCurrentDirectory() + "/IWAU/IntuneWinAppUtil.exe";
            if (!System.IO.File.Exists(IWAUPath) && Properties.Settings.Default.UseBuildInIWAU)
            {
                DialogResult response = MessageBox.Show("IWAU-QuickPackUtility needs to download the latest Microsoft-Win32-Content-Prep-Tool \"IntuneWinAppUtil.exe\"\n\nAllow? (Required for program to work)", "IntuneWinAppUtil.exe not found", MessageBoxButtons.YesNo);
                if (DialogResult.Yes == response)
                {
                    do
                    {
                        await HttpHelper.DownloadFileAsync(Properties.Settings.Default.IWAURemoteDownloadURL, IWAUPath);

                        if (System.IO.File.Exists(IWAUPath))
                        {
                            MessageBox.Show("Download successfull, application ready!", "IntuneWinAppUtil.exe downloaded", MessageBoxButtons.OK);
                            break;
                        }
                        else
                        {
                            DialogResult response2 = MessageBox.Show("Download failed, please press retry or cancle", "IntuneWinAppUtil.exe download failed", MessageBoxButtons.RetryCancel);
                            if (response2 == DialogResult.Cancel)
                            {
                                Environment.Exit(2);
                            }
                        }
                    }
                    while (true);

                }
                else
                {
                    Environment.Exit(1);
                }
            }
        }

        public void Compile()
        {
            this.outputTextBox.Text = string.Empty;

            string IWAUPath = System.IO.Directory.GetCurrentDirectory() + "/IWAU/IntuneWinAppUtil.exe";

            if (!Properties.Settings.Default.UseBuildInIWAU)
            {
                IWAUPath = Properties.Settings.Default.CustomIWAUPath;
            }

            if (!SanityCheck())
            {
                return;
            }

            string setupFilePath = this.setupFileTextBox.Text;

            if (setupFilePath.StartsWith(".\\"))
            {
                setupFilePath = this.setupDirectoryTextBox.Text + setupFilePath.Substring(1);
            }

            var proc = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = IWAUPath,
                    Arguments = $"-c {this.setupDirectoryTextBox.Text} -s {setupFilePath} -o {this.outputDirectoryTextBox.Text} -q",
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true
                }
            };

            this.compileBtn.Enabled = false;
            this.compileBtn.Text = "Working";
            this.compileBtn.Refresh();
            proc.Start();
            while (!proc.StandardOutput.EndOfStream)
            {
                string line = proc.StandardOutput.ReadLine();
                WriteToLogConsole(line);
            }
            proc.WaitForExit();
            this.compileBtn.Enabled = true;
            this.compileBtn.Text = "Compile";
            this.compileBtn.Refresh();

            if (Properties.Settings.Default.OpenOutputWhenDone)
            {

                if (Directory.Exists(this.outputDirectoryTextBox.Text))
                {
                    ProcessStartInfo startInfo = new ProcessStartInfo
                    {
                        FileName = "explorer.exe",
                        Arguments = this.outputDirectoryTextBox.Text,
                        UseShellExecute = true,
                    };
                    Process.Start(startInfo);
                }
                else
                {
                    MessageBox.Show(string.Format("{0} Directory does not exist!", this.outputDirectoryTextBox.Text));
                }
            }

        }

        public void WriteToLogConsole(string text, int format = -1)
        {
            Color printColor = Color.White;
            if (format == -1)
            {
                if (text.Contains("INFO"))
                {
                    printColor = Color.Cyan;
                }
                else if (text.Contains("WARN"))
                {
                    printColor = Color.Yellow;
                }
                else if (text.Contains("ERR"))
                {
                    printColor = Color.Red;
                }
            }
            this.outputTextBox.SelectionColor = printColor;
            this.outputTextBox.SelectedText = text + Environment.NewLine;
            this.outputTextBox.SelectionStart = this.outputTextBox.TextLength;
            this.outputTextBox.ScrollToCaret();
        }
        public bool SanityCheck()
        {
            bool sane = true;
            
            if (!System.IO.Directory.Exists(this.setupDirectoryTextBox.Text))
            {
                this.setupDirectoryTextBox.BackColor = Color.Red;
                sane = false;
                WriteToLogConsole("[ERROR]: Missing Valid Setup Directory");
            }

            string setupFilePath = this.setupFileTextBox.Text;

            if (setupFilePath.StartsWith(".\\"))
            {
                setupFilePath = this.setupDirectoryTextBox.Text + setupFilePath.Substring(1);
            }

            if (!System.IO.File.Exists(setupFilePath))
            {
                this.setupFileTextBox.BackColor = Color.Red;
                sane = false;
                WriteToLogConsole("[ERROR]: Missing Valid Setup File");
            }

            if (!System.IO.Directory.Exists(this.outputDirectoryTextBox.Text))
            {
                this.outputDirectoryTextBox.BackColor = Color.Red;
                sane = false;
                WriteToLogConsole("[ERROR]: Missing Valid Output Directory");
            }

            return sane;
        }


        private void setupDirectoryTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!System.IO.Directory.Exists(this.setupDirectoryTextBox.Text))
            {
                this.setupDirectoryTextBox.BackColor = Color.Red;
            }
            else if (this.setupDirectoryTextBox.Text.Length == 0)
            {
                this.setupDirectoryTextBox.BackColor = SystemColors.Window;
            }
            else
            {
                this.setupDirectoryTextBox.BackColor = Color.Lime;
            }
        }

        private void setupFileTextBox_TextChanged(object sender, EventArgs e)
        {
            string setupFilePath = this.setupFileTextBox.Text;

            if (setupFilePath.StartsWith(".\\"))
            {
                setupFilePath = this.setupDirectoryTextBox.Text + setupFilePath.Substring(1);
            }

            if (!System.IO.File.Exists(setupFilePath))
            {
                this.setupFileTextBox.BackColor = Color.Red;
            }
            else if (this.setupFileTextBox.Text.Length == 0)
            { 
                this.setupFileTextBox.BackColor = SystemColors.Window;
            }
            else
            {
                this.setupFileTextBox.BackColor = Color.Lime;
            }
        }

        private void outputDirectoryTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!System.IO.Directory.Exists(this.outputDirectoryTextBox.Text))
            {
                this.outputDirectoryTextBox.BackColor = Color.Cyan;
            }
            else if (this.outputDirectoryTextBox.Text.Length == 0)
            {
                this.outputDirectoryTextBox.BackColor = SystemColors.Window;
            }
            else
            {
                this.outputDirectoryTextBox.BackColor = Color.Lime;
            }
        }


        private void directoryDropZone_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void directoryDropZone_DragDrop(object sender, DragEventArgs e)
        {
            string[] fileList = (string[])e.Data.GetData(DataFormats.FileDrop, false);

            this.setupDirectoryTextBox.Text = fileList[0];
            this.outputDirectoryTextBox.Text = fileList[0];

            string[] directoryFiles = System.IO.Directory.GetFiles(fileList[0]);

            foreach (string file in directoryFiles)
            {
                if (file.ToLower().Substring(file.LastIndexOf('\\')+1) == "deploy-application.exe")
                {
                    this.setupFileTextBox.Text = file;
                }
            }
        }

        private void compileBtn_Click(object sender, EventArgs e)
        {
            this.Compile();
        }
    }
}
