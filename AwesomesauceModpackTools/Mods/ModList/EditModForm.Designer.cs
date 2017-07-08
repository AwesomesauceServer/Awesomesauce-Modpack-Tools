namespace AwesomesauceModpackTools.Mods.ModList {
    partial class EditModForm {
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
            this.StatusStripMain = new System.Windows.Forms.StatusStrip();
            this.StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.NotesTextBox = new System.Windows.Forms.TextBox();
            this.NotesLabel = new System.Windows.Forms.Label();
            this.SideComboBox = new System.Windows.Forms.ComboBox();
            this.UpdateModeComboBox = new System.Windows.Forms.ComboBox();
            this.SideLabel = new System.Windows.Forms.Label();
            this.UpdateModeLabel = new System.Windows.Forms.Label();
            this.StatusStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // StatusStripMain
            // 
            this.StatusStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabel});
            this.StatusStripMain.Location = new System.Drawing.Point(0, 285);
            this.StatusStripMain.Name = "StatusStripMain";
            this.StatusStripMain.Size = new System.Drawing.Size(427, 22);
            this.StatusStripMain.SizingGrip = false;
            this.StatusStripMain.TabIndex = 4;
            this.StatusStripMain.Text = "statusStrip1";
            // 
            // StatusLabel
            // 
            this.StatusLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(197, 17);
            this.StatusLabel.Text = "Close the window to apply changes.";
            // 
            // NotesTextBox
            // 
            this.NotesTextBox.Location = new System.Drawing.Point(13, 110);
            this.NotesTextBox.Multiline = true;
            this.NotesTextBox.Name = "NotesTextBox";
            this.NotesTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.NotesTextBox.Size = new System.Drawing.Size(399, 159);
            this.NotesTextBox.TabIndex = 10;
            this.NotesTextBox.WordWrap = false;
            // 
            // NotesLabel
            // 
            this.NotesLabel.AutoSize = true;
            this.NotesLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NotesLabel.Location = new System.Drawing.Point(10, 94);
            this.NotesLabel.Name = "NotesLabel";
            this.NotesLabel.Size = new System.Drawing.Size(37, 13);
            this.NotesLabel.TabIndex = 6;
            this.NotesLabel.Text = "Notes";
            // 
            // SideComboBox
            // 
            this.SideComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SideComboBox.FormattingEnabled = true;
            this.SideComboBox.Location = new System.Drawing.Point(13, 22);
            this.SideComboBox.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.SideComboBox.Name = "SideComboBox";
            this.SideComboBox.Size = new System.Drawing.Size(169, 21);
            this.SideComboBox.TabIndex = 1;
            // 
            // UpdateModeComboBox
            // 
            this.UpdateModeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UpdateModeComboBox.FormattingEnabled = true;
            this.UpdateModeComboBox.Location = new System.Drawing.Point(13, 66);
            this.UpdateModeComboBox.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.UpdateModeComboBox.Name = "UpdateModeComboBox";
            this.UpdateModeComboBox.Size = new System.Drawing.Size(169, 21);
            this.UpdateModeComboBox.TabIndex = 2;
            // 
            // SideLabel
            // 
            this.SideLabel.AutoSize = true;
            this.SideLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SideLabel.Location = new System.Drawing.Point(10, 6);
            this.SideLabel.Name = "SideLabel";
            this.SideLabel.Size = new System.Drawing.Size(29, 13);
            this.SideLabel.TabIndex = 9;
            this.SideLabel.Text = "Side";
            // 
            // UpdateModeLabel
            // 
            this.UpdateModeLabel.AutoSize = true;
            this.UpdateModeLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateModeLabel.Location = new System.Drawing.Point(10, 50);
            this.UpdateModeLabel.Name = "UpdateModeLabel";
            this.UpdateModeLabel.Size = new System.Drawing.Size(78, 13);
            this.UpdateModeLabel.TabIndex = 10;
            this.UpdateModeLabel.Text = "Update Mode";
            // 
            // EditModForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 307);
            this.Controls.Add(this.UpdateModeLabel);
            this.Controls.Add(this.SideLabel);
            this.Controls.Add(this.UpdateModeComboBox);
            this.Controls.Add(this.SideComboBox);
            this.Controls.Add(this.NotesLabel);
            this.Controls.Add(this.NotesTextBox);
            this.Controls.Add(this.StatusStripMain);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditModForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit Mod";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NoteForm_FormClosing);
            this.Load += new System.EventHandler(this.NoteForm_Load);
            this.StatusStripMain.ResumeLayout(false);
            this.StatusStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip StatusStripMain;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel;
        private System.Windows.Forms.Label NotesLabel;
        private System.Windows.Forms.TextBox NotesTextBox;
        private System.Windows.Forms.ComboBox SideComboBox;
        private System.Windows.Forms.ComboBox UpdateModeComboBox;
        private System.Windows.Forms.Label SideLabel;
        private System.Windows.Forms.Label UpdateModeLabel;
    }
}