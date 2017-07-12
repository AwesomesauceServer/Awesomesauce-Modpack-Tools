namespace AwesomesauceModpackTools.Updater {
    partial class UpdaterForm {
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
            this.MainStatusStrip = new System.Windows.Forms.StatusStrip();
            this.LoadFromPanel = new System.Windows.Forms.Panel();
            this.LoadGitHubButton = new System.Windows.Forms.Button();
            this.LoadLocalButton = new System.Windows.Forms.Button();
            this.LoadFromGitHubLabel = new System.Windows.Forms.Label();
            this.PacksComboBox = new System.Windows.Forms.ComboBox();
            this.OrLabel = new System.Windows.Forms.Label();
            this.ModListView = new System.Windows.Forms.ListView();
            this.NameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CurrentFileColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UpdatedFileColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LoadModListDialog = new System.Windows.Forms.OpenFileDialog();
            this.SaveModListDialog = new System.Windows.Forms.SaveFileDialog();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.ExampleUpdateAvailableLabel = new System.Windows.Forms.Label();
            this.ExampleSkippedLabel = new System.Windows.Forms.Label();
            this.ExampleNoUpdateLabel = new System.Windows.Forms.Label();
            this.ExampleCheckingLabel = new System.Windows.Forms.Label();
            this.ExampleStatusColorsLabel = new System.Windows.Forms.Label();
            this.GameVersionsComboBox = new System.Windows.Forms.ComboBox();
            this.GameVersionsLabel = new System.Windows.Forms.Label();
            this.GameVersionsInfoLabel = new System.Windows.Forms.Label();
            this.SavePanel = new System.Windows.Forms.Panel();
            this.SaveLabel = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.ExampleUpdateErrorLabel = new System.Windows.Forms.Label();
            this.LoadFromPanel.SuspendLayout();
            this.SavePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainStatusStrip
            // 
            this.MainStatusStrip.Location = new System.Drawing.Point(0, 567);
            this.MainStatusStrip.Name = "MainStatusStrip";
            this.MainStatusStrip.Size = new System.Drawing.Size(891, 22);
            this.MainStatusStrip.TabIndex = 8;
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
            this.LoadFromPanel.TabIndex = 9;
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
            // ModListView
            // 
            this.ModListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ModListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NameColumn,
            this.CurrentFileColumn,
            this.UpdatedFileColumn});
            this.ModListView.FullRowSelect = true;
            this.ModListView.HideSelection = false;
            this.ModListView.Location = new System.Drawing.Point(238, 12);
            this.ModListView.MultiSelect = false;
            this.ModListView.Name = "ModListView";
            this.ModListView.Size = new System.Drawing.Size(639, 541);
            this.ModListView.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.ModListView.TabIndex = 10;
            this.ModListView.UseCompatibleStateImageBehavior = false;
            this.ModListView.View = System.Windows.Forms.View.Details;
            // 
            // NameColumn
            // 
            this.NameColumn.Text = "Name";
            this.NameColumn.Width = 160;
            // 
            // CurrentFileColumn
            // 
            this.CurrentFileColumn.Text = "Current File";
            this.CurrentFileColumn.Width = 225;
            // 
            // UpdatedFileColumn
            // 
            this.UpdatedFileColumn.Text = "Updated File";
            this.UpdatedFileColumn.Width = 225;
            // 
            // LoadModListDialog
            // 
            this.LoadModListDialog.Filter = "JSON Files|*.json|All Files|*.*";
            this.LoadModListDialog.Title = "Load Mod List";
            // 
            // SaveModListDialog
            // 
            this.SaveModListDialog.DefaultExt = "json";
            this.SaveModListDialog.Filter = "JSON Files|*.json|All Files|*.*";
            this.SaveModListDialog.Title = "Save Mod List";
            // 
            // UpdateButton
            // 
            this.UpdateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.UpdateButton.Enabled = false;
            this.UpdateButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateButton.Image = global::AwesomesauceModpackTools.Properties.Resources.UpdatePackage;
            this.UpdateButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UpdateButton.Location = new System.Drawing.Point(12, 509);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(220, 44);
            this.UpdateButton.TabIndex = 11;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // ExampleUpdateAvailableLabel
            // 
            this.ExampleUpdateAvailableLabel.BackColor = System.Drawing.Color.LightGreen;
            this.ExampleUpdateAvailableLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ExampleUpdateAvailableLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExampleUpdateAvailableLabel.Location = new System.Drawing.Point(12, 194);
            this.ExampleUpdateAvailableLabel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 6);
            this.ExampleUpdateAvailableLabel.Name = "ExampleUpdateAvailableLabel";
            this.ExampleUpdateAvailableLabel.Size = new System.Drawing.Size(220, 18);
            this.ExampleUpdateAvailableLabel.TabIndex = 12;
            this.ExampleUpdateAvailableLabel.Text = "Update Available";
            this.ExampleUpdateAvailableLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ExampleSkippedLabel
            // 
            this.ExampleSkippedLabel.BackColor = System.Drawing.Color.Honeydew;
            this.ExampleSkippedLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ExampleSkippedLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExampleSkippedLabel.Location = new System.Drawing.Point(12, 218);
            this.ExampleSkippedLabel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 6);
            this.ExampleSkippedLabel.Name = "ExampleSkippedLabel";
            this.ExampleSkippedLabel.Size = new System.Drawing.Size(220, 18);
            this.ExampleSkippedLabel.TabIndex = 12;
            this.ExampleSkippedLabel.Text = "Skipped (update mode)";
            this.ExampleSkippedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ExampleNoUpdateLabel
            // 
            this.ExampleNoUpdateLabel.BackColor = System.Drawing.Color.LightGray;
            this.ExampleNoUpdateLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ExampleNoUpdateLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExampleNoUpdateLabel.Location = new System.Drawing.Point(12, 242);
            this.ExampleNoUpdateLabel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 6);
            this.ExampleNoUpdateLabel.Name = "ExampleNoUpdateLabel";
            this.ExampleNoUpdateLabel.Size = new System.Drawing.Size(220, 18);
            this.ExampleNoUpdateLabel.TabIndex = 12;
            this.ExampleNoUpdateLabel.Text = "No Update";
            this.ExampleNoUpdateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ExampleCheckingLabel
            // 
            this.ExampleCheckingLabel.BackColor = System.Drawing.Color.LightBlue;
            this.ExampleCheckingLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ExampleCheckingLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExampleCheckingLabel.Location = new System.Drawing.Point(12, 170);
            this.ExampleCheckingLabel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 6);
            this.ExampleCheckingLabel.Name = "ExampleCheckingLabel";
            this.ExampleCheckingLabel.Size = new System.Drawing.Size(220, 18);
            this.ExampleCheckingLabel.TabIndex = 12;
            this.ExampleCheckingLabel.Text = "Checking for Update";
            this.ExampleCheckingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ExampleStatusColorsLabel
            // 
            this.ExampleStatusColorsLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExampleStatusColorsLabel.Location = new System.Drawing.Point(12, 146);
            this.ExampleStatusColorsLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.ExampleStatusColorsLabel.Name = "ExampleStatusColorsLabel";
            this.ExampleStatusColorsLabel.Size = new System.Drawing.Size(220, 18);
            this.ExampleStatusColorsLabel.TabIndex = 12;
            this.ExampleStatusColorsLabel.Text = "Status Colors";
            this.ExampleStatusColorsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GameVersionsComboBox
            // 
            this.GameVersionsComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.GameVersionsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GameVersionsComboBox.FormattingEnabled = true;
            this.GameVersionsComboBox.Items.AddRange(new object[] {
            "1.10.2",
            "1.11.2",
            "1.12"});
            this.GameVersionsComboBox.Location = new System.Drawing.Point(14, 482);
            this.GameVersionsComboBox.Name = "GameVersionsComboBox";
            this.GameVersionsComboBox.Size = new System.Drawing.Size(110, 21);
            this.GameVersionsComboBox.TabIndex = 1;
            this.GameVersionsComboBox.SelectedIndexChanged += new System.EventHandler(this.GameVersionsComboBox_SelectedIndexChanged);
            // 
            // GameVersionsLabel
            // 
            this.GameVersionsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.GameVersionsLabel.AutoSize = true;
            this.GameVersionsLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameVersionsLabel.Location = new System.Drawing.Point(9, 425);
            this.GameVersionsLabel.Name = "GameVersionsLabel";
            this.GameVersionsLabel.Size = new System.Drawing.Size(77, 13);
            this.GameVersionsLabel.TabIndex = 12;
            this.GameVersionsLabel.Text = "Game Version";
            // 
            // GameVersionsInfoLabel
            // 
            this.GameVersionsInfoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.GameVersionsInfoLabel.Location = new System.Drawing.Point(9, 439);
            this.GameVersionsInfoLabel.Name = "GameVersionsInfoLabel";
            this.GameVersionsInfoLabel.Size = new System.Drawing.Size(193, 41);
            this.GameVersionsInfoLabel.TabIndex = 13;
            this.GameVersionsInfoLabel.Text = "Minecraft version that this mod list belongs to. Make sure you pick the correct v" +
    "ersion!";
            // 
            // SavePanel
            // 
            this.SavePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SavePanel.BackColor = System.Drawing.SystemColors.Window;
            this.SavePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SavePanel.Controls.Add(this.SaveLabel);
            this.SavePanel.Controls.Add(this.SaveButton);
            this.SavePanel.Location = new System.Drawing.Point(12, 315);
            this.SavePanel.Name = "SavePanel";
            this.SavePanel.Size = new System.Drawing.Size(220, 100);
            this.SavePanel.TabIndex = 14;
            this.SavePanel.Visible = false;
            // 
            // SaveLabel
            // 
            this.SaveLabel.BackColor = System.Drawing.Color.Transparent;
            this.SaveLabel.Location = new System.Drawing.Point(3, 3);
            this.SaveLabel.Name = "SaveLabel";
            this.SaveLabel.Size = new System.Drawing.Size(212, 59);
            this.SaveLabel.TabIndex = 1;
            // 
            // SaveButton
            // 
            this.SaveButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.Image = global::AwesomesauceModpackTools.Properties.Resources.Save;
            this.SaveButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SaveButton.Location = new System.Drawing.Point(68, 65);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(83, 27);
            this.SaveButton.TabIndex = 0;
            this.SaveButton.Text = "Save";
            this.SaveButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // ExampleUpdateErrorLabel
            // 
            this.ExampleUpdateErrorLabel.BackColor = System.Drawing.Color.Tomato;
            this.ExampleUpdateErrorLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ExampleUpdateErrorLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExampleUpdateErrorLabel.Location = new System.Drawing.Point(12, 266);
            this.ExampleUpdateErrorLabel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 6);
            this.ExampleUpdateErrorLabel.Name = "ExampleUpdateErrorLabel";
            this.ExampleUpdateErrorLabel.Size = new System.Drawing.Size(220, 18);
            this.ExampleUpdateErrorLabel.TabIndex = 12;
            this.ExampleUpdateErrorLabel.Text = "Update Error";
            this.ExampleUpdateErrorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UpdaterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 589);
            this.Controls.Add(this.SavePanel);
            this.Controls.Add(this.GameVersionsInfoLabel);
            this.Controls.Add(this.ExampleNoUpdateLabel);
            this.Controls.Add(this.ExampleCheckingLabel);
            this.Controls.Add(this.GameVersionsLabel);
            this.Controls.Add(this.ExampleStatusColorsLabel);
            this.Controls.Add(this.GameVersionsComboBox);
            this.Controls.Add(this.ExampleUpdateErrorLabel);
            this.Controls.Add(this.ExampleSkippedLabel);
            this.Controls.Add(this.ExampleUpdateAvailableLabel);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.ModListView);
            this.Controls.Add(this.LoadFromPanel);
            this.Controls.Add(this.MainStatusStrip);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(907, 628);
            this.Name = "UpdaterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Updater";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UpdaterForm_FormClosing);
            this.Load += new System.EventHandler(this.UpdaterForm_Load);
            this.LoadFromPanel.ResumeLayout(false);
            this.LoadFromPanel.PerformLayout();
            this.SavePanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip MainStatusStrip;
        private System.Windows.Forms.Panel LoadFromPanel;
        private System.Windows.Forms.Button LoadGitHubButton;
        private System.Windows.Forms.Button LoadLocalButton;
        private System.Windows.Forms.Label LoadFromGitHubLabel;
        private System.Windows.Forms.ComboBox PacksComboBox;
        private System.Windows.Forms.Label OrLabel;
        private System.Windows.Forms.ListView ModListView;
        private System.Windows.Forms.ColumnHeader NameColumn;
        private System.Windows.Forms.ColumnHeader CurrentFileColumn;
        private System.Windows.Forms.OpenFileDialog LoadModListDialog;
        private System.Windows.Forms.SaveFileDialog SaveModListDialog;
        private System.Windows.Forms.ColumnHeader UpdatedFileColumn;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Label ExampleUpdateAvailableLabel;
        private System.Windows.Forms.Label ExampleSkippedLabel;
        private System.Windows.Forms.Label ExampleNoUpdateLabel;
        private System.Windows.Forms.Label ExampleCheckingLabel;
        private System.Windows.Forms.Label ExampleStatusColorsLabel;
        private System.Windows.Forms.ComboBox GameVersionsComboBox;
        private System.Windows.Forms.Label GameVersionsLabel;
        private System.Windows.Forms.Label GameVersionsInfoLabel;
        private System.Windows.Forms.Panel SavePanel;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label SaveLabel;
        private System.Windows.Forms.Label ExampleUpdateErrorLabel;
    }
}