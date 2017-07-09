using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Threading.Tasks;
using AwesomesauceModpackTools.Mods;
using System.Net;
using System.IO;

namespace AwesomesauceModpackTools.Downloader {

    public partial class DownloaderForm : Form {

        private string PacksJSON = "";
        private const string PacksJSON_URL = "https://raw.githubusercontent.com/AwesomesauceServer/Awesomesauce-Modpack/master/packs.json";

        public DownloaderForm() {
            InitializeComponent();
            Icon = Properties.Resources.AwesomesauceIcon;
        }

        private void DownloaderForm_Load(object sender, EventArgs e) {
#if RELEASE
            WebClient client = new WebClient();
            PacksJSON = client.DownloadString(PacksJSON_URL);
#elif DEBUG
            PacksJSON = File.ReadAllText(@"..\..\datasamples\packs.json");
#endif
            List<Pack> packList = JsonConvert.DeserializeObject<List<Pack>>(PacksJSON);

            if (packList != null && packList.Count != 0) {
                foreach (Pack pack in packList) { PacksComboBox.Items.Add(pack); }
                PacksComboBox.SelectedIndex = 0;
            } else {
                LoadFromGitHubLabel.Enabled = false;
                PacksComboBox.Enabled = false;
                PacksComboBox.Items.Add("No packs found");
                PacksComboBox.Text = "No packs found";
                OrLabel.Enabled = false;
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
                Application.DoEvents();

                Pack selectedPack = (Pack)PacksComboBox.SelectedItem;
                WebClient client = new WebClient();
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
                    Application.DoEvents();

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
            } else {
                LoadingLabel.Visible = false;
            }
        }

    }
}
