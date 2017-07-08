using System;
using System.Windows.Forms;

namespace AwesomesauceModpackTools.Mods.ModList {

    public partial class EditModForm : Form {

        public Mod EditedMod { get; set; }

        public EditModForm() {
            InitializeComponent();
            Icon = Properties.Resources.AwesomesauceIcon;
        }

        private void NoteForm_Load(object sender, EventArgs e) {

        }

        private void NoteForm_FormClosing(object sender, FormClosingEventArgs e) {
           

            DialogResult = DialogResult.OK;
        }

    }
}
