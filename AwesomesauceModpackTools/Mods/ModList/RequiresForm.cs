using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AwesomesauceModpackTools.Mods.ModList {

    public partial class RequiresForm : Form {

        /// <summary>
        /// Mod that is selected in the ModListForm.
        /// </summary>
        public Mod SelectedMod { get; set; }

        /// <summary>
        /// Temporary mod list, cloned from ModListForm.
        /// </summary>
        public List<ListViewItem> ListItems { get; set; } = new List<ListViewItem>();

        /// <summary>
        /// Mods that were checked.
        /// </summary>
        public List<Mod> CheckedMods { get; set; } = new List<Mod>();

        public RequiresForm() {
            InitializeComponent();
            Icon = Properties.Resources.AwesomesauceIcon;
        }

        private void AddRequirementForm_Load(object sender, EventArgs e) {
            foreach (ListViewItem item in ListItems) {
                Mod itemMod = (Mod)item.Tag;
                if (SelectedMod.ID == itemMod.ID) { continue; }

                ListViewItem newItem = new ListViewItem(new string[] { itemMod.Name, itemMod.File }) {
                    Tag = itemMod
                };

                foreach (RequiredMod required in SelectedMod.Requires) {
                    if (required.ID == itemMod.ID) { newItem.Checked = true; }
                }

                ModListView.Items.Add(newItem);
            }

            SearchTextBox.Focus();
        }

        private void AddRequirementForm_FormClosing(object sender, FormClosingEventArgs e) {
            foreach (ListViewItem item in ModListView.CheckedItems) {
                CheckedMods.Add((Mod)item.Tag);
            }

            DialogResult = DialogResult.OK;
        }

        private void ModsListView_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void ModsListView_ItemChecked(object sender, ItemCheckedEventArgs e) {
            if (ModListView.CheckedItems.Count == 0) {
                Text = $"Edit Requirements for {SelectedMod.Name}";
            } else {
                Text = $"{ModListView.CheckedItems.Count} requirements selected for {SelectedMod.Name}";
            }
        }

        private void UncheckAllButton_Click(object sender, EventArgs e) {
            if (MessageBox.Show("Really uncheck all requirements?", "Confirm Uncheck", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes) {
                foreach (ListViewItem item in ModListView.CheckedItems) {
                    if (item.Checked == true) { item.Checked = false; }
                }
            }  
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e) {
            if (ModListView.Items.Count == 0) { return; }

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

    }
}
