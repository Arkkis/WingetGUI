using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Diagnostics;
using System.Linq;

namespace WingetGui
{
    public partial class WingetGuiForm : Form
    {
        private List<AppDto> apps = new();

        public WingetGuiForm()
        {
            InitializeComponent();
            Start();
        }

        private async void Start()
        {
            var formInit = new FormInit();
            apps = await formInit.GetApps();

            FormInit.FillSearchBox(apps, searchBox);

            total.Text = $"{searchBox.Items.Count}";
        }

        private void InstallButton_Click(object sender, EventArgs e)
        {
            var selectedApps = installList.Items;

            if (selectedApps.Count == 0)
            {
                return;
            }

            var appList = new List<string>();

            foreach (var selectedApp in selectedApps)
            {
                appList.Add(apps.FirstOrDefault(app => app.packageName == selectedApp.ToString()).packageIdentifier);
            }

            installButton.Enabled = false;
            AppActions.InstallApps(appList);
            installButton.Enabled = true;
            MessageBox.Show("Installation complete!");
        }

        private void AddAppToInstall_Click(object sender, EventArgs e)
        {
            var selected = "";

            if (searchBox.SelectedItem != null)
            {
                selected = searchBox.SelectedItem.ToString();
            }

            if (!string.IsNullOrEmpty(selected) && !installList.Items.Contains(selected))
            {
                installList.Items.Add(selected);
            }
        }

        private void RemoveAppFromInstall_Click(object sender, EventArgs e)
        {
            installList.Items.Remove(installList.SelectedItem);

            if (installList.Items.Count > 0)
            {
                installList.SetSelected(0, true);
            }
        }

        private void SearchBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AddAppToInstall_Click(new object(), new EventArgs());
            }
        }

        private void InstallList_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                RemoveAppFromInstall_Click(new object(), new EventArgs());
            }
        }

        private void PoweredByLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var processStart = new ProcessStartInfo("https://docs.microsoft.com/en-us/windows/package-manager/winget/")
            {
                UseShellExecute = true,
                Verb = "open"
            };

            Process.Start(processStart);
        }

        private void SearchBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            descriptionTextbox.Text = apps.FirstOrDefault(app => app.packageName == searchBox.SelectedItem.ToString()).description;
        }
    }
}
