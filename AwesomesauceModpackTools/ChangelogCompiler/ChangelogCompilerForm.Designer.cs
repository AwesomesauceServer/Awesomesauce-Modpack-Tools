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
            this.CompilingProgressBar = new System.Windows.Forms.ProgressBar();
            this.HTMLWebBrowser = new System.Windows.Forms.WebBrowser();
            this.GameVersionsComboBox = new System.Windows.Forms.ComboBox();
            this.GameVersionsLabel = new System.Windows.Forms.Label();
            this.ModURLTextBox = new System.Windows.Forms.TextBox();
            this.ModURLLabel = new System.Windows.Forms.Label();
            this.ModURLExampleLabel = new System.Windows.Forms.Label();
            this.CompileButton = new System.Windows.Forms.Button();
            this.ViewSourceLinkLabel = new System.Windows.Forms.LinkLabel();
            this.SourceTextBox = new System.Windows.Forms.TextBox();
            this.MainStatusStrip.SuspendLayout();
            this.HTMLWebBrowserPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainStatusStrip
            // 
            this.MainStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabel});
            this.MainStatusStrip.Location = new System.Drawing.Point(0, 518);
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
            this.HTMLWebBrowserPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HTMLWebBrowserPanel.Controls.Add(this.CompilingProgressBar);
            this.HTMLWebBrowserPanel.Controls.Add(this.HTMLWebBrowser);
            this.HTMLWebBrowserPanel.Controls.Add(this.SourceTextBox);
            this.HTMLWebBrowserPanel.Location = new System.Drawing.Point(-2, -2);
            this.HTMLWebBrowserPanel.Name = "HTMLWebBrowserPanel";
            this.HTMLWebBrowserPanel.Size = new System.Drawing.Size(874, 458);
            this.HTMLWebBrowserPanel.TabIndex = 1;
            // 
            // CompilingProgressBar
            // 
            this.CompilingProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CompilingProgressBar.Location = new System.Drawing.Point(8, 8);
            this.CompilingProgressBar.MarqueeAnimationSpeed = 16;
            this.CompilingProgressBar.Name = "CompilingProgressBar";
            this.CompilingProgressBar.Size = new System.Drawing.Size(859, 10);
            this.CompilingProgressBar.TabIndex = 13;
            this.CompilingProgressBar.Visible = false;
            // 
            // HTMLWebBrowser
            // 
            this.HTMLWebBrowser.AllowWebBrowserDrop = false;
            this.HTMLWebBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HTMLWebBrowser.IsWebBrowserContextMenuEnabled = false;
            this.HTMLWebBrowser.Location = new System.Drawing.Point(0, 0);
            this.HTMLWebBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.HTMLWebBrowser.Name = "HTMLWebBrowser";
            this.HTMLWebBrowser.ScriptErrorsSuppressed = true;
            this.HTMLWebBrowser.Size = new System.Drawing.Size(874, 458);
            this.HTMLWebBrowser.TabIndex = 0;
            this.HTMLWebBrowser.TabStop = false;
            this.HTMLWebBrowser.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.HTMLWebBrowser_DocumentCompleted);
            this.HTMLWebBrowser.Navigating += new System.Windows.Forms.WebBrowserNavigatingEventHandler(this.HTMLWebBrowser_Navigating);
            // 
            // GameVersionsComboBox
            // 
            this.GameVersionsComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.GameVersionsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GameVersionsComboBox.FormattingEnabled = true;
            this.GameVersionsComboBox.Location = new System.Drawing.Point(12, 484);
            this.GameVersionsComboBox.Name = "GameVersionsComboBox";
            this.GameVersionsComboBox.Size = new System.Drawing.Size(110, 21);
            this.GameVersionsComboBox.TabIndex = 1;
            // 
            // GameVersionsLabel
            // 
            this.GameVersionsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.GameVersionsLabel.AutoSize = true;
            this.GameVersionsLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameVersionsLabel.Location = new System.Drawing.Point(9, 468);
            this.GameVersionsLabel.Name = "GameVersionsLabel";
            this.GameVersionsLabel.Size = new System.Drawing.Size(77, 13);
            this.GameVersionsLabel.TabIndex = 13;
            this.GameVersionsLabel.Text = "Game Version";
            // 
            // ModURLTextBox
            // 
            this.ModURLTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ModURLTextBox.Location = new System.Drawing.Point(128, 484);
            this.ModURLTextBox.Name = "ModURLTextBox";
            this.ModURLTextBox.Size = new System.Drawing.Size(492, 22);
            this.ModURLTextBox.TabIndex = 2;
            // 
            // ModURLLabel
            // 
            this.ModURLLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ModURLLabel.AutoSize = true;
            this.ModURLLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModURLLabel.Location = new System.Drawing.Point(125, 468);
            this.ModURLLabel.Name = "ModURLLabel";
            this.ModURLLabel.Size = new System.Drawing.Size(54, 13);
            this.ModURLLabel.TabIndex = 13;
            this.ModURLLabel.Text = "Mod URL";
            // 
            // ModURLExampleLabel
            // 
            this.ModURLExampleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ModURLExampleLabel.AutoSize = true;
            this.ModURLExampleLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModURLExampleLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.ModURLExampleLabel.Location = new System.Drawing.Point(178, 468);
            this.ModURLExampleLabel.Name = "ModURLExampleLabel";
            this.ModURLExampleLabel.Size = new System.Drawing.Size(305, 13);
            this.ModURLExampleLabel.TabIndex = 13;
            this.ModURLExampleLabel.Text = "Example:  https://minecraft.curseforge.com/projects/rftools";
            // 
            // CompileButton
            // 
            this.CompileButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CompileButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.CompileButton.Image = global::AwesomesauceModpackTools.Properties.Resources.Code;
            this.CompileButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CompileButton.Location = new System.Drawing.Point(759, 468);
            this.CompileButton.Name = "CompileButton";
            this.CompileButton.Size = new System.Drawing.Size(100, 37);
            this.CompileButton.TabIndex = 10;
            this.CompileButton.Text = "Compile";
            this.CompileButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CompileButton.UseVisualStyleBackColor = true;
            this.CompileButton.Click += new System.EventHandler(this.CompileButton_Click);
            // 
            // ViewSourceLinkLabel
            // 
            this.ViewSourceLinkLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ViewSourceLinkLabel.AutoSize = true;
            this.ViewSourceLinkLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewSourceLinkLabel.Location = new System.Drawing.Point(3, 522);
            this.ViewSourceLinkLabel.Name = "ViewSourceLinkLabel";
            this.ViewSourceLinkLabel.Size = new System.Drawing.Size(68, 13);
            this.ViewSourceLinkLabel.TabIndex = 15;
            this.ViewSourceLinkLabel.TabStop = true;
            this.ViewSourceLinkLabel.Tag = "";
            this.ViewSourceLinkLabel.Text = "View Source";
            this.ViewSourceLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ViewSourceLinkLabel_LinkClicked);
            // 
            // SourceTextBox
            // 
            this.SourceTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SourceTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SourceTextBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SourceTextBox.Location = new System.Drawing.Point(0, 0);
            this.SourceTextBox.Multiline = true;
            this.SourceTextBox.Name = "SourceTextBox";
            this.SourceTextBox.ReadOnly = true;
            this.SourceTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.SourceTextBox.Size = new System.Drawing.Size(874, 458);
            this.SourceTextBox.TabIndex = 14;
            // 
            // ChangelogCompilerForm
            // 
            this.AcceptButton = this.CompileButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 540);
            this.Controls.Add(this.ViewSourceLinkLabel);
            this.Controls.Add(this.CompileButton);
            this.Controls.Add(this.ModURLLabel);
            this.Controls.Add(this.ModURLTextBox);
            this.Controls.Add(this.ModURLExampleLabel);
            this.Controls.Add(this.GameVersionsLabel);
            this.Controls.Add(this.GameVersionsComboBox);
            this.Controls.Add(this.HTMLWebBrowserPanel);
            this.Controls.Add(this.MainStatusStrip);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(887, 579);
            this.Name = "ChangelogCompilerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Changelog Compiler";
            this.Load += new System.EventHandler(this.ChangelogCompilerForm_Load);
            this.MainStatusStrip.ResumeLayout(false);
            this.MainStatusStrip.PerformLayout();
            this.HTMLWebBrowserPanel.ResumeLayout(false);
            this.HTMLWebBrowserPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip MainStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel;
        private System.Windows.Forms.Panel HTMLWebBrowserPanel;
        private System.Windows.Forms.WebBrowser HTMLWebBrowser;
        private System.Windows.Forms.ComboBox GameVersionsComboBox;
        private System.Windows.Forms.Label GameVersionsLabel;
        private System.Windows.Forms.TextBox ModURLTextBox;
        private System.Windows.Forms.Label ModURLLabel;
        private System.Windows.Forms.Label ModURLExampleLabel;
        private System.Windows.Forms.Button CompileButton;
        private System.Windows.Forms.ProgressBar CompilingProgressBar;
        private System.Windows.Forms.LinkLabel ViewSourceLinkLabel;
        private System.Windows.Forms.TextBox SourceTextBox;
    }
}