
namespace WingetGui
{
    partial class WingetGuiForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.searchBox = new System.Windows.Forms.ComboBox();
            this.installButton = new System.Windows.Forms.Button();
            this.addAppToInstall = new System.Windows.Forms.Button();
            this.installList = new System.Windows.Forms.ListBox();
            this.poweredByLinkLabel = new System.Windows.Forms.LinkLabel();
            this.removeAppFromInstall = new System.Windows.Forms.Button();
            this.totalLabel = new System.Windows.Forms.Label();
            this.total = new System.Windows.Forms.Label();
            this.descriptionTextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // searchBox
            // 
            this.searchBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.searchBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.searchBox.FormattingEnabled = true;
            this.searchBox.Location = new System.Drawing.Point(13, 13);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(234, 23);
            this.searchBox.Sorted = true;
            this.searchBox.TabIndex = 0;
            this.searchBox.SelectedIndexChanged += new System.EventHandler(this.SearchBox_SelectedIndexChanged);
            this.searchBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SearchBox_KeyUp);
            // 
            // installButton
            // 
            this.installButton.Location = new System.Drawing.Point(13, 342);
            this.installButton.Name = "installButton";
            this.installButton.Size = new System.Drawing.Size(233, 23);
            this.installButton.TabIndex = 3;
            this.installButton.Text = "Install";
            this.installButton.UseVisualStyleBackColor = true;
            this.installButton.Click += new System.EventHandler(this.InstallButton_Click);
            // 
            // addAppToInstall
            // 
            this.addAppToInstall.Location = new System.Drawing.Point(253, 13);
            this.addAppToInstall.Name = "addAppToInstall";
            this.addAppToInstall.Size = new System.Drawing.Size(23, 23);
            this.addAppToInstall.TabIndex = 1;
            this.addAppToInstall.Text = "➕";
            this.addAppToInstall.UseVisualStyleBackColor = true;
            this.addAppToInstall.Click += new System.EventHandler(this.AddAppToInstall_Click);
            // 
            // installList
            // 
            this.installList.FormattingEnabled = true;
            this.installList.ItemHeight = 15;
            this.installList.Location = new System.Drawing.Point(13, 167);
            this.installList.Name = "installList";
            this.installList.ScrollAlwaysVisible = true;
            this.installList.Size = new System.Drawing.Size(233, 169);
            this.installList.TabIndex = 4;
            this.installList.KeyUp += new System.Windows.Forms.KeyEventHandler(this.InstallList_KeyUp);
            // 
            // poweredByLinkLabel
            // 
            this.poweredByLinkLabel.AutoSize = true;
            this.poweredByLinkLabel.Location = new System.Drawing.Point(13, 368);
            this.poweredByLinkLabel.Name = "poweredByLinkLabel";
            this.poweredByLinkLabel.Size = new System.Drawing.Size(110, 15);
            this.poweredByLinkLabel.TabIndex = 5;
            this.poweredByLinkLabel.TabStop = true;
            this.poweredByLinkLabel.Text = "Powered by Winget";
            this.poweredByLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.PoweredByLinkLabel_LinkClicked);
            // 
            // removeAppFromInstall
            // 
            this.removeAppFromInstall.Location = new System.Drawing.Point(252, 167);
            this.removeAppFromInstall.Name = "removeAppFromInstall";
            this.removeAppFromInstall.Size = new System.Drawing.Size(23, 23);
            this.removeAppFromInstall.TabIndex = 6;
            this.removeAppFromInstall.Text = "➖";
            this.removeAppFromInstall.UseVisualStyleBackColor = true;
            this.removeAppFromInstall.Click += new System.EventHandler(this.RemoveAppFromInstall_Click);
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Location = new System.Drawing.Point(13, 148);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(35, 15);
            this.totalLabel.TabIndex = 7;
            this.totalLabel.Text = "Total:";
            // 
            // total
            // 
            this.total.AutoSize = true;
            this.total.Location = new System.Drawing.Point(54, 148);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(59, 15);
            this.total.TabIndex = 8;
            this.total.Text = "Loading...";
            // 
            // descriptionTextbox
            // 
            this.descriptionTextbox.Location = new System.Drawing.Point(13, 43);
            this.descriptionTextbox.Multiline = true;
            this.descriptionTextbox.Name = "descriptionTextbox";
            this.descriptionTextbox.ReadOnly = true;
            this.descriptionTextbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.descriptionTextbox.Size = new System.Drawing.Size(234, 102);
            this.descriptionTextbox.TabIndex = 9;
            // 
            // WingetGuiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 394);
            this.Controls.Add(this.descriptionTextbox);
            this.Controls.Add(this.total);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.removeAppFromInstall);
            this.Controls.Add(this.poweredByLinkLabel);
            this.Controls.Add(this.installList);
            this.Controls.Add(this.addAppToInstall);
            this.Controls.Add(this.installButton);
            this.Controls.Add(this.searchBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "WingetGuiForm";
            this.Text = "WingetGUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox searchBox;
        private System.Windows.Forms.Button installButton;
        private System.Windows.Forms.Button addAppToInstall;
        private System.Windows.Forms.ListBox installList;
        private System.Windows.Forms.LinkLabel poweredByLinkLabel;
        private System.Windows.Forms.Button removeAppFromInstall;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label total;
        private System.Windows.Forms.TextBox descriptionTextbox;
    }
}

