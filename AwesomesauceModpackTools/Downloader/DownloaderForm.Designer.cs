namespace AwesomesauceModpackTools.Downloader {
    partial class DownloaderForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.PacksComboBox = new System.Windows.Forms.ComboBox();
            this.LoadFromGitHubLabel = new System.Windows.Forms.Label();
            this.OrLabel = new System.Windows.Forms.Label();
            this.LoadFromPanel = new System.Windows.Forms.Panel();
            this.LoadGitHubButton = new System.Windows.Forms.Button();
            this.LoadLocalButton = new System.Windows.Forms.Button();
            this.LoadModListDialog = new System.Windows.Forms.OpenFileDialog();
            this.ModListView = new System.Windows.Forms.ListView();
            this.NameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MD5Column = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MainStatusStrip = new System.Windows.Forms.StatusStrip();
            this.DownloadButton = new System.Windows.Forms.Button();
            this.DownloadBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.ExampleDownloadingLabel = new System.Windows.Forms.Label();
            this.ExampleDownloadErrorLabel = new System.Windows.Forms.Label();
            this.ExampleDownloadedLabel = new System.Windows.Forms.Label();
            this.ExampleStatusColorsLabel = new System.Windows.Forms.Label();
            this.LoadFromPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // PacksComboBox
            // 
            this.PacksComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PacksComboBox.FormattingEnabled = true;
            this.PacksComboBox.Location = new System.Drawing.Point(12, 32);
            this.PacksComboBox.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.PacksComboBox.Name = "PacksComboBox";
            this.PacksComboBox.Size = new System.Drawing.Size(140, 21);
            this.PacksComboBox.TabIndex = 1;
            // 
            // LoadFromGitHubLabel
            // 
            this.LoadFromGitHubLabel.AutoSize = true;
            this.LoadFromGitHubLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadFromGitHubLabel.Location = new System.Drawing.Point(29, 6);
            this.LoadFromGitHubLabel.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.LoadFromGitHubLabel.Name = "LoadFromGitHubLabel";
            this.LoadFromGitHubLabel.Size = new System.Drawing.Size(160, 13);
            this.LoadFromGitHubLabel.TabIndex = 2;
            this.LoadFromGitHubLabel.Text = "Load from pack list on GitHub";
            // 
            // OrLabel
            // 
            this.OrLabel.AutoSize = true;
            this.OrLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrLabel.Location = new System.Drawing.Point(100, 63);
            this.OrLabel.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.OrLabel.Name = "OrLabel";
            this.OrLabel.Size = new System.Drawing.Size(19, 13);
            this.OrLabel.TabIndex = 3;
            this.OrLabel.Text = "Or";
            // 
            // LoadFromPanel
            // 
            this.LoadFromPanel.BackColor = System.Drawing.SystemColors.Window;
            this.LoadFromPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LoadFromPanel.Controls.Add(this.LoadGitHubButton);
            this.LoadFromPanel.Controls.Add(this.LoadLocalButton);
            this.LoadFromPanel.Controls.Add(this.LoadFromGitHubLabel);
            this.LoadFromPanel.Controls.Add(this.PacksComboBox);
            this.LoadFromPanel.Controls.Add(this.OrLabel);
            this.LoadFromPanel.Location = new System.Drawing.Point(12, 12);
            this.LoadFromPanel.Name = "LoadFromPanel";
            this.LoadFromPanel.Size = new System.Drawing.Size(220, 125);
            this.LoadFromPanel.TabIndex = 5;
            // 
            // LoadGitHubButton
            // 
            this.LoadGitHubButton.Enabled = false;
            this.LoadGitHubButton.Image = global::AwesomesauceModpackTools.Properties.Resources.DownloadFile;
            this.LoadGitHubButton.Location = new System.Drawing.Point(153, 31);
            this.LoadGitHubButton.Name = "LoadGitHubButton";
            this.LoadGitHubButton.Size = new System.Drawing.Size(53, 23);
            this.LoadGitHubButton.TabIndex = 6;
            this.LoadGitHubButton.UseVisualStyleBackColor = true;
            this.LoadGitHubButton.Click += new System.EventHandler(this.LoadGitHubButton_Click);
            // 
            // LoadLocalButton
            // 
            this.LoadLocalButton.Image = global::AwesomesauceModpackTools.Properties.Resources.Open;
            this.LoadLocalButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LoadLocalButton.Location = new System.Drawing.Point(39, 89);
            this.LoadLocalButton.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.LoadLocalButton.Name = "LoadLocalButton";
            this.LoadLocalButton.Size = new System.Drawing.Size(140, 23);
            this.LoadLocalButton.TabIndex = 5;
            this.LoadLocalButton.Text = "Load from local file";
            this.LoadLocalButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LoadLocalButton.UseVisualStyleBackColor = true;
            this.LoadLocalButton.Click += new System.EventHandler(this.LoadLocalButton_Click);
            // 
            // LoadModListDialog
            // 
            this.LoadModListDialog.Filter = "JSON Files|*.json|All Files|*.*";
            this.LoadModListDialog.Title = "Load Mod List";
            // 
            // ModListView
            // 
            this.ModListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ModListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NameColumn,
            this.MD5Column});
            this.ModListView.FullRowSelect = true;
            this.ModListView.HideSelection = false;
            this.ModListView.Location = new System.Drawing.Point(238, 12);
            this.ModListView.MultiSelect = false;
            this.ModListView.Name = "ModListView";
            this.ModListView.Size = new System.Drawing.Size(425, 501);
            this.ModListView.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.ModListView.TabIndex = 6;
            this.ModListView.UseCompatibleStateImageBehavior = false;
            this.ModListView.View = System.Windows.Forms.View.Details;
            // 
            // NameColumn
            // 
            this.NameColumn.Text = "Name";
            this.NameColumn.Width = 170;
            // 
            // MD5Column
            // 
            this.MD5Column.Text = "MD5";
            this.MD5Column.Width = 225;
            // 
            // MainStatusStrip
            // 
            this.MainStatusStrip.Location = new System.Drawing.Point(0, 525);
            this.MainStatusStrip.Name = "MainStatusStrip";
            this.MainStatusStrip.Size = new System.Drawing.Size(674, 22);
            this.MainStatusStrip.TabIndex = 7;
            // 
            // DownloadButton
            // 
            this.DownloadButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DownloadButton.Enabled = false;
            this.DownloadButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DownloadButton.Image = global::AwesomesauceModpackTools.Properties.Resources.DownloadLarge;
            this.DownloadButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DownloadButton.Location = new System.Drawing.Point(12, 469);
            this.DownloadButton.Name = "DownloadButton";
            this.DownloadButton.Size = new System.Drawing.Size(220, 44);
            this.DownloadButton.TabIndex = 8;
            this.DownloadButton.Text = "Download";
            this.DownloadButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DownloadButton.UseVisualStyleBackColor = true;
            this.DownloadButton.Click += new System.EventHandler(this.DownloadButton_Click);
            // 
            // DownloadBrowserDialog
            // 
            this.DownloadBrowserDialog.Description = "Select where to download the mods to";
            // 
            // ExampleDownloadingLabel
            // 
            this.ExampleDownloadingLabel.BackColor = System.Drawing.Color.LightBlue;
            this.ExampleDownloadingLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ExampleDownloadingLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExampleDownloadingLabel.Location = new System.Drawing.Point(12, 170);
            this.ExampleDownloadingLabel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 6);
            this.ExampleDownloadingLabel.Name = "ExampleDownloadingLabel";
            this.ExampleDownloadingLabel.Size = new System.Drawing.Size(220, 18);
            this.ExampleDownloadingLabel.TabIndex = 14;
            this.ExampleDownloadingLabel.Text = "Downloading";
            this.ExampleDownloadingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ExampleDownloadErrorLabel
            // 
            this.ExampleDownloadErrorLabel.BackColor = System.Drawing.Color.Tomato;
            this.ExampleDownloadErrorLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ExampleDownloadErrorLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExampleDownloadErrorLabel.Location = new System.Drawing.Point(12, 218);
            this.ExampleDownloadErrorLabel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 6);
            this.ExampleDownloadErrorLabel.Name = "ExampleDownloadErrorLabel";
            this.ExampleDownloadErrorLabel.Size = new System.Drawing.Size(220, 18);
            this.ExampleDownloadErrorLabel.TabIndex = 15;
            this.ExampleDownloadErrorLabel.Text = "Download Error";
            this.ExampleDownloadErrorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ExampleDownloadedLabel
            // 
            this.ExampleDownloadedLabel.BackColor = System.Drawing.Color.LightGreen;
            this.ExampleDownloadedLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ExampleDownloadedLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExampleDownloadedLabel.Location = new System.Drawing.Point(12, 194);
            this.ExampleDownloadedLabel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 6);
            this.ExampleDownloadedLabel.Name = "ExampleDownloadedLabel";
            this.ExampleDownloadedLabel.Size = new System.Drawing.Size(220, 18);
            this.ExampleDownloadedLabel.TabIndex = 16;
            this.ExampleDownloadedLabel.Text = "Downloaded";
            this.ExampleDownloadedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ExampleStatusColorsLabel
            // 
            this.ExampleStatusColorsLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExampleStatusColorsLabel.Location = new System.Drawing.Point(12, 146);
            this.ExampleStatusColorsLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.ExampleStatusColorsLabel.Name = "ExampleStatusColorsLabel";
            this.ExampleStatusColorsLabel.Size = new System.Drawing.Size(220, 18);
            this.ExampleStatusColorsLabel.TabIndex = 17;
            this.ExampleStatusColorsLabel.Text = "Status Colors";
            this.ExampleStatusColorsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DownloaderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 547);
            this.Controls.Add(this.ExampleStatusColorsLabel);
            this.Controls.Add(this.ExampleDownloadingLabel);
            this.Controls.Add(this.ExampleDownloadErrorLabel);
            this.Controls.Add(this.ExampleDownloadedLabel);
            this.Controls.Add(this.DownloadButton);
            this.Controls.Add(this.MainStatusStrip);
            this.Controls.Add(this.ModListView);
            this.Controls.Add(this.LoadFromPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(690, 586);
            this.Name = "DownloaderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Downloader";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DownloaderForm_FormClosing);
            this.Load += new System.EventHandler(this.DownloaderForm_Load);
            this.LoadFromPanel.ResumeLayout(false);
            this.LoadFromPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox PacksComboBox;
        private System.Windows.Forms.Label LoadFromGitHubLabel;
        private System.Windows.Forms.Label OrLabel;
        private System.Windows.Forms.Panel LoadFromPanel;
        private System.Windows.Forms.Button LoadLocalButton;
        private System.Windows.Forms.OpenFileDialog LoadModListDialog;
        private System.Windows.Forms.ListView ModListView;
        private System.Windows.Forms.ColumnHeader NameColumn;
        private System.Windows.Forms.ColumnHeader MD5Column;
        private System.Windows.Forms.Button LoadGitHubButton;
        private System.Windows.Forms.StatusStrip MainStatusStrip;
        private System.Windows.Forms.Button DownloadButton;
        private System.Windows.Forms.FolderBrowserDialog DownloadBrowserDialog;
        private System.Windows.Forms.Label ExampleDownloadingLabel;
        private System.Windows.Forms.Label ExampleDownloadErrorLabel;
        private System.Windows.Forms.Label ExampleDownloadedLabel;
        private System.Windows.Forms.Label ExampleStatusColorsLabel;
    }
}