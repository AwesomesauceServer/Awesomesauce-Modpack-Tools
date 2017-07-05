using System;
using System.Windows.Forms;

namespace AwesomesauceModpackTools {

    public partial class NotesForm : Form {

        public string NewNotes { get; set; }

        public NotesForm() {
            InitializeComponent();
            Icon = Properties.Resources.AwesomesauceIcon;
        }

        private void NoteForm_Load(object sender, EventArgs e) {

        }

        private void NoteForm_FormClosing(object sender, FormClosingEventArgs e) {
            NewNotes = NotesTextBox.Text.Trim();

            DialogResult = DialogResult.OK;
        }

    }
}
