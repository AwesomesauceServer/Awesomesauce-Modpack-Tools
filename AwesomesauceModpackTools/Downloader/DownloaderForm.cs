using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;
using AwesomesauceModpackTools.Mods;
using Newtonsoft.Json;
using static AwesomesauceModpackTools.Utilities;

namespace AwesomesauceModpackTools.Downloader {

    public partial class DownloaderForm : Form {

        /// <summary>
        /// Is there currently running downloads.
        /// </summary>
        private bool IsDownloading = false;

        /// <summary>
        /// Cancel currently running downloads.
        /// </summary>
        private bool IsCanceling = false;

        /// <summary>
        /// Set to true if anything failed.
        /// </summary>
        private bool HasErrors = false;

        public DownloaderForm() {
            InitializeComponent();
            Icon = Properties.Resources.AwesomesauceIcon;
        }

        private void DownloaderForm_Load(object sender, EventArgs e) {
            try {
                if (ModpackList != null && ModpackList.Count != 0) {
                    foreach (Pack pack in ModpackList) { PacksComboBox.Items.Add(pack); }
                    PacksComboBox.SelectedIndex = 0;

                    LoadGitHubButton.Enabled = true;
                } else {
                    LoadFromGitHubLabel.Enabled = false;
                    PacksComboBox.Enabled = false;
                    PacksComboBox.Items.Add("No packs found");
                    PacksComboBox.Text = "No packs found";
                    OrLabel.Enabled = false;
                }
            } catch (Exception ex) {
                MessageBox.Show($"There was an error loading the pack list from GitHub.\r\n\r\nType: {ex.GetType().Name}\r\n\r\n{ex.Message}", "Error Loading Pack List", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DownloaderForm_FormClosing(object sender, FormClosingEventArgs e) {
            if (IsDownloading) {
                if (MessageBox.Show("Really exit?\r\n\r\nThere are files currently downloading.", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No) {
                    e.Cancel = true;
                    return;
                }
                IsCanceling = true;
                Dispose();
            }
        }

        private void LoadGitHubButton_Click(object sender, EventArgs e) {
            if (ModListView.Items.Count != 0) {
                DialogResult overwrite = MessageBox.Show("The download list is not empty, are you sure you want to overwrite the current list?", "Confirm Overwrite", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (overwrite == DialogResult.No) { return; }
            }

            try {
                ToggleLoadingLabel(true);
                ModListView.BeginUpdate();
                ModListView.Items.Clear();

                Pack selectedPack = (Pack)PacksComboBox.SelectedItem;
                WebClient client = new WebClient();
                client.Headers.Add("user-agent", UserAgent);
                string modListString = client.DownloadString(selectedPack.ModListURL);

                LoadModList(null, modListString);

                ModListView.EndUpdate();
                ToggleLoadingLabel(false);

                if (ModListView.Items.Count != 0) { DownloadButton.Enabled = true; } else { DownloadButton.Enabled = false; }
            } catch (Exception ex) {
                MessageBox.Show($"There was an error loading the mod list from GitHub.\r\n\r\nType: {ex.GetType().Name}\r\n\r\n{ex.Message}", "Error Loading Mod List", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void LoadLocalButton_Click(object sender, EventArgs e) {
            if (ModListView.Items.Count != 0) {
                DialogResult overwrite = MessageBox.Show("The download list is not empty, are you sure you want to overwrite the current list?", "Confirm Overwrite", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (overwrite == DialogResult.No) { return; }
            }

            try {
                if (LoadModListDialog.ShowDialog() == DialogResult.OK) {
                    ToggleLoadingLabel(true);
                    ModListView.BeginUpdate();
                    ModListView.Items.Clear();

                    await Task.Run(() => LoadModList(LoadModListDialog.FileName));

                    ModListView.EndUpdate();
                    ToggleLoadingLabel(false);

                    if (ModListView.Items.Count != 0) { DownloadButton.Enabled = true; } else { DownloadButton.Enabled = false; }
                }
            } catch (Exception ex) {
                MessageBox.Show($"There was an error loading the mod list.\r\n\r\nType: {ex.GetType().Name}\r\n\r\n{ex.Message}", "Error Loading Mod List", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DownloadButton_Click(object sender, EventArgs e) {
            if (DownloadBrowserDialog.ShowDialog() == DialogResult.OK) {
                DownloadMods(DownloadBrowserDialog.SelectedPath);
            }          
        }

        private async Task DownloadMods(string path) {
            IsDownloading = true;
            LoadFromPanel.Enabled = false;
            DownloadButton.Enabled = false;

            Color working = Color.LightBlue;
            Color done = Color.LightGreen;
            Color error = Color.Tomato;

            int errorCount = 0;
            foreach (ListViewItem item in ModListView.Items) {
                if (IsCanceling) { break; }
                if (HasErrors) { if (item.BackColor != error) { continue; } }

                try {
                    Mod itemMod = (Mod)item.Tag;

                    item.BackColor = working;
                    item.EnsureVisible();

                    string downloadPath = $@"{path}\{itemMod.File}";

                    WebClient client = new WebClient();
                    client.Headers.Add("user-agent", UserAgent);

                    client.DownloadFileCompleted += (clientSender, clientE) => {
                        string hash = MD5File(downloadPath);

                        if (hash == itemMod.MD5) {
                            if (clientE.Error != null) {
                                errorCount++;
                                item.BackColor = error;
                                DeleteFile(downloadPath);
                            } else {
                                item.BackColor = done;
                            }
                        } else {
                            errorCount++;
                            item.BackColor = error;
                            DeleteFile(downloadPath);
                        }
                    };

                    await client.DownloadFileTaskAsync(new Uri(itemMod.Link_Download), downloadPath);
                } catch (Exception ex) {
                    errorCount++;
                    item.BackColor = error;
                }
            }

            if (errorCount == 0) {
                DownloadButton.Text = "Finished";
            } else {
                errorCount = 0;
                HasErrors = true;
                DownloadButton.Text = "Retry Failed Mods";
                DownloadButton.Enabled = true;
            }
            IsDownloading = false;
        }

        private void LoadModList(string file, string fromString = null) {
            try {
                List<Mod> loadedMods = new List<Mod>();
                if (fromString == null) {
                    loadedMods = JsonConvert.DeserializeObject<List<Mod>>(File.ReadAllText(file));
                } else {
                    loadedMods = JsonConvert.DeserializeObject<List<Mod>>(fromString);
                }

                foreach (Mod mod in loadedMods) { AddListViewItem(new ListViewItem(new string[] { mod.Name, mod.MD5 }), mod); }
            } catch (Exception ex) {
                MessageBox.Show($"There was an error loading the mod list.\r\n\r\nType: {ex.GetType().Name}\r\n\r\n{ex.Message}", "Error Loading Mod List", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddListViewItem(ListViewItem item, Mod tag) {
            if (InvokeRequired) {
                MethodInvoker invoker = () => AddListViewItem(item, tag);
                Invoke(invoker);
                return;
            }
            ModListView.Items.Add(item).Tag = tag;
        }

        private Label LoadingLabel = null;
        private void ToggleLoadingLabel(bool showLabel) {
            if (showLabel == true) {
                if (LoadingLabel != null) {
                    LoadingLabel.Visible = true;
                    return;
                }

                LoadingLabel = new Label();
                Controls.Add(LoadingLabel);
                LoadingLabel.AutoSize = false;
                LoadingLabel.BringToFront();
                LoadingLabel.Dock = DockStyle.Fill;
                LoadingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                LoadingLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                LoadingLabel.Text = "Loading...";

                Application.DoEvents();
            } else {
                LoadingLabel.Visible = false;
            }
        }

    }
}
