using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace IWAU_QuickPackUtility.Properties
{
    public static class HttpHelper
    {
        private static readonly HttpClient _httpClient = new HttpClient();

        public static async Task<bool> DownloadFileAsync(string uri
             , string outputPath)
        {
            Uri uriResult;

            if (!Uri.TryCreate(uri, UriKind.Absolute, out uriResult))
                throw new InvalidOperationException("URI is invalid.");

            byte[] fileBytes = await _httpClient.GetByteArrayAsync(uri);
            Directory.CreateDirectory(System.IO.Directory.GetCurrentDirectory() + "/IWAU");
            File.WriteAllBytes(outputPath, fileBytes);
            return true;
        }
    }
}
