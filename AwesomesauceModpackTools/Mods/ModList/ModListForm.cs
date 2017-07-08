using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;
using static AwesomesauceModpackTools.Utilities;

namespace AwesomesauceModpackTools.Mods.ModList {

    public partial class ModListForm : Form {

        private string WorkingSaveFile = null;
        private ListViewItem CurrentlySelectedItem = null;

        public ModListForm() {
            InitializeComponent();
            Icon = Properties.Resources.AwesomesauceIcon;
        }

        private void ManageForm_Load(object sender, EventArgs e) {

        }

        private void ManageForm_FormClosing(object sender, FormClosingEventArgs e) {
            if (MessageBox.Show("Really exit?\r\n\r\nMake sure you saved!", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No) {
                e.Cancel = true;
                return;
            }
            Dispose();
        }

        private void AddButton_Click(object sender, EventArgs e) {
            AddModForm addModForm = new AddModForm();

            DialogResult addModForm_Result = addModForm.ShowDialog();
            if (addModForm_Result == DialogResult.OK) {
                IEnumerable<ListViewItem> queryResult = ModListView.Items.Cast<ListViewItem>().Where(i => i.Text.ToLower() == addModForm.NewMod.Name.ToLower());
                if (queryResult.Any() == false) {
                    ModListView.Items.Add(new ListViewItem(new string[] { addModForm.NewMod.Name, addModForm.NewMod.File })).Tag = addModForm.NewMod;

                    if (addModForm.AddWithRequirement == true) {
                        IEnumerable<ListViewItem> addResult = ModListView.Items.Cast<ListViewItem>().Where(i => i.Text.ToLower() == addModForm.NewMod.Name.ToLower());
                        if (addResult.Any() == true) {
                            ModListView.TopItem = addResult.FirstOrDefault();
                            addResult.FirstOrDefault().Selected = true;

                            RequirementButton_Click(null, new EventArgs());
                        }
                    }
                } else {
                    MessageBox.Show($"The mod {addModForm.NewMod.Name} already exists in the mod list.\r\n\r\nIt is a bad idea to have duplicates in the list.\r\nIf you want to override this add it manually to the JSON.", "Mod Already Exists", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            } else if (addModForm_Result == DialogResult.Abort) {
                MessageBox.Show($"There was an error adding the mod to the list.\r\n\r\n{addModForm.AbortError}", "Error Adding Mod", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            addModForm.Dispose();
            BackupModList();
        }

        private void EditButton_Click(object sender, EventArgs e) {
            EditModForm editModForm = new EditModForm() { EditedMod = (Mod)CurrentlySelectedItem.Tag };

            DialogResult editModForm_Result = editModForm.ShowDialog();
            if (editModForm_Result == DialogResult.OK) {

            }

            editModForm.Dispose();
            BackupModList();
            ModListView_SelectedIndexChanged(sender, new EventArgs());
        }

        private void RequirementButton_Click(object sender, EventArgs e) {
            RequiresForm addRequiresForm = new RequiresForm();
            addRequiresForm.ListItems.AddRange((from ListViewItem item in ModListView.Items select (ListViewItem)item.Clone()).ToArray());
            addRequiresForm.SelectedMod = (Mod)CurrentlySelectedItem.Tag;

            DialogResult addRequirementForm_Result = addRequiresForm.ShowDialog();
            if (addRequirementForm_Result == DialogResult.OK) {
                Mod currentlySelectedItemMod = (Mod)CurrentlySelectedItem.Tag;
                currentlySelectedItemMod.Requires.Clear();

                foreach (Mod mod in addRequiresForm.CheckedMods) {
                    RequiredMod requiredMod = new RequiredMod() { ID = mod.ID, Name = mod.Name };
                    currentlySelectedItemMod.Requires.Add(requiredMod);
                }
            }

            addRequiresForm.Dispose();
            BackupModList();
            ModListView_SelectedIndexChanged(sender, new EventArgs());
        }

        private void RemoveButton_Click(object sender, EventArgs e) {
            if (CurrentlySelectedItem != null) {
                if (MessageBox.Show($"Really remove the mod {CurrentlySelectedItem.Text}?", "Confirm Remove", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes) {
                    ModListView.Items.Remove(CurrentlySelectedItem);
                    ModListView_SelectedIndexChanged(sender, new EventArgs());
                }
            }
        }

        private void ModListView_SelectedIndexChanged(object sender, EventArgs e) {
            if (ModListView.SelectedItems.Count == 1) { IsItemSelected(true, ModListView.SelectedItems[0]); } else { IsItemSelected(false); }
        }

        private void KeepSortedCheckBox_CheckedChanged(object sender, EventArgs e) {
            if (KeepSortedCheckBox.Checked == true) {
                SortLinkLabel.Visible = false;
                ModListView.Sorting = SortOrder.Ascending;
                ModListView.Sort();
            } else {
                SortLinkLabel.Visible = true;
                ModListView.Sorting = SortOrder.None;
            }
        }

        private void SortLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            if (MessageBox.Show("Sort mod list?", "Confirm Sort", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes) {
                ModListView.Sorting = SortOrder.Ascending;
                ModListView.Sort();
                ModListView.Sorting = SortOrder.None;
            }
        }

        private void LinkLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            try { Process.Start(LinkTextBox.Text); } catch { }
        }

        private void LoadToolStripMenuItem_Click(object sender, EventArgs e) {
            if (ModListView.Items.Count != 0) {
                DialogResult overwrite = MessageBox.Show("The mod list is not empty, are you sure you want to overwrite the current list?", "Confirm Overwrite", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (overwrite == DialogResult.No) { return; }
            }

            if (LoadModListDialog.ShowDialog() == DialogResult.OK) {
                ModListView.Items.Clear();
                LoadModList(LoadModListDialog.FileName);
            }
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e) {
            if (WorkingSaveFile == null) { SaveAsToolStripMenuItem_Click(sender, new EventArgs()); } else { SaveModList(WorkingSaveFile); }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e) {
            if (SaveModListDialog.ShowDialog() == DialogResult.OK) { SaveModList(SaveModListDialog.FileName); }
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e) {
            if (ModListView.SelectedItems.Count == 0) { return; }

            if (SearchTextBox.Text.Trim() == "") {
                ModListView.SelectedItems.Clear();
                return;
            }

            ListViewItem foundItem = ModListView.FindItemWithText(SearchTextBox.Text, true, 0, true);
            if (foundItem != null) {
                ModListView.TopItem = foundItem;
                foundItem.Selected = true;
            } else {
                ModListView.SelectedItems.Clear();
            }
        }

        private void LoadModList(string file) {
            try {
                List<Mod> loadedMods = JsonConvert.DeserializeObject<List<Mod>>(File.ReadAllText(file, Encoding.UTF8));

                foreach (Mod mod in loadedMods) { ModListView.Items.Add(new ListViewItem(new string[] { mod.Name, mod.File })).Tag = mod; }

                WorkingSaveFile = file;
            } catch (Exception ex) {
                MessageBox.Show($"There was an error loading the mod list.\r\n\r\nType: {ex.GetType().Name}\r\n\r\n{ex.Message}", "Error Loading Mod List", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveModList(string file, bool automatic = false) {
            try {
                List<Mod> modList = new List<Mod>();
                foreach (ListViewItem item in ModListView.Items) { modList.Add((Mod)item.Tag); }

                JsonSerializerSettings jsonSettings = new JsonSerializerSettings() { Formatting = Formatting.Indented };

                if (automatic == false) {
                    WorkingSaveFile = file;
                    File.WriteAllText(file, JsonConvert.SerializeObject(modList, jsonSettings), Encoding.UTF8);
                } else {
                    // If the backup file is over 20 MB, trim it starting with line 1, newest entries (very bottom lines) are kept.
                    if (File.Exists(file)) {
                        long length = new FileInfo(file).Length;
                        long size = (20 * 1024 * 1024);

                        if (length > size) {
                            using (MemoryStream memoryStream = new MemoryStream((int)size)) {
                                using (FileStream fileStream = new FileStream(file, FileMode.Open, FileAccess.ReadWrite)) {
                                    fileStream.Seek(-size, SeekOrigin.End);
                                    fileStream.CopyTo(memoryStream);
                                    fileStream.SetLength(size);
                                    fileStream.Position = 0;
                                    fileStream.Write(memoryStream.GetBuffer(), 0, (int)size);
                                }
                            }
                        }
                    }

                    string shortLine = "========================================";
                    string longLine = "========================================================================";
                    string working = $"== {DateTime.UtcNow.ToString("o")} {shortLine}\r\n{JsonConvert.SerializeObject(modList, jsonSettings)}\r\n{longLine}\r\n";
                    File.AppendAllText(file, working, Encoding.UTF8);
                }
            } catch (Exception ex) {
                MessageBox.Show($"There was an error saving the mod list.\r\n\r\nType: {ex.GetType().Name}\r\n\r\n{ex.Message}", "Error Saving Mod List", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BackupModList() {
            SaveModList($"{EXEDirectory}\\working.json.backup", true);
        }

        private void IsItemSelected(bool selected, ListViewItem item = null) {
            CurrentlySelectedItem = item;

            RequirementButton.Enabled = selected;
            EditButton.Enabled = selected;
            RemoveButton.Enabled = selected;
            LinkLinkLabel.Enabled = selected;

            if (item == null) {
                SizeTextBox.Clear();
                UpdatedTextBox.Clear();
                LinkTextBox.Clear();
                MD5TextBox.Clear();
                RequiresTextBox.Clear();
                NotesTextBox.Clear();
            } else {
                Mod selectedMod = (Mod)CurrentlySelectedItem.Tag;
                SizeTextBox.Text = selectedMod.Size;
                UpdatedTextBox.Text = selectedMod.Date.ToLocalTime().ToString();
                LinkTextBox.Text = selectedMod.Link;
                MD5TextBox.Text = selectedMod.MD5;
                RequiresTextBox.Text = selectedMod.RequiresToString();
                NotesTextBox.Text = selectedMod.Notes;
            }
        }

    }
}
