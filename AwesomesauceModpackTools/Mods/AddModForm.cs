using System;
using System.Windows.Forms;
using static AwesomesauceModpackTools.Utilities;

namespace AwesomesauceModpackTools.Mods {

    public partial class AddModForm : Form {

        public Mod NewMod { get; set; } = new Mod();
        public string AbortError { get; set; } = "";
        public bool AddWithRequirement { get; set; } = false;

        public AddModForm() {
            InitializeComponent();
            Icon = Properties.Resources.AwesomesauceIcon;
        }

        private void AddModForm_Load(object sender, EventArgs e) {
            try {
                if (Clipboard.ContainsText()) {
                    string clipboardText = Clipboard.GetText();
                    if (IsValidURL(clipboardText, UriKind.Absolute)) {
                        if (URLContainsDomain(clipboardText, "minecraft.curseforge.com")) {
                            AddTextBox.Text = clipboardText;
                            ExampleLabel.Text = "Pasted the link from the clipboard";
                        }
                    }
                }
            } catch { }
        }

        private void AddButton_Click(object sender, EventArgs e) {
            string url = AddTextBox.Text.Trim();

            // Check if the URL is blank.
            if (url == "") {
                MessageBox.Show("The link can not be blank!", "Blank Input", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                AddTextBox.Focus();
                return;
            }

            // Check if the URL is a valid URL.
            if (!IsValidURL(url, UriKind.Absolute)) {
                MessageBox.Show("The link it not valid!\r\nMake sure it contains the proper protocol prefix (http, https)...", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                AddTextBox.Focus();
                return;
            }

            // Check if the URL is a CurseForge link.
            if (!URLContainsDomain(url, "minecraft.curseforge.com")) {
                MessageBox.Show("The link it not a valid CurseForge link!", "Invalid Domain", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                AddTextBox.Focus();
                return;
            }

            ToggleProcessing(true);

            try {
                NewMod.Link = url;
                (Mod Mod, Exception Exception) parseResult = CurseForge.ParseForInfo(NewMod);
                NewMod = parseResult.Mod;

                if (parseResult.Exception != null) { throw parseResult.Exception; }
                if (NewMod == null) { throw new ArgumentNullException("NewMod"); }
                
                DialogResult = DialogResult.OK;
            } catch (Exception ex) {
                AbortError = ex.Message;
                DialogResult = DialogResult.Abort;
            }
        }

        private void AddWithRequirementButton_Click(object sender, EventArgs e) {
            AddWithRequirement = true;
            AddButton_Click(null, new EventArgs());
        }

        private void CancelAddButton_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
        }

        private void ToggleProcessing(bool isProcessing) {
            ExampleLabel.Visible = !isProcessing;
            AddProgressPanel.Visible = isProcessing;
            AddTextBox.ReadOnly = isProcessing;
            AddButton.Enabled = !isProcessing;
            AddWithRequirementButton.Enabled = !isProcessing;

            Application.DoEvents();
        }

    }
}
