namespace IWAU_QuickPackUtility
{
    partial class ManagementUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.compileBtn = new System.Windows.Forms.Button();
            this.directoryDropZone = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.outputTextBox = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.setupDirectoryTextBox = new System.Windows.Forms.TextBox();
            this.setupFileTextBox = new System.Windows.Forms.TextBox();
            this.outputDirectoryTextBox = new System.Windows.Forms.TextBox();
            this.compileButtonToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.setupDirectoryToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.setupFileToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.outputDirectoryToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.dropZoneToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.outputConsoleToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 253F));
            this.tableLayoutPanel1.Controls.Add(this.compileBtn, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.directoryDropZone, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(790, 338);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // compileBtn
            // 
            this.compileBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.compileBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compileBtn.Location = new System.Drawing.Point(537, 288);
            this.compileBtn.Name = "compileBtn";
            this.compileBtn.Size = new System.Drawing.Size(247, 44);
            this.compileBtn.TabIndex = 0;
            this.compileBtn.Text = "Compile";
            this.compileButtonToolTip.SetToolTip(this.compileBtn, "Click to perform sanity check on paths and compile application package to .intune" +
        "win file.");
            this.compileBtn.UseVisualStyleBackColor = true;
            this.compileBtn.Click += new System.EventHandler(this.compileBtn_Click);
            // 
            // directoryDropZone
            // 
            this.directoryDropZone.AllowDrop = true;
            this.directoryDropZone.AutoSize = true;
            this.directoryDropZone.BackColor = System.Drawing.Color.SkyBlue;
            this.directoryDropZone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.directoryDropZone.Location = new System.Drawing.Point(534, 3);
            this.directoryDropZone.Margin = new System.Windows.Forms.Padding(0);
            this.directoryDropZone.Name = "directoryDropZone";
            this.directoryDropZone.Size = new System.Drawing.Size(253, 279);
            this.directoryDropZone.TabIndex = 2;
            this.directoryDropZone.Text = "Drop application directory here!";
            this.directoryDropZone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dropZoneToolTip.SetToolTip(this.directoryDropZone, "Drag & Drop the entire application package directory to autofill values on the le" +
        "ft.\r\n\r\nIf \"Deploy-Application.exe\" is detected, it will populate \"Setup File\" wi" +
        "th the absolute path.");
            this.directoryDropZone.DragDrop += new System.Windows.Forms.DragEventHandler(this.directoryDropZone_DragDrop);
            this.directoryDropZone.DragEnter += new System.Windows.Forms.DragEventHandler(this.directoryDropZone_DragEnter);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 121F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.outputTextBox, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.setupDirectoryTextBox, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.setupFileTextBox, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.outputDirectoryTextBox, 1, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel1.SetRowSpan(this.tableLayoutPanel2, 2);
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(528, 332);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // outputTextBox
            // 
            this.outputTextBox.BackColor = System.Drawing.Color.Black;
            this.tableLayoutPanel2.SetColumnSpan(this.outputTextBox, 2);
            this.outputTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outputTextBox.ForeColor = System.Drawing.Color.White;
            this.outputTextBox.Location = new System.Drawing.Point(3, 108);
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.ReadOnly = true;
            this.tableLayoutPanel2.SetRowSpan(this.outputTextBox, 2);
            this.outputTextBox.Size = new System.Drawing.Size(522, 221);
            this.outputTextBox.TabIndex = 0;
            this.outputTextBox.Text = "";
            this.outputConsoleToolTip.SetToolTip(this.outputTextBox, "Displays formated output from the IntuneWinAppUtil.exe\r\n\r\nLegend:\r\nCyan = Informa" +
        "tion\r\nYellow =Warning\r\nRed =Error\r\nWhite = Undefined output");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 35);
            this.label2.TabIndex = 1;
            this.label2.Text = "Setup Directory:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.setupDirectoryToolTip.SetToolTip(this.label2, "Absolute path to setup directory.");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(0, 35);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 35);
            this.label3.TabIndex = 2;
            this.label3.Text = "Setup File:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.setupFileToolTip.SetToolTip(this.label3, "Enter an absolute OR relative path to the setup file.\r\n\r\nAbsolute: The complete p" +
        "ath from disk root.\r\nRelative: Starts with .\\ and has root in setup directory.\r\n" +
        "");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(0, 70);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 35);
            this.label4.TabIndex = 3;
            this.label4.Text = "Output Directory:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.outputDirectoryToolTip.SetToolTip(this.label4, "Absolute path to output directory for the .intunewin file.\r\n\r\nIf the directory do" +
        "n\'t exist the program will create it.\r\nAbove is shown by a CYAN background.\r\n");
            // 
            // setupDirectoryTextBox
            // 
            this.setupDirectoryTextBox.AllowDrop = true;
            this.setupDirectoryTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.setupDirectoryTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setupDirectoryTextBox.Location = new System.Drawing.Point(124, 6);
            this.setupDirectoryTextBox.Name = "setupDirectoryTextBox";
            this.setupDirectoryTextBox.Size = new System.Drawing.Size(401, 22);
            this.setupDirectoryTextBox.TabIndex = 4;
            this.setupDirectoryToolTip.SetToolTip(this.setupDirectoryTextBox, "Absolute path to setup directory.");
            this.setupDirectoryTextBox.TextChanged += new System.EventHandler(this.setupDirectoryTextBox_TextChanged);
            // 
            // setupFileTextBox
            // 
            this.setupFileTextBox.AllowDrop = true;
            this.setupFileTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.setupFileTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setupFileTextBox.Location = new System.Drawing.Point(124, 41);
            this.setupFileTextBox.Name = "setupFileTextBox";
            this.setupFileTextBox.Size = new System.Drawing.Size(401, 22);
            this.setupFileTextBox.TabIndex = 5;
            this.setupFileToolTip.SetToolTip(this.setupFileTextBox, "Enter an absolute OR relative path to the setup file.\r\n\r\nAbsolute: The complete p" +
        "ath from disk root.\r\nRelative: Starts with .\\ and has root in setup directory.");
            this.setupFileTextBox.TextChanged += new System.EventHandler(this.setupFileTextBox_TextChanged);
            // 
            // outputDirectoryTextBox
            // 
            this.outputDirectoryTextBox.AllowDrop = true;
            this.outputDirectoryTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.outputDirectoryTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputDirectoryTextBox.Location = new System.Drawing.Point(124, 76);
            this.outputDirectoryTextBox.Name = "outputDirectoryTextBox";
            this.outputDirectoryTextBox.Size = new System.Drawing.Size(401, 22);
            this.outputDirectoryTextBox.TabIndex = 6;
            this.outputDirectoryToolTip.SetToolTip(this.outputDirectoryTextBox, "Absolute path to output directory for the .intunewin file.\r\n\r\nIf the directory do" +
        "n\'t exist the program will create it.\r\nAbove is shown by a CYAN background.");
            this.outputDirectoryTextBox.TextChanged += new System.EventHandler(this.outputDirectoryTextBox_TextChanged);
            // 
            // compileButtonToolTip
            // 
            this.compileButtonToolTip.ToolTipTitle = "Compile!";
            // 
            // setupDirectoryToolTip
            // 
            this.setupDirectoryToolTip.ToolTipTitle = "Setup Directory";
            // 
            // setupFileToolTip
            // 
            this.setupFileToolTip.ToolTipTitle = "Setup File";
            // 
            // dropZoneToolTip
            // 
            this.dropZoneToolTip.ToolTipTitle = "The drop zone!";
            // 
            // outputConsoleToolTip
            // 
            this.outputConsoleToolTip.ToolTipTitle = "Output Console";
            // 
            // ManagementUI
            // 
            this.AcceptButton = this.compileBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(790, 338);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.Name = "ManagementUI";
            this.Text = "IWAU - QuickPackUtility";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button compileBtn;
        private System.Windows.Forms.Label directoryDropZone;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.RichTextBox outputTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox setupDirectoryTextBox;
        private System.Windows.Forms.TextBox setupFileTextBox;
        private System.Windows.Forms.TextBox outputDirectoryTextBox;
        private System.Windows.Forms.ToolTip compileButtonToolTip;
        private System.Windows.Forms.ToolTip setupDirectoryToolTip;
        private System.Windows.Forms.ToolTip setupFileToolTip;
        private System.Windows.Forms.ToolTip outputDirectoryToolTip;
        private System.Windows.Forms.ToolTip dropZoneToolTip;
        private System.Windows.Forms.ToolTip outputConsoleToolTip;
    }
}

