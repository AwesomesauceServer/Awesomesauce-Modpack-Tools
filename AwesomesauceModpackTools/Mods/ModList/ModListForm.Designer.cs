namespace AwesomesauceModpackTools.Mods.ModList {
    partial class ModListForm {
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
            this.ModListView = new System.Windows.Forms.ListView();
            this.NameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FileColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LinkTextBox = new System.Windows.Forms.TextBox();
            this.LinkLabel = new System.Windows.Forms.Label();
            this.UpdatedTextBox = new System.Windows.Forms.TextBox();
            this.UpdatedLabel = new System.Windows.Forms.Label();
            this.SizeTextBox = new System.Windows.Forms.TextBox();
            this.SizeLabel = new System.Windows.Forms.Label();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.RequiresButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.FileMenuStrip = new System.Windows.Forms.MenuStrip();
            this.LoadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MD5Label = new System.Windows.Forms.Label();
            this.MD5TextBox = new System.Windows.Forms.TextBox();
            this.NotesLabel = new System.Windows.Forms.Label();
            this.NotesTextBox = new System.Windows.Forms.TextBox();
            this.LinkLinkLabel = new System.Windows.Forms.LinkLabel();
            this.RequiresLabel = new System.Windows.Forms.Label();
            this.RequiresTextBox = new System.Windows.Forms.TextBox();
            this.EditButton = new System.Windows.Forms.Button();
            this.SaveModListDialog = new System.Windows.Forms.SaveFileDialog();
            this.LoadModListDialog = new System.Windows.Forms.OpenFileDialog();
            this.SortLinkLabel = new System.Windows.Forms.LinkLabel();
            this.KeepSortedCheckBox = new System.Windows.Forms.CheckBox();
            this.SearchLabel = new System.Windows.Forms.Label();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.FileMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainStatusStrip
            // 
            this.MainStatusStrip.Location = new System.Drawing.Point(0, 561);
            this.MainStatusStrip.Name = "MainStatusStrip";
            this.MainStatusStrip.Size = new System.Drawing.Size(762, 22);
            this.MainStatusStrip.TabIndex = 0;
            // 
            // ModListView
            // 
            this.ModListView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ModListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NameColumn,
            this.FileColumn});
            this.ModListView.FullRowSelect = true;
            this.ModListView.HideSelection = false;
            this.ModListView.Location = new System.Drawing.Point(4, 26);
            this.ModListView.MultiSelect = false;
            this.ModListView.Name = "ModListView";
            this.ModListView.Size = new System.Drawing.Size(353, 501);
            this.ModListView.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.ModListView.TabIndex = 1;
            this.ModListView.UseCompatibleStateImageBehavior = false;
            this.ModListView.View = System.Windows.Forms.View.Details;
            this.ModListView.SelectedIndexChanged += new System.EventHandler(this.ModListView_SelectedIndexChanged);
            // 
            // NameColumn
            // 
            this.NameColumn.Text = "Name";
            this.NameColumn.Width = 160;
            // 
            // FileColumn
            // 
            this.FileColumn.Text = "File";
            this.FileColumn.Width = 160;
            // 
            // LinkTextBox
            // 
            this.LinkTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LinkTextBox.Location = new System.Drawing.Point(363, 132);
            this.LinkTextBox.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.LinkTextBox.Name = "LinkTextBox";
            this.LinkTextBox.ReadOnly = true;
            this.LinkTextBox.Size = new System.Drawing.Size(390, 22);
            this.LinkTextBox.TabIndex = 5;
            this.LinkTextBox.TabStop = false;
            // 
            // LinkLabel
            // 
            this.LinkLabel.AutoSize = true;
            this.LinkLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinkLabel.Location = new System.Drawing.Point(360, 116);
            this.LinkLabel.Name = "LinkLabel";
            this.LinkLabel.Size = new System.Drawing.Size(27, 13);
            this.LinkLabel.TabIndex = 4;
            this.LinkLabel.Text = "Link";
            // 
            // UpdatedTextBox
            // 
            this.UpdatedTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UpdatedTextBox.Location = new System.Drawing.Point(363, 87);
            this.UpdatedTextBox.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.UpdatedTextBox.Name = "UpdatedTextBox";
            this.UpdatedTextBox.ReadOnly = true;
            this.UpdatedTextBox.Size = new System.Drawing.Size(166, 22);
            this.UpdatedTextBox.TabIndex = 3;
            this.UpdatedTextBox.TabStop = false;
            // 
            // UpdatedLabel
            // 
            this.UpdatedLabel.AutoSize = true;
            this.UpdatedLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdatedLabel.Location = new System.Drawing.Point(360, 71);
            this.UpdatedLabel.Name = "UpdatedLabel";
            this.UpdatedLabel.Size = new System.Drawing.Size(52, 13);
            this.UpdatedLabel.TabIndex = 2;
            this.UpdatedLabel.Text = "Updated";
            // 
            // SizeTextBox
            // 
            this.SizeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SizeTextBox.Location = new System.Drawing.Point(363, 42);
            this.SizeTextBox.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.SizeTextBox.Name = "SizeTextBox";
            this.SizeTextBox.ReadOnly = true;
            this.SizeTextBox.Size = new System.Drawing.Size(166, 22);
            this.SizeTextBox.TabIndex = 1;
            this.SizeTextBox.TabStop = false;
            // 
            // SizeLabel
            // 
            this.SizeLabel.AutoSize = true;
            this.SizeLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SizeLabel.Location = new System.Drawing.Point(360, 26);
            this.SizeLabel.Name = "SizeLabel";
            this.SizeLabel.Size = new System.Drawing.Size(27, 13);
            this.SizeLabel.TabIndex = 0;
            this.SizeLabel.Text = "Size";
            // 
            // RemoveButton
            // 
            this.RemoveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RemoveButton.Enabled = false;
            this.RemoveButton.Location = new System.Drawing.Point(638, 438);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(115, 23);
            this.RemoveButton.TabIndex = 20;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // RequiresButton
            // 
            this.RequiresButton.Enabled = false;
            this.RequiresButton.Location = new System.Drawing.Point(363, 496);
            this.RequiresButton.Name = "RequiresButton";
            this.RequiresButton.Size = new System.Drawing.Size(115, 23);
            this.RequiresButton.TabIndex = 11;
            this.RequiresButton.Text = "Requires";
            this.RequiresButton.UseVisualStyleBackColor = true;
            this.RequiresButton.Click += new System.EventHandler(this.RequiresButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(363, 438);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(115, 23);
            this.AddButton.TabIndex = 10;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // FileMenuStrip
            // 
            this.FileMenuStrip.BackColor = System.Drawing.SystemColors.Control;
            this.FileMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LoadToolStripMenuItem,
            this.SaveToolStripMenuItem,
            this.SaveAsToolStripMenuItem});
            this.FileMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.FileMenuStrip.Name = "FileMenuStrip";
            this.FileMenuStrip.Size = new System.Drawing.Size(762, 24);
            this.FileMenuStrip.TabIndex = 3;
            // 
            // LoadToolStripMenuItem
            // 
            this.LoadToolStripMenuItem.Name = "LoadToolStripMenuItem";
            this.LoadToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.LoadToolStripMenuItem.Text = "Load";
            this.LoadToolStripMenuItem.Click += new System.EventHandler(this.LoadToolStripMenuItem_Click);
            // 
            // SaveToolStripMenuItem
            // 
            this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            this.SaveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.SaveToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.SaveToolStripMenuItem.Text = "&Save";
            this.SaveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // SaveAsToolStripMenuItem
            // 
            this.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem";
            this.SaveAsToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.SaveAsToolStripMenuItem.Text = "Save As...";
            this.SaveAsToolStripMenuItem.Click += new System.EventHandler(this.SaveAsToolStripMenuItem_Click);
            // 
            // MD5Label
            // 
            this.MD5Label.AutoSize = true;
            this.MD5Label.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MD5Label.Location = new System.Drawing.Point(360, 161);
            this.MD5Label.Name = "MD5Label";
            this.MD5Label.Size = new System.Drawing.Size(31, 13);
            this.MD5Label.TabIndex = 6;
            this.MD5Label.Text = "MD5";
            // 
            // MD5TextBox
            // 
            this.MD5TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MD5TextBox.Location = new System.Drawing.Point(363, 177);
            this.MD5TextBox.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.MD5TextBox.Name = "MD5TextBox";
            this.MD5TextBox.ReadOnly = true;
            this.MD5TextBox.Size = new System.Drawing.Size(219, 22);
            this.MD5TextBox.TabIndex = 7;
            this.MD5TextBox.TabStop = false;
            // 
            // NotesLabel
            // 
            this.NotesLabel.AutoSize = true;
            this.NotesLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NotesLabel.Location = new System.Drawing.Point(360, 251);
            this.NotesLabel.Name = "NotesLabel";
            this.NotesLabel.Size = new System.Drawing.Size(37, 13);
            this.NotesLabel.TabIndex = 8;
            this.NotesLabel.Text = "Notes";
            // 
            // NotesTextBox
            // 
            this.NotesTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NotesTextBox.Location = new System.Drawing.Point(363, 267);
            this.NotesTextBox.Multiline = true;
            this.NotesTextBox.Name = "NotesTextBox";
            this.NotesTextBox.ReadOnly = true;
            this.NotesTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.NotesTextBox.Size = new System.Drawing.Size(390, 165);
            this.NotesTextBox.TabIndex = 9;
            this.NotesTextBox.TabStop = false;
            // 
            // LinkLinkLabel
            // 
            this.LinkLinkLabel.AutoSize = true;
            this.LinkLinkLabel.Enabled = false;
            this.LinkLinkLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinkLinkLabel.Location = new System.Drawing.Point(383, 116);
            this.LinkLinkLabel.Name = "LinkLinkLabel";
            this.LinkLinkLabel.Size = new System.Drawing.Size(89, 13);
            this.LinkLinkLabel.TabIndex = 5;
            this.LinkLinkLabel.TabStop = true;
            this.LinkLinkLabel.Text = "open in browser";
            this.LinkLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLinkLabel_LinkClicked);
            // 
            // RequiresLabel
            // 
            this.RequiresLabel.AutoSize = true;
            this.RequiresLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RequiresLabel.Location = new System.Drawing.Point(360, 206);
            this.RequiresLabel.Name = "RequiresLabel";
            this.RequiresLabel.Size = new System.Drawing.Size(51, 13);
            this.RequiresLabel.TabIndex = 11;
            this.RequiresLabel.Text = "Requires";
            // 
            // RequiresTextBox
            // 
            this.RequiresTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RequiresTextBox.Location = new System.Drawing.Point(363, 222);
            this.RequiresTextBox.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.RequiresTextBox.Name = "RequiresTextBox";
            this.RequiresTextBox.ReadOnly = true;
            this.RequiresTextBox.Size = new System.Drawing.Size(390, 22);
            this.RequiresTextBox.TabIndex = 12;
            this.RequiresTextBox.TabStop = false;
            // 
            // EditButton
            // 
            this.EditButton.Enabled = false;
            this.EditButton.Location = new System.Drawing.Point(363, 467);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(115, 23);
            this.EditButton.TabIndex = 12;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // SaveModListDialog
            // 
            this.SaveModListDialog.DefaultExt = "json";
            this.SaveModListDialog.Filter = "JSON Files|*.json|All Files|*.*";
            this.SaveModListDialog.Title = "Save Mod List";
            // 
            // LoadModListDialog
            // 
            this.LoadModListDialog.Filter = "JSON Files|*.json|All Files|*.*";
            this.LoadModListDialog.Title = "Load Mod List";
            // 
            // SortLinkLabel
            // 
            this.SortLinkLabel.AutoSize = true;
            this.SortLinkLabel.Location = new System.Drawing.Point(259, 6);
            this.SortLinkLabel.Name = "SortLinkLabel";
            this.SortLinkLabel.Size = new System.Drawing.Size(53, 13);
            this.SortLinkLabel.TabIndex = 21;
            this.SortLinkLabel.TabStop = true;
            this.SortLinkLabel.Text = "sort now";
            this.SortLinkLabel.Visible = false;
            this.SortLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SortLinkLabel_LinkClicked);
            // 
            // KeepSortedCheckBox
            // 
            this.KeepSortedCheckBox.AutoSize = true;
            this.KeepSortedCheckBox.Checked = true;
            this.KeepSortedCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.KeepSortedCheckBox.Location = new System.Drawing.Point(172, 5);
            this.KeepSortedCheckBox.Name = "KeepSortedCheckBox";
            this.KeepSortedCheckBox.Size = new System.Drawing.Size(93, 17);
            this.KeepSortedCheckBox.TabIndex = 22;
            this.KeepSortedCheckBox.Text = "Auto-sort list";
            this.KeepSortedCheckBox.UseVisualStyleBackColor = true;
            this.KeepSortedCheckBox.CheckedChanged += new System.EventHandler(this.KeepSortedCheckBox_CheckedChanged);
            // 
            // SearchLabel
            // 
            this.SearchLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SearchLabel.AutoSize = true;
            this.SearchLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchLabel.Location = new System.Drawing.Point(3, 538);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(43, 13);
            this.SearchLabel.TabIndex = 24;
            this.SearchLabel.Text = "Search:";
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SearchTextBox.Location = new System.Drawing.Point(50, 533);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(307, 22);
            this.SearchTextBox.TabIndex = 13;
            this.SearchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
            // 
            // ModListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 583);
            this.Controls.Add(this.SearchLabel);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.SortLinkLabel);
            this.Controls.Add(this.KeepSortedCheckBox);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.RequiresTextBox);
            this.Controls.Add(this.RequiresLabel);
            this.Controls.Add(this.LinkTextBox);
            this.Controls.Add(this.LinkLinkLabel);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.NotesTextBox);
            this.Controls.Add(this.RequiresButton);
            this.Controls.Add(this.NotesLabel);
            this.Controls.Add(this.MainStatusStrip);
            this.Controls.Add(this.MD5TextBox);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.MD5Label);
            this.Controls.Add(this.FileMenuStrip);
            this.Controls.Add(this.LinkLabel);
            this.Controls.Add(this.ModListView);
            this.Controls.Add(this.UpdatedTextBox);
            this.Controls.Add(this.SizeTextBox);
            this.Controls.Add(this.UpdatedLabel);
            this.Controls.Add(this.SizeLabel);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(778, 622);
            this.Name = "ModListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Mods";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ManageForm_FormClosing);
            this.Load += new System.EventHandler(this.ManageForm_Load);
            this.FileMenuStrip.ResumeLayout(false);
            this.FileMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip MainStatusStrip;
        private System.Windows.Forms.ListView ModListView;
        private System.Windows.Forms.ColumnHeader NameColumn;
        private System.Windows.Forms.ColumnHeader FileColumn;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button RequiresButton;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.MenuStrip FileMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem LoadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveToolStripMenuItem;
        private System.Windows.Forms.TextBox LinkTextBox;
        private System.Windows.Forms.Label LinkLabel;
        private System.Windows.Forms.TextBox UpdatedTextBox;
        private System.Windows.Forms.Label UpdatedLabel;
        private System.Windows.Forms.TextBox SizeTextBox;
        private System.Windows.Forms.Label SizeLabel;
        private System.Windows.Forms.TextBox MD5TextBox;
        private System.Windows.Forms.Label MD5Label;
        private System.Windows.Forms.TextBox NotesTextBox;
        private System.Windows.Forms.Label NotesLabel;
        private System.Windows.Forms.LinkLabel LinkLinkLabel;
        private System.Windows.Forms.Label RequiresLabel;
        private System.Windows.Forms.TextBox RequiresTextBox;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.SaveFileDialog SaveModListDialog;
        private System.Windows.Forms.ToolStripMenuItem SaveAsToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog LoadModListDialog;
        private System.Windows.Forms.LinkLabel SortLinkLabel;
        private System.Windows.Forms.CheckBox KeepSortedCheckBox;
        private System.Windows.Forms.Label SearchLabel;
        private System.Windows.Forms.TextBox SearchTextBox;
    }
}

