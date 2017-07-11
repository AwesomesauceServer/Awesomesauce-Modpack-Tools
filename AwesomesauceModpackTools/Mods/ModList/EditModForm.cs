using System;
using System.Windows.Forms;

namespace AwesomesauceModpackTools.Mods.ModList {

    public partial class EditModForm : Form {

        /// <summary>
        /// Mod that is being edited.
        /// </summary>
        public Mod EditingMod { get; set; }

        public EditModForm() {
            InitializeComponent();
            Icon = Properties.Resources.AwesomesauceIcon;
        }

        private void NoteForm_Load(object sender, EventArgs e) {
            Text = $"Editing {EditingMod.Name}";

            SideComboBox.DataSource = Enum.GetValues(typeof(Side));
            UpdateModeComboBox.DataSource = Enum.GetValues(typeof(UpdateMode));

            SideComboBox.Text = EditingMod.Side.ToString();
            UpdateModeComboBox.Text = EditingMod.UpdateMode.ToString();

            NotesTextBox.Text = EditingMod.Notes;   
        }

        private void NoteForm_FormClosing(object sender, FormClosingEventArgs e) {
            EditingMod.Side = (Side)Enum.Parse(typeof(Side), SideComboBox.SelectedValue.ToString());
            EditingMod.UpdateMode = (UpdateMode)Enum.Parse(typeof(UpdateMode), UpdateModeComboBox.SelectedValue.ToString());
            if (NotesTextBox.Text.Trim() == "") { EditingMod.Notes = null; } else { EditingMod.Notes = NotesTextBox.Text; }

            DialogResult = DialogResult.OK;
        }

    }
}
