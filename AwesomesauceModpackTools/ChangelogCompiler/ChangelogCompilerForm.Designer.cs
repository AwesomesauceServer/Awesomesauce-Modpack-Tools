namespace AwesomesauceModpackTools.ChangelogCompiler {
    partial class ChangelogCompilerForm {
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
            this.StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.HTMLWebBrowserPanel = new System.Windows.Forms.Panel();
            this.HTMLWebBrowser = new System.Windows.Forms.WebBrowser();
            this.GameVersionsComboBox = new System.Windows.Forms.ComboBox();
            this.MainStatusStrip.SuspendLayout();
            this.HTMLWebBrowserPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainStatusStrip
            // 
            this.MainStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabel});
            this.MainStatusStrip.Location = new System.Drawing.Point(0, 553);
            this.MainStatusStrip.Name = "MainStatusStrip";
            this.MainStatusStrip.Size = new System.Drawing.Size(871, 22);
            this.MainStatusStrip.TabIndex = 0;
            this.MainStatusStrip.Text = "statusStrip1";
            // 
            // StatusLabel
            // 
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // HTMLWebBrowserPanel
            // 
            this.HTMLWebBrowserPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HTMLWebBrowserPanel.Controls.Add(this.HTMLWebBrowser);
            this.HTMLWebBrowserPanel.Location = new System.Drawing.Point(-2, -2);
            this.HTMLWebBrowserPanel.Name = "HTMLWebBrowserPanel";
            this.HTMLWebBrowserPanel.Size = new System.Drawing.Size(874, 458);
            this.HTMLWebBrowserPanel.TabIndex = 1;
            // 
            // HTMLWebBrowser
            // 
            this.HTMLWebBrowser.AllowWebBrowserDrop = false;
            this.HTMLWebBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HTMLWebBrowser.IsWebBrowserContextMenuEnabled = false;
            this.HTMLWebBrowser.Location = new System.Drawing.Point(0, 0);
            this.HTMLWebBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.HTMLWebBrowser.Name = "HTMLWebBrowser";
            this.HTMLWebBrowser.Size = new System.Drawing.Size(874, 458);
            this.HTMLWebBrowser.TabIndex = 0;
            // 
            // GameVersionsComboBox
            // 
            this.GameVersionsComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.GameVersionsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GameVersionsComboBox.FormattingEnabled = true;
            this.GameVersionsComboBox.Location = new System.Drawing.Point(36, 502);
            this.GameVersionsComboBox.Name = "GameVersionsComboBox";
            this.GameVersionsComboBox.Size = new System.Drawing.Size(110, 21);
            this.GameVersionsComboBox.TabIndex = 2;
            // 
            // ChangelogCompilerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 575);
            this.Controls.Add(this.GameVersionsComboBox);
            this.Controls.Add(this.HTMLWebBrowserPanel);
            this.Controls.Add(this.MainStatusStrip);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "ChangelogCompilerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Changelog Compiler";
            this.Load += new System.EventHandler(this.ChangelogCompilerForm_Load);
            this.MainStatusStrip.ResumeLayout(false);
            this.MainStatusStrip.PerformLayout();
            this.HTMLWebBrowserPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip MainStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel;
        private System.Windows.Forms.Panel HTMLWebBrowserPanel;
        private System.Windows.Forms.WebBrowser HTMLWebBrowser;
        private System.Windows.Forms.ComboBox GameVersionsComboBox;
    }
}