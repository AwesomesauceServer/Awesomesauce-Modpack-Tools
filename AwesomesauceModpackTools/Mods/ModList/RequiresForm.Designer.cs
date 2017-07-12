namespace AwesomesauceModpackTools.Mods.ModList {
    partial class RequiresForm {
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
            this.ModListView = new System.Windows.Forms.ListView();
            this.NameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FileColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StatusStripMain = new System.Windows.Forms.StatusStrip();
            this.StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.UncheckAllButton = new System.Windows.Forms.Button();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.SearchPictureBox = new System.Windows.Forms.PictureBox();
            this.StatusStripMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SearchPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ModListView
            // 
            this.ModListView.CheckBoxes = true;
            this.ModListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NameColumn,
            this.FileColumn});
            this.ModListView.FullRowSelect = true;
            this.ModListView.HideSelection = false;
            this.ModListView.Location = new System.Drawing.Point(3, 3);
            this.ModListView.MultiSelect = false;
            this.ModListView.Name = "ModListView";
            this.ModListView.Size = new System.Drawing.Size(412, 375);
            this.ModListView.TabIndex = 2;
            this.ModListView.UseCompatibleStateImageBehavior = false;
            this.ModListView.View = System.Windows.Forms.View.Details;
            this.ModListView.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.ModsListView_ItemChecked);
            this.ModListView.SelectedIndexChanged += new System.EventHandler(this.ModsListView_SelectedIndexChanged);
            // 
            // NameColumn
            // 
            this.NameColumn.Text = "Name";
            this.NameColumn.Width = 200;
            // 
            // FileColumn
            // 
            this.FileColumn.Text = "File";
            this.FileColumn.Width = 185;
            // 
            // StatusStripMain
            // 
            this.StatusStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabel});
            this.StatusStripMain.Location = new System.Drawing.Point(0, 412);
            this.StatusStripMain.Name = "StatusStripMain";
            this.StatusStripMain.Size = new System.Drawing.Size(418, 22);
            this.StatusStripMain.SizingGrip = false;
            this.StatusStripMain.TabIndex = 3;
            this.StatusStripMain.Text = "statusStrip1";
            // 
            // StatusLabel
            // 
            this.StatusLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(393, 17);
            this.StatusLabel.Text = "Close the window to apply changes, uncheck all to remove requirements.";
            // 
            // UncheckAllButton
            // 
            this.UncheckAllButton.Image = global::AwesomesauceModpackTools.Properties.Resources.CheckboxDisable;
            this.UncheckAllButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UncheckAllButton.Location = new System.Drawing.Point(2, 384);
            this.UncheckAllButton.Name = "UncheckAllButton";
            this.UncheckAllButton.Size = new System.Drawing.Size(99, 23);
            this.UncheckAllButton.TabIndex = 3;
            this.UncheckAllButton.Text = "Uncheck All";
            this.UncheckAllButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.UncheckAllButton.UseVisualStyleBackColor = true;
            this.UncheckAllButton.Click += new System.EventHandler(this.UncheckAllButton_Click);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(200, 385);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(215, 22);
            this.SearchTextBox.TabIndex = 1;
            this.SearchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
            // 
            // SearchPictureBox
            // 
            this.SearchPictureBox.ErrorImage = null;
            this.SearchPictureBox.Image = global::AwesomesauceModpackTools.Properties.Resources.Search;
            this.SearchPictureBox.InitialImage = null;
            this.SearchPictureBox.Location = new System.Drawing.Point(181, 388);
            this.SearchPictureBox.Name = "SearchPictureBox";
            this.SearchPictureBox.Size = new System.Drawing.Size(16, 16);
            this.SearchPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.SearchPictureBox.TabIndex = 4;
            this.SearchPictureBox.TabStop = false;
            // 
            // RequiresForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 434);
            this.Controls.Add(this.SearchPictureBox);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.UncheckAllButton);
            this.Controls.Add(this.ModListView);
            this.Controls.Add(this.StatusStripMain);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RequiresForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit Requirements";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddRequirementForm_FormClosing);
            this.Load += new System.EventHandler(this.AddRequirementForm_Load);
            this.StatusStripMain.ResumeLayout(false);
            this.StatusStripMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SearchPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ColumnHeader NameColumn;
        private System.Windows.Forms.ColumnHeader FileColumn;
        private System.Windows.Forms.StatusStrip StatusStripMain;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel;
        private System.Windows.Forms.Button UncheckAllButton;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.ListView ModListView;
        private System.Windows.Forms.PictureBox SearchPictureBox;
    }
}