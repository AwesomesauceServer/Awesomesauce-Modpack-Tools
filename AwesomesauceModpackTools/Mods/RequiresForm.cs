using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AwesomesauceModpackTools.Mods {

    public partial class RequiresForm : Form {

        public List<Mod> CheckedMods { get; set; } = new List<Mod>();

        public RequiresForm() {
            InitializeComponent();
            Icon = Properties.Resources.AwesomesauceIcon;
        }

        private void AddRequirementForm_Load(object sender, EventArgs e) {
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
                Text = "Add Requirement";
            } else {
                Text = $"{ModListView.CheckedItems.Count} requirements selected";
            }
        }

        private void UncheckAllButton_Click(object sender, EventArgs e) {
            foreach (ListViewItem item in ModListView.CheckedItems) {
                if (item.Checked == true) { item.Checked = false; }
            }
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

    }
}
