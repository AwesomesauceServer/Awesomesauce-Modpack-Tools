using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
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
            if (HasInternet == true) {
                LoadGithub();
            } else{
                MessageBox.Show("A connection to the internet can not be established.\r\n" +
                    "This will prevent some features from working.\r\n\r\n" +
                    "Mod lists from GitHub, the Updater, and the Downloader will have limited functionality or will not work.\r\n\r\n" +
                    "To fix this check your internet connection and/or your firewall and restart the app.", "Awesomesauce Modpack Tools - No Internet", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }   
#endif

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e) {
            if (Application.OpenForms.Count != 1) {
                string working = "";
                foreach (Form form in Application.OpenForms) {
                    if (form.Text == Text) { continue; }
                    working += $"{form.Text}\r\n";
                }
                working = working.Trim();

                if (MessageBox.Show($"There are tool windows still open, exit anyways?\r\n\r\nThe following tool windows are open\r\n{working}", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No) {
                    e.Cancel = true;
                    return;
                }
            }
        }

        private async Task LoadGithub() {
            LoadGithub_ModpackList();
            LoadGithub_Modpack();
            LoadGithub_Tools();
        }

        private void LoadGithub_ModpackList() {
            try {
                WebClient client = new WebClient();
                client.Headers.Add("user-agent", UserAgent);
                client.DownloadStringCompleted += (clientSender, clientE) => { ModpackList = JsonConvert.DeserializeObject<List<Pack>>(clientE.Result); };

                client.DownloadStringAsync(ModpackList_URI);
            } catch {
                ModpackList = null;
            }
        }

        private async Task LoadGithub_Modpack() {
            try {
                Octokit.GitHubClient github = new Octokit.GitHubClient(new Octokit.ProductHeaderValue(AppName));
                IReadOnlyList<Octokit.GitHubCommit> commits = await github.Repository.Commit.GetAll("AwesomesauceServer", "Awesomesauce-Modpack");

                foreach (Octokit.GitHubCommit commit in commits) {
                    string messageFormat = commit.Commit.Message.Replace("\n\n", ", ");
                    ModpackListView.Items.Add(new ListViewItem(new string[] { ElapsedTime(commit.Commit.Author.Date.DateTime.ToLocalTime()).Formatted, messageFormat }));
                }
            } catch (Exception ex) {
                MessageBox.Show($"There was an error getting information from GitHub.\r\n\r\n{ex.Message}", "Error Loading Awesomesauce-Modpack", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task LoadGithub_Tools() {
            try {
                Octokit.GitHubClient github = new Octokit.GitHubClient(new Octokit.ProductHeaderValue(AppName));
                IReadOnlyList<Octokit.GitHubCommit> commits = await github.Repository.Commit.GetAll("AwesomesauceServer", "Awesomesauce-Modpack-Tools");

                foreach (Octokit.GitHubCommit commit in commits) {
                    string messageFormat = commit.Commit.Message.Replace("\n\n", ", ");
                    ToolsListView.Items.Add(new ListViewItem(new string[] { ElapsedTime(commit.Commit.Author.Date.DateTime.ToLocalTime()).Formatted, messageFormat }));
                }
            } catch (Exception ex) {
                MessageBox.Show($"There was an error getting information from GitHub.\r\n\r\n{ex.Message}", "Error Loading Awesomesauce-Modpack-Tools", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void UpdaterButton_Click(object sender, EventArgs e) {
            Updater.UpdaterForm updaterForm = new Updater.UpdaterForm();
            updaterForm.Show();

        }

    }
}
