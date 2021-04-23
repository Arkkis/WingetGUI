using System.Collections.Generic;
using System.Diagnostics;

namespace WingetGui
{
    public class AppActions
    {
        public static void InstallApps(List<string> apps)
        {
            var installString = "";

            foreach (var app in apps)
            {
                if (!string.IsNullOrEmpty(installString))
                {
                    installString += "&& ";
                }

                installString += $"winget install {app} ";
            }

            var startInfo = new ProcessStartInfo
            {
                CreateNoWindow = false,
                FileName = "cmd.exe",
                Arguments = $"/C \"{installString}\""
            };

            var process = new Process { StartInfo = startInfo };
            process.Start();
            process.WaitForExit();
        }
    }
}