using System;
using System.Windows.Forms;

namespace AwesomesauceModpackTools {

    public partial class MainForm : Form {

        public MainForm() {
            InitializeComponent();
            Icon = Properties.Resources.AwesomesauceIcon;
            Text = $"{Text} v{Version.Parse(Application.ProductVersion).ToString(3)}";
        }

        private void MainForm_Load(object sender, EventArgs e) {

        }

        private void ManageModsButton_Click(object sender, EventArgs e) {
            Mods.ManageForm manageForm = new Mods.ManageForm();
            manageForm.Show();

        }

    }
}
