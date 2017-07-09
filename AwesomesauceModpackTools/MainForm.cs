using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using static AwesomesauceModpackTools.Utilities;

namespace AwesomesauceModpackTools {

    public partial class MainForm : Form {

        public MainForm() {
            InitializeComponent();
            Icon = Properties.Resources.AwesomesauceIcon;
            Text = $"{Text} v{Version.Parse(Application.ProductVersion).ToString(3)}";
        }

        private void MainForm_Load(object sender, EventArgs e) {
#if RELEASE
            LoadGithub();
#endif

        }

        private async Task LoadGithub() {
            LoadGithub_Modpack();
            LoadGithub_Tools();
        }

        private async Task LoadGithub_Modpack() {
            Octokit.GitHubClient github = new Octokit.GitHubClient(new Octokit.ProductHeaderValue("Awesomesauce-Modpack-Tools"));
            IReadOnlyList<Octokit.GitHubCommit> commits = await github.Repository.Commit.GetAll("AwesomesauceServer", "Awesomesauce-Modpack");

            foreach (Octokit.GitHubCommit commit in commits) {
                string messageFormat = commit.Commit.Message.Replace("\n\n", ", ");
                ModpackListView.Items.Add(new ListViewItem(new string[] { ElapsedTime(commit.Commit.Author.Date.DateTime.ToLocalTime()).Formatted, messageFormat }));
            }
        }

        private async Task LoadGithub_Tools() {
            Octokit.GitHubClient github = new Octokit.GitHubClient(new Octokit.ProductHeaderValue("Awesomesauce-Modpack-Tools"));
            IReadOnlyList<Octokit.GitHubCommit> commits = await github.Repository.Commit.GetAll("AwesomesauceServer", "Awesomesauce-Modpack-Tools");

            foreach (Octokit.GitHubCommit commit in commits) {
                string messageFormat = commit.Commit.Message.Replace("\n\n", ", ");
                ToolsListView.Items.Add(new ListViewItem(new string[] { ElapsedTime(commit.Commit.Author.Date.DateTime.ToLocalTime()).Formatted, messageFormat }));
            }
        }

        private void ManageModsButton_Click(object sender, EventArgs e) {
            Mods.ModList.ModListForm manageForm = new Mods.ModList.ModListForm();
            manageForm.Show();

        }

        private void DownloaderButton_Click(object sender, EventArgs e) {
            Downloader.DownloaderForm downloaderForm = new Downloader.DownloaderForm();
            downloaderForm.Show();

        }

    }
}
