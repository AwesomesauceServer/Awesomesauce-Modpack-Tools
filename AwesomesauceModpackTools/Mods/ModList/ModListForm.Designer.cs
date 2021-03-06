﻿namespace AwesomesauceModpackTools.Mods.ModList {
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
            this.ExportAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExportAsHTMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExportAsXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.ExportAsDialog = new System.Windows.Forms.SaveFileDialog();
            this.SearchPictureBox = new System.Windows.Forms.PictureBox();
            this.SideTextBox = new System.Windows.Forms.TextBox();
            this.UpdateModeTextBox = new System.Windows.Forms.TextBox();
            this.SideLabel = new System.Windows.Forms.Label();
            this.UpdateModeLabel = new System.Windows.Forms.Label();
            this.MinecraftVersionLabel = new System.Windows.Forms.Label();
            this.MinecraftVersionTextbox = new System.Windows.Forms.TextBox();
            this.ChangelogCompilerButton = new System.Windows.Forms.Button();
            this.FileMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SearchPictureBox)).BeginInit();
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
            this.LinkTextBox.TabIndex = 14;
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
            this.UpdatedTextBox.Location = new System.Drawing.Point(363, 42);
            this.UpdatedTextBox.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.UpdatedTextBox.Name = "UpdatedTextBox";
            this.UpdatedTextBox.ReadOnly = true;
            this.UpdatedTextBox.Size = new System.Drawing.Size(166, 22);
            this.UpdatedTextBox.TabIndex = 10;
            this.UpdatedTextBox.TabStop = false;
            // 
            // UpdatedLabel
            // 
            this.UpdatedLabel.AutoSize = true;
            this.UpdatedLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdatedLabel.Location = new System.Drawing.Point(360, 26);
            this.UpdatedLabel.Name = "UpdatedLabel";
            this.UpdatedLabel.Size = new System.Drawing.Size(52, 13);
            this.UpdatedLabel.TabIndex = 2;
            this.UpdatedLabel.Text = "Updated";
            // 
            // SizeTextBox
            // 
            this.SizeTextBox.Location = new System.Drawing.Point(363, 87);
            this.SizeTextBox.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.SizeTextBox.Name = "SizeTextBox";
            this.SizeTextBox.ReadOnly = true;
            this.SizeTextBox.Size = new System.Drawing.Size(166, 22);
            this.SizeTextBox.TabIndex = 12;
            this.SizeTextBox.TabStop = false;
            // 
            // SizeLabel
            // 
            this.SizeLabel.AutoSize = true;
            this.SizeLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SizeLabel.Location = new System.Drawing.Point(360, 71);
            this.SizeLabel.Name = "SizeLabel";
            this.SizeLabel.Size = new System.Drawing.Size(27, 13);
            this.SizeLabel.TabIndex = 0;
            this.SizeLabel.Text = "Size";
            // 
            // RemoveButton
            // 
            this.RemoveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RemoveButton.Enabled = false;
            this.RemoveButton.Image = global::AwesomesauceModpackTools.Properties.Resources.Remove;
            this.RemoveButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RemoveButton.Location = new System.Drawing.Point(653, 446);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(100, 23);
            this.RemoveButton.TabIndex = 9;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // RequiresButton
            // 
            this.RequiresButton.Enabled = false;
            this.RequiresButton.Image = global::AwesomesauceModpackTools.Properties.Resources.DependencyGraph;
            this.RequiresButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RequiresButton.Location = new System.Drawing.Point(363, 504);
            this.RequiresButton.Name = "RequiresButton";
            this.RequiresButton.Size = new System.Drawing.Size(100, 23);
            this.RequiresButton.TabIndex = 7;
            this.RequiresButton.Text = "Requires";
            this.RequiresButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RequiresButton.UseVisualStyleBackColor = true;
            this.RequiresButton.Click += new System.EventHandler(this.RequiresButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Image = global::AwesomesauceModpackTools.Properties.Resources.Add;
            this.AddButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddButton.Location = new System.Drawing.Point(363, 446);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(100, 23);
            this.AddButton.TabIndex = 5;
            this.AddButton.Text = "Add";
            this.AddButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // FileMenuStrip
            // 
            this.FileMenuStrip.BackColor = System.Drawing.SystemColors.Control;
            this.FileMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LoadToolStripMenuItem,
            this.SaveToolStripMenuItem,
            this.SaveAsToolStripMenuItem,
            this.ExportAsToolStripMenuItem});
            this.FileMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.FileMenuStrip.Name = "FileMenuStrip";
            this.FileMenuStrip.Size = new System.Drawing.Size(762, 24);
            this.FileMenuStrip.TabIndex = 3;
            // 
            // LoadToolStripMenuItem
            // 
            this.LoadToolStripMenuItem.Image = global::AwesomesauceModpackTools.Properties.Resources.Open;
            this.LoadToolStripMenuItem.Name = "LoadToolStripMenuItem";
            this.LoadToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.LoadToolStripMenuItem.Text = "Load";
            this.LoadToolStripMenuItem.Click += new System.EventHandler(this.LoadToolStripMenuItem_Click);
            // 
            // SaveToolStripMenuItem
            // 
            this.SaveToolStripMenuItem.Image = global::AwesomesauceModpackTools.Properties.Resources.Save;
            this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            this.SaveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.SaveToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.SaveToolStripMenuItem.Text = "&Save";
            this.SaveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // SaveAsToolStripMenuItem
            // 
            this.SaveAsToolStripMenuItem.Image = global::AwesomesauceModpackTools.Properties.Resources.SaveAs;
            this.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem";
            this.SaveAsToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.SaveAsToolStripMenuItem.Text = "Save As...";
            this.SaveAsToolStripMenuItem.Click += new System.EventHandler(this.SaveAsToolStripMenuItem_Click);
            // 
            // ExportAsToolStripMenuItem
            // 
            this.ExportAsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExportAsHTMLToolStripMenuItem,
            this.ExportAsXMLToolStripMenuItem});
            this.ExportAsToolStripMenuItem.Name = "ExportAsToolStripMenuItem";
            this.ExportAsToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.ExportAsToolStripMenuItem.Text = "Export As";
            // 
            // ExportAsHTMLToolStripMenuItem
            // 
            this.ExportAsHTMLToolStripMenuItem.Image = global::AwesomesauceModpackTools.Properties.Resources.HTMLFile;
            this.ExportAsHTMLToolStripMenuItem.Name = "ExportAsHTMLToolStripMenuItem";
            this.ExportAsHTMLToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.ExportAsHTMLToolStripMenuItem.Text = "HTML";
            this.ExportAsHTMLToolStripMenuItem.Click += new System.EventHandler(this.ExportAsHTMLToolStripMenuItem_Click);
            // 
            // ExportAsXMLToolStripMenuItem
            // 
            this.ExportAsXMLToolStripMenuItem.Image = global::AwesomesauceModpackTools.Properties.Resources.XMLFile;
            this.ExportAsXMLToolStripMenuItem.Name = "ExportAsXMLToolStripMenuItem";
            this.ExportAsXMLToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.ExportAsXMLToolStripMenuItem.Text = "XML";
            this.ExportAsXMLToolStripMenuItem.Click += new System.EventHandler(this.ExportAsXMLToolStripMenuItem_Click);
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
            this.MD5TextBox.TabIndex = 15;
            this.MD5TextBox.TabStop = false;
            // 
            // NotesLabel
            // 
            this.NotesLabel.AutoSize = true;
            this.NotesLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NotesLabel.Location = new System.Drawing.Point(360, 296);
            this.NotesLabel.Name = "NotesLabel";
            this.NotesLabel.Size = new System.Drawing.Size(37, 13);
            this.NotesLabel.TabIndex = 8;
            this.NotesLabel.Text = "Notes";
            // 
            // NotesTextBox
            // 
            this.NotesTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NotesTextBox.Location = new System.Drawing.Point(363, 312);
            this.NotesTextBox.Multiline = true;
            this.NotesTextBox.Name = "NotesTextBox";
            this.NotesTextBox.ReadOnly = true;
            this.NotesTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.NotesTextBox.Size = new System.Drawing.Size(390, 128);
            this.NotesTextBox.TabIndex = 18;
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
            this.LinkLinkLabel.TabIndex = 14;
            this.LinkLinkLabel.TabStop = true;
            this.LinkLinkLabel.Text = "open in browser";
            this.LinkLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLinkLabel_LinkClicked);
            // 
            // RequiresLabel
            // 
            this.RequiresLabel.AutoSize = true;
            this.RequiresLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RequiresLabel.Location = new System.Drawing.Point(360, 251);
            this.RequiresLabel.Name = "RequiresLabel";
            this.RequiresLabel.Size = new System.Drawing.Size(51, 13);
            this.RequiresLabel.TabIndex = 11;
            this.RequiresLabel.Text = "Requires";
            // 
            // RequiresTextBox
            // 
            this.RequiresTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RequiresTextBox.Location = new System.Drawing.Point(363, 267);
            this.RequiresTextBox.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.RequiresTextBox.Name = "RequiresTextBox";
            this.RequiresTextBox.ReadOnly = true;
            this.RequiresTextBox.Size = new System.Drawing.Size(390, 22);
            this.RequiresTextBox.TabIndex = 17;
            this.RequiresTextBox.TabStop = false;
            // 
            // EditButton
            // 
            this.EditButton.Enabled = false;
            this.EditButton.Image = global::AwesomesauceModpackTools.Properties.Resources.Edit;
            this.EditButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EditButton.Location = new System.Drawing.Point(363, 475);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(100, 23);
            this.EditButton.TabIndex = 6;
            this.EditButton.Text = "Edit";
            this.EditButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.SortLinkLabel.Location = new System.Drawing.Point(377, 6);
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
            this.KeepSortedCheckBox.Location = new System.Drawing.Point(290, 5);
            this.KeepSortedCheckBox.Name = "KeepSortedCheckBox";
            this.KeepSortedCheckBox.Size = new System.Drawing.Size(93, 17);
            this.KeepSortedCheckBox.TabIndex = 22;
            this.KeepSortedCheckBox.Text = "Auto-sort list";
            this.KeepSortedCheckBox.UseVisualStyleBackColor = true;
            this.KeepSortedCheckBox.CheckedChanged += new System.EventHandler(this.KeepSortedCheckBox_CheckedChanged);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SearchTextBox.Location = new System.Drawing.Point(24, 533);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(333, 22);
            this.SearchTextBox.TabIndex = 2;
            this.SearchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
            this.SearchTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchTextBox_KeyDown);
            // 
            // ExportAsDialog
            // 
            this.ExportAsDialog.Title = "Export mod list";
            // 
            // SearchPictureBox
            // 
            this.SearchPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SearchPictureBox.ErrorImage = null;
            this.SearchPictureBox.Image = global::AwesomesauceModpackTools.Properties.Resources.Search;
            this.SearchPictureBox.InitialImage = null;
            this.SearchPictureBox.Location = new System.Drawing.Point(5, 536);
            this.SearchPictureBox.Name = "SearchPictureBox";
            this.SearchPictureBox.Size = new System.Drawing.Size(16, 16);
            this.SearchPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.SearchPictureBox.TabIndex = 25;
            this.SearchPictureBox.TabStop = false;
            // 
            // SideTextBox
            // 
            this.SideTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SideTextBox.Location = new System.Drawing.Point(587, 87);
            this.SideTextBox.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.SideTextBox.Name = "SideTextBox";
            this.SideTextBox.ReadOnly = true;
            this.SideTextBox.Size = new System.Drawing.Size(166, 22);
            this.SideTextBox.TabIndex = 13;
            this.SideTextBox.TabStop = false;
            // 
            // UpdateModeTextBox
            // 
            this.UpdateModeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UpdateModeTextBox.Location = new System.Drawing.Point(587, 42);
            this.UpdateModeTextBox.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.UpdateModeTextBox.Name = "UpdateModeTextBox";
            this.UpdateModeTextBox.ReadOnly = true;
            this.UpdateModeTextBox.Size = new System.Drawing.Size(166, 22);
            this.UpdateModeTextBox.TabIndex = 11;
            this.UpdateModeTextBox.TabStop = false;
            // 
            // SideLabel
            // 
            this.SideLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SideLabel.AutoSize = true;
            this.SideLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SideLabel.Location = new System.Drawing.Point(584, 71);
            this.SideLabel.Name = "SideLabel";
            this.SideLabel.Size = new System.Drawing.Size(29, 13);
            this.SideLabel.TabIndex = 0;
            this.SideLabel.Text = "Side";
            // 
            // UpdateModeLabel
            // 
            this.UpdateModeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UpdateModeLabel.AutoSize = true;
            this.UpdateModeLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateModeLabel.Location = new System.Drawing.Point(584, 26);
            this.UpdateModeLabel.Name = "UpdateModeLabel";
            this.UpdateModeLabel.Size = new System.Drawing.Size(78, 13);
            this.UpdateModeLabel.TabIndex = 0;
            this.UpdateModeLabel.Text = "Update Mode";
            // 
            // MinecraftVersionLabel
            // 
            this.MinecraftVersionLabel.AutoSize = true;
            this.MinecraftVersionLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinecraftVersionLabel.Location = new System.Drawing.Point(360, 206);
            this.MinecraftVersionLabel.Name = "MinecraftVersionLabel";
            this.MinecraftVersionLabel.Size = new System.Drawing.Size(165, 13);
            this.MinecraftVersionLabel.TabIndex = 11;
            this.MinecraftVersionLabel.Text = "Supported Minecraft Version(s)";
            // 
            // MinecraftVersionTextbox
            // 
            this.MinecraftVersionTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MinecraftVersionTextbox.Location = new System.Drawing.Point(363, 222);
            this.MinecraftVersionTextbox.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.MinecraftVersionTextbox.Name = "MinecraftVersionTextbox";
            this.MinecraftVersionTextbox.ReadOnly = true;
            this.MinecraftVersionTextbox.Size = new System.Drawing.Size(390, 22);
            this.MinecraftVersionTextbox.TabIndex = 16;
            this.MinecraftVersionTextbox.TabStop = false;
            // 
            // ChangelogCompilerButton
            // 
            this.ChangelogCompilerButton.Enabled = false;
            this.ChangelogCompilerButton.Image = global::AwesomesauceModpackTools.Properties.Resources.Code;
            this.ChangelogCompilerButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ChangelogCompilerButton.Location = new System.Drawing.Point(469, 475);
            this.ChangelogCompilerButton.Name = "ChangelogCompilerButton";
            this.ChangelogCompilerButton.Size = new System.Drawing.Size(100, 52);
            this.ChangelogCompilerButton.TabIndex = 8;
            this.ChangelogCompilerButton.Text = "View\r\nChangelog";
            this.ChangelogCompilerButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ChangelogCompilerButton.UseVisualStyleBackColor = true;
            this.ChangelogCompilerButton.Click += new System.EventHandler(this.ChangelogCompilerButton_Click);
            // 
            // ModListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 583);
            this.Controls.Add(this.ChangelogCompilerButton);
            this.Controls.Add(this.SearchPictureBox);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.SortLinkLabel);
            this.Controls.Add(this.KeepSortedCheckBox);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.MinecraftVersionTextbox);
            this.Controls.Add(this.MinecraftVersionLabel);
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
            this.Controls.Add(this.UpdateModeTextBox);
            this.Controls.Add(this.SideTextBox);
            this.Controls.Add(this.SizeTextBox);
            this.Controls.Add(this.UpdatedLabel);
            this.Controls.Add(this.UpdateModeLabel);
            this.Controls.Add(this.SideLabel);
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
            ((System.ComponentModel.ISupportInitialize)(this.SearchPictureBox)).EndInit();
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
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.ToolStripMenuItem ExportAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExportAsHTMLToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog ExportAsDialog;
        private System.Windows.Forms.PictureBox SearchPictureBox;
        private System.Windows.Forms.ToolStripMenuItem ExportAsXMLToolStripMenuItem;
        private System.Windows.Forms.TextBox SideTextBox;
        private System.Windows.Forms.TextBox UpdateModeTextBox;
        private System.Windows.Forms.Label SideLabel;
        private System.Windows.Forms.Label UpdateModeLabel;
        private System.Windows.Forms.Label MinecraftVersionLabel;
        private System.Windows.Forms.TextBox MinecraftVersionTextbox;
        private System.Windows.Forms.Button ChangelogCompilerButton;
    }
}

