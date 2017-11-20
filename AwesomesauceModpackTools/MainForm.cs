using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;
using Humanizer;
using Newtonsoft.Json;
using static AwesomesauceModpackTools.Utilities.Storage;

namespace AwesomesauceModpackTools {

    public partial class MainForm : Form {

        private Octokit.GitHubClient _Github;

        public MainForm() {
            InitializeComponent();
            Icon = Properties.Resources.AwesomesauceIcon;
            Text = $"{Text} v{Version.Parse(Application.ProductVersion).ToString(3)}";
        }

        private void MainForm_Load(object sender, EventArgs e) {
#if RELEASE
            if (HasInternet) {
                _Github = new Octokit.GitHubClient(new Octokit.ProductHeaderValue(AppName, Version.Parse(Application.ProductVersion).ToString(3)));
                if (GithubCredentials != "") { _Github.Credentials = new Octokit.Credentials(GithubCredentials); }

                LoadGithub();
            } else{
                MessageBox.Show("A connection to the internet can not be established.\r\n" +
                    "This will prevent some features from working.\r\n\r\n" +
                    "Mod lists from GitHub, the Updater, the Downloader, and the Changelog Compiler will have limited functionality or will not work.\r\n\r\n" +
                    "To fix this check your internet connection and/or your firewall and restart Awesomesauce Modpack Tools.", "Awesomesauce Modpack Tools - No Internet", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void ReleasesListView_MouseDoubleClick(object sender, MouseEventArgs e) {
            if (ReleasesListView.SelectedItems.Count == 1) {
                try { Process.Start((string)ReleasesListView.SelectedItems[0].Tag); } catch { }
            }
        }

        private void ToolsListView_MouseDoubleClick(object sender, MouseEventArgs e) {
            if (ToolsListView.SelectedItems.Count == 1) {
                try { Process.Start((string)ToolsListView.SelectedItems[0].Tag); } catch { }
            }
        }

        private void ModpackListView_MouseDoubleClick(object sender, MouseEventArgs e) {
            if (ModpackListView.SelectedItems.Count == 1) {
                try { Process.Start((string)ModpackListView.SelectedItems[0].Tag); } catch { }
            }
        }

        private void LoadGithub() {
            LoadGithub_ModpackList();
            Task loadGithub_ReleasesTask = LoadGithub_Releases();
            Task loadGithub_ToolsTask = LoadGithub_Tools();
            Task loadGithub_ModpackTask = LoadGithub_Modpack();
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

        private async Task LoadGithub_Releases() {
            try {
                IReadOnlyList<Octokit.Release> releases = await _Github.Repository.Release.GetAll("AwesomesauceServer", "Awesomesauce-Modpack-Tools");

                foreach (Octokit.Release release in releases) {
                    string bodyFormat = System.Text.RegularExpressions.Regex.Replace(release.Body, @"http[^\s]+", "");
                    bodyFormat = bodyFormat.Replace(Environment.NewLine, ", ");
                    bodyFormat = bodyFormat.Replace("(", "").Replace(")", "");
                    bodyFormat = bodyFormat.Replace("[", "").Replace("]", "");
                    bodyFormat = bodyFormat.Replace(" ,", ",").Replace(",,", ",");
                    bodyFormat = bodyFormat.Replace("*", "");
                    bodyFormat = bodyFormat.Replace("  ", " ");
                    bodyFormat = bodyFormat.Trim();
                    if (bodyFormat.EndsWith(",")) { bodyFormat = bodyFormat.Remove(bodyFormat.Length - 1, 1); }

                    string messageFormat = $"{release.Name}: {bodyFormat}";

                    ListViewItem newItem = new ListViewItem(new string[] { release.PublishedAt.Value.ToLocalTime().Humanize(), messageFormat });
                    ReleasesListView.Items.Add(newItem).Tag = release.HtmlUrl;
                }
            } catch (Exception ex) {
                MessageBox.Show($"There was an error getting information from GitHub.\r\n\r\n{ex.Message}", "Error Loading Awesomesauce-Modpack-Tools Releases", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task LoadGithub_Tools() {
            try {
                IReadOnlyList<Octokit.GitHubCommit> commits = await _Github.Repository.Commit.GetAll("AwesomesauceServer", "Awesomesauce-Modpack-Tools");

                foreach (Octokit.GitHubCommit commit in commits) {
                    string messageFormat = commit.Commit.Message.Replace("\n\n", ", ");

                    ListViewItem newItem = new ListViewItem(new string[] { commit.Commit.Author.Date.DateTime.ToLocalTime().Humanize(), messageFormat });
                    ToolsListView.Items.Add(newItem).Tag = commit.HtmlUrl;
                }
            } catch (Exception ex) {
                MessageBox.Show($"There was an error getting information from GitHub.\r\n\r\n{ex.Message}", "Error Loading Awesomesauce-Modpack-Tools", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task LoadGithub_Modpack() {
            try {
                IReadOnlyList<Octokit.GitHubCommit> commits = await _Github.Repository.Commit.GetAll("AwesomesauceServer", "Awesomesauce-Modpack");

                foreach (Octokit.GitHubCommit commit in commits) {
                    string messageFormat = commit.Commit.Message.Replace("\n\n", ", ");

                    ListViewItem newItem = new ListViewItem(new string[] { commit.Commit.Author.Date.DateTime.ToLocalTime().Humanize(), messageFormat });
                    ModpackListView.Items.Add(newItem).Tag = commit.HtmlUrl;
                }
            } catch (Exception ex) {
                MessageBox.Show($"There was an error getting information from GitHub.\r\n\r\n{ex.Message}", "Error Loading Awesomesauce-Modpack", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void ChangelogCompilerButton_Click(object sender, EventArgs e) {
            ChangelogCompiler.ChangelogCompilerForm changelogCompilerForm = new ChangelogCompiler.ChangelogCompilerForm();
            changelogCompilerForm.Show();
        }

    }

}
