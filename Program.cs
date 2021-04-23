using System;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Windows.Forms;

namespace WingetGui
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var extractedZipPath = $"{AppContext.BaseDirectory}winget-pkgs-master";
            var zipPath = $"{AppContext.BaseDirectory}master.zip";
            var cachePath = $"{AppContext.BaseDirectory}cache";
            var appCachePath = $"{cachePath}\\AppListCache.json";
            var treeCachePath = $"{cachePath}\\tree.json";
            var treeListCachePath = $"{cachePath}\\treelist.json";

            if (!File.Exists(appCachePath) || !File.Exists(treeCachePath) || !File.Exists(treeListCachePath))
            {
                MessageBox.Show("Creating cache for apps. This could take a while.");
            }

            if (!Directory.Exists(cachePath))
            {
                MessageBox.Show("Startíng to cache database. This could take a while.");

                if (Directory.Exists(extractedZipPath))
                {
                    Directory.Delete(extractedZipPath, true);
                }

                var webClient = new WebClient();
                webClient.Headers.Add("User-Agent", "request");
                webClient.DownloadFile(new Uri("https://github.com/microsoft/winget-pkgs/archive/refs/heads/master.zip"), zipPath);

                ZipFile.ExtractToDirectory(zipPath, AppContext.BaseDirectory);

                Directory.Move($"{extractedZipPath}\\manifests", cachePath);

                if (Directory.Exists(extractedZipPath))
                {
                    Directory.Delete(extractedZipPath, true);
                }

                if (File.Exists(zipPath))
                {
                    File.Delete(zipPath);
                }
            }

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new WingetGuiForm());
        }
    }
}
