namespace AwesomesauceModpackTools {
    partial class MainForm {
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
            this.ManageModsButton = new System.Windows.Forms.Button();
            this.GitHubTabControl = new System.Windows.Forms.TabControl();
            this.ModpackTabPage = new System.Windows.Forms.TabPage();
            this.ModpackListView = new System.Windows.Forms.ListView();
            this.ModpackDateColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ModpackUpdateColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ToolsTabPage = new System.Windows.Forms.TabPage();
            this.ToolsListView = new System.Windows.Forms.ListView();
            this.ToolsDateColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ToolsUpdateColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MainStatusStrip = new System.Windows.Forms.StatusStrip();
            this.DownloaderButton = new System.Windows.Forms.Button();
            this.GitHubTabControl.SuspendLayout();
            this.ModpackTabPage.SuspendLayout();
            this.ToolsTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // ManageModsButton
            // 
            this.ManageModsButton.Location = new System.Drawing.Point(672, 34);
            this.ManageModsButton.Name = "ManageModsButton";
            this.ManageModsButton.Size = new System.Drawing.Size(116, 23);
            this.ManageModsButton.TabIndex = 1;
            this.ManageModsButton.Text = "Manage Mods";
            this.ManageModsButton.UseVisualStyleBackColor = true;
            this.ManageModsButton.Click += new System.EventHandler(this.ManageModsButton_Click);
            // 
            // GitHubTabControl
            // 
            this.GitHubTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.GitHubTabControl.Controls.Add(this.ModpackTabPage);
            this.GitHubTabControl.Controls.Add(this.ToolsTabPage);
            this.GitHubTabControl.Location = new System.Drawing.Point(12, 12);
            this.GitHubTabControl.Name = "GitHubTabControl";
            this.GitHubTabControl.SelectedIndex = 0;
            this.GitHubTabControl.Size = new System.Drawing.Size(654, 282);
            this.GitHubTabControl.TabIndex = 1;
            this.GitHubTabControl.TabStop = false;
            // 
            // ModpackTabPage
            // 
            this.ModpackTabPage.Controls.Add(this.ModpackListView);
            this.ModpackTabPage.Location = new System.Drawing.Point(4, 22);
            this.ModpackTabPage.Name = "ModpackTabPage";
            this.ModpackTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.ModpackTabPage.Size = new System.Drawing.Size(646, 256);
            this.ModpackTabPage.TabIndex = 0;
            this.ModpackTabPage.Text = "Awesomesauce Modpack";
            this.ModpackTabPage.UseVisualStyleBackColor = true;
            // 
            // ModpackListView
            // 
            this.ModpackListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ModpackDateColumn,
            this.ModpackUpdateColumn});
            this.ModpackListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ModpackListView.FullRowSelect = true;
            this.ModpackListView.HideSelection = false;
            this.ModpackListView.Location = new System.Drawing.Point(3, 3);
            this.ModpackListView.MultiSelect = false;
            this.ModpackListView.Name = "ModpackListView";
            this.ModpackListView.Size = new System.Drawing.Size(640, 250);
            this.ModpackListView.TabIndex = 0;
            this.ModpackListView.UseCompatibleStateImageBehavior = false;
            this.ModpackListView.View = System.Windows.Forms.View.Details;
            // 
            // ModpackDateColumn
            // 
            this.ModpackDateColumn.Text = "Date";
            this.ModpackDateColumn.Width = 120;
            // 
            // ModpackUpdateColumn
            // 
            this.ModpackUpdateColumn.Text = "Update";
            this.ModpackUpdateColumn.Width = 750;
            // 
            // ToolsTabPage
            // 
            this.ToolsTabPage.Controls.Add(this.ToolsListView);
            this.ToolsTabPage.Location = new System.Drawing.Point(4, 22);
            this.ToolsTabPage.Name = "ToolsTabPage";
            this.ToolsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.ToolsTabPage.Size = new System.Drawing.Size(646, 256);
            this.ToolsTabPage.TabIndex = 1;
            this.ToolsTabPage.Text = "Awesomesauce Modpack Tools";
            this.ToolsTabPage.UseVisualStyleBackColor = true;
            // 
            // ToolsListView
            // 
            this.ToolsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ToolsDateColumn,
            this.ToolsUpdateColumn});
            this.ToolsListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ToolsListView.FullRowSelect = true;
            this.ToolsListView.HideSelection = false;
            this.ToolsListView.Location = new System.Drawing.Point(3, 3);
            this.ToolsListView.MultiSelect = false;
            this.ToolsListView.Name = "ToolsListView";
            this.ToolsListView.Size = new System.Drawing.Size(640, 250);
            this.ToolsListView.TabIndex = 1;
            this.ToolsListView.UseCompatibleStateImageBehavior = false;
            this.ToolsListView.View = System.Windows.Forms.View.Details;
            // 
            // ToolsDateColumn
            // 
            this.ToolsDateColumn.Text = "Date";
            this.ToolsDateColumn.Width = 120;
            // 
            // ToolsUpdateColumn
            // 
            this.ToolsUpdateColumn.Text = "Update";
            this.ToolsUpdateColumn.Width = 750;
            // 
            // MainStatusStrip
            // 
            this.MainStatusStrip.Location = new System.Drawing.Point(0, 304);
            this.MainStatusStrip.Name = "MainStatusStrip";
            this.MainStatusStrip.Size = new System.Drawing.Size(801, 22);
            this.MainStatusStrip.TabIndex = 2;
            // 
            // DownloaderButton
            // 
            this.DownloaderButton.Location = new System.Drawing.Point(672, 63);
            this.DownloaderButton.Name = "DownloaderButton";
            this.DownloaderButton.Size = new System.Drawing.Size(116, 23);
            this.DownloaderButton.TabIndex = 2;
            this.DownloaderButton.Text = "Downloader";
            this.DownloaderButton.UseVisualStyleBackColor = true;
            this.DownloaderButton.Click += new System.EventHandler(this.DownloaderButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 326);
            this.Controls.Add(this.DownloaderButton);
            this.Controls.Add(this.MainStatusStrip);
            this.Controls.Add(this.GitHubTabControl);
            this.Controls.Add(this.ManageModsButton);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(817, 365);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Awesomesauce Modpack Tools";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.GitHubTabControl.ResumeLayout(false);
            this.ModpackTabPage.ResumeLayout(false);
            this.ToolsTabPage.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ManageModsButton;
        private System.Windows.Forms.TabControl GitHubTabControl;
        private System.Windows.Forms.TabPage ModpackTabPage;
        private System.Windows.Forms.TabPage ToolsTabPage;
        private System.Windows.Forms.ListView ModpackListView;
        private System.Windows.Forms.ColumnHeader ModpackDateColumn;
        private System.Windows.Forms.ColumnHeader ModpackUpdateColumn;
        private System.Windows.Forms.ListView ToolsListView;
        private System.Windows.Forms.ColumnHeader ToolsDateColumn;
        private System.Windows.Forms.ColumnHeader ToolsUpdateColumn;
        private System.Windows.Forms.StatusStrip MainStatusStrip;
        private System.Windows.Forms.Button DownloaderButton;
    }
}