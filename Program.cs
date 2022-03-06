using System;
using System.Diagnostics;
using System.IO;
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
            var wingetPath = $"{Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)}\\Microsoft\\WindowsApps\\winget.exe";

            if (!File.Exists(wingetPath))
            {
                var answer = MessageBox.Show("Winget is not installed. Do you want to download it?", "Winget not installed", MessageBoxButtons.YesNo);

                if (answer == DialogResult.Yes)
                {
                    var process = new ProcessStartInfo
                    {
                        UseShellExecute = true,
                        FileName = "https://github.com/microsoft/winget-cli/releases/latest"
                    };

                    Process.Start(process);
                }

                Environment.Exit(0);
            }

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new WingetGuiForm());
        }
    }
}
