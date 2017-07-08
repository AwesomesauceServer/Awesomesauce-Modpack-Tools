namespace AwesomesauceModpackTools.Mods {
    partial class AddModForm {
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
            this.AddProgressBar = new System.Windows.Forms.ProgressBar();
            this.AddProgressLabel = new System.Windows.Forms.Label();
            this.AddProgressPanel = new System.Windows.Forms.Panel();
            this.AddButton = new System.Windows.Forms.Button();
            this.AddTextBox = new System.Windows.Forms.TextBox();
            this.CancelAddButton = new System.Windows.Forms.Button();
            this.ExampleLabel = new System.Windows.Forms.Label();
            this.AddWithRequirementButton = new System.Windows.Forms.Button();
            this.AddProgressPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddProgressBar
            // 
            this.AddProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddProgressBar.Location = new System.Drawing.Point(1, 18);
            this.AddProgressBar.MarqueeAnimationSpeed = 16;
            this.AddProgressBar.Name = "AddProgressBar";
            this.AddProgressBar.Size = new System.Drawing.Size(440, 23);
            this.AddProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.AddProgressBar.TabIndex = 12;
            // 
            // AddProgressLabel
            // 
            this.AddProgressLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddProgressLabel.Location = new System.Drawing.Point(-2, 2);
            this.AddProgressLabel.Name = "AddProgressLabel";
            this.AddProgressLabel.Size = new System.Drawing.Size(440, 13);
            this.AddProgressLabel.TabIndex = 11;
            this.AddProgressLabel.Text = "Processing link...";
            // 
            // AddProgressPanel
            // 
            this.AddProgressPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddProgressPanel.Controls.Add(this.AddProgressBar);
            this.AddProgressPanel.Controls.Add(this.AddProgressLabel);
            this.AddProgressPanel.Location = new System.Drawing.Point(12, 66);
            this.AddProgressPanel.Name = "AddProgressPanel";
            this.AddProgressPanel.Size = new System.Drawing.Size(442, 43);
            this.AddProgressPanel.TabIndex = 10;
            this.AddProgressPanel.Visible = false;
            // 
            // AddButton
            // 
            this.AddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddButton.Location = new System.Drawing.Point(12, 40);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 2;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // AddTextBox
            // 
            this.AddTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddTextBox.Location = new System.Drawing.Point(12, 12);
            this.AddTextBox.Name = "AddTextBox";
            this.AddTextBox.Size = new System.Drawing.Size(442, 22);
            this.AddTextBox.TabIndex = 1;
            // 
            // CancelAddButton
            // 
            this.CancelAddButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelAddButton.Location = new System.Drawing.Point(379, 40);
            this.CancelAddButton.Name = "CancelAddButton";
            this.CancelAddButton.Size = new System.Drawing.Size(75, 23);
            this.CancelAddButton.TabIndex = 4;
            this.CancelAddButton.Text = "Cancel";
            this.CancelAddButton.UseVisualStyleBackColor = true;
            this.CancelAddButton.Click += new System.EventHandler(this.CancelAddButton_Click);
            // 
            // ExampleLabel
            // 
            this.ExampleLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExampleLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.ExampleLabel.Location = new System.Drawing.Point(29, 80);
            this.ExampleLabel.Name = "ExampleLabel";
            this.ExampleLabel.Size = new System.Drawing.Size(409, 17);
            this.ExampleLabel.TabIndex = 11;
            this.ExampleLabel.Text = "Example:  https://minecraft.curseforge.com/projects/rftools/files/2442685";
            this.ExampleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddWithRequirementButton
            // 
            this.AddWithRequirementButton.Location = new System.Drawing.Point(93, 40);
            this.AddWithRequirementButton.Name = "AddWithRequirementButton";
            this.AddWithRequirementButton.Size = new System.Drawing.Size(150, 23);
            this.AddWithRequirementButton.TabIndex = 3;
            this.AddWithRequirementButton.Text = "Add With Requirements";
            this.AddWithRequirementButton.UseVisualStyleBackColor = true;
            this.AddWithRequirementButton.Click += new System.EventHandler(this.AddWithRequirementButton_Click);
            // 
            // AddModForm
            // 
            this.AcceptButton = this.AddButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 121);
            this.Controls.Add(this.AddWithRequirementButton);
            this.Controls.Add(this.ExampleLabel);
            this.Controls.Add(this.CancelAddButton);
            this.Controls.Add(this.AddTextBox);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.AddProgressPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddModForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add CurseForge Mod";
            this.Load += new System.EventHandler(this.AddModForm_Load);
            this.AddProgressPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar AddProgressBar;
        private System.Windows.Forms.Label AddProgressLabel;
        private System.Windows.Forms.Panel AddProgressPanel;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TextBox AddTextBox;
        private System.Windows.Forms.Button CancelAddButton;
        private System.Windows.Forms.Label ExampleLabel;
        private System.Windows.Forms.Button AddWithRequirementButton;
    }
}