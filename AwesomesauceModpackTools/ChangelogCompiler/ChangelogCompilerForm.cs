using System;
using System.Linq;
using System.Windows.Forms;
using static AwesomesauceModpackTools.Mods.Parsing;
using static AwesomesauceModpackTools.Utilities.Storage;

namespace AwesomesauceModpackTools.ChangelogCompiler {

    public partial class ChangelogCompilerForm : Form {

        public ChangelogCompilerForm() {
            InitializeComponent();
            Icon = Properties.Resources.AwesomesauceIcon;

            HTMLWebBrowser.DocumentText = Properties.Resources.ChangelogCompiler_HTML_Default;
            GameVersionsComboBox.Items.AddRange(MinecraftVersions.GameVersions.Keys.ToArray());
        }

        private void ChangelogCompilerForm_Load(object sender, EventArgs e) {
            // MinecraftVersions.GameVersions[(string)GameVersionsComboBox.SelectedItem];



        }

    }

}
