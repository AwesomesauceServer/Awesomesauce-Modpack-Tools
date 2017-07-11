﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;
using AwesomesauceModpackTools.Mods;
using Newtonsoft.Json;
using static AwesomesauceModpackTools.Utilities;
using static AwesomesauceModpackTools.Mods.Providers.CurseForge;
using System.Text;

namespace AwesomesauceModpackTools.Updater {

    public partial class UpdaterForm : Form {

        /// <summary>
        /// Is there currently running updates.
        /// </summary>
        private bool IsUpdating = false;

        /// <summary>
        /// Cancel currently running downloads.
        /// </summary>
        private bool IsCanceling = false;

        /// <summary>
        /// Set to true if anything failed.
        /// </summary>
        private bool HasErrors = false;

        /// <summary>
        /// URL of the packs JSON file on GitHub
        /// </summary>
        private const string PacksJSON_URL = "https://raw.githubusercontent.com/AwesomesauceServer/Awesomesauce-Modpack/master/packs.json";

        public UpdaterForm() {
            InitializeComponent();
            Icon = Properties.Resources.AwesomesauceIcon;
        }

        private void UpdaterForm_Load(object sender, EventArgs e) {
            try {
                WebClient client = new WebClient();
                client.Headers.Add("user-agent", UserAgent);
                string packsJSON = client.DownloadString(PacksJSON_URL);

                List<Pack> packList = JsonConvert.DeserializeObject<List<Pack>>(packsJSON);

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
            } catch (Exception ex) {
                MessageBox.Show($"There was an error loading the pack list from GitHub.\r\n\r\nType: {ex.GetType().Name}\r\n\r\n{ex.Message}", "Error Loading Pack List", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdaterForm_FormClosing(object sender, FormClosingEventArgs e) {
            if (IsUpdating) {
                if (MessageBox.Show("Really exit?\r\n\r\nThere are files currently updating.", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No) {
                    e.Cancel = true;
                    return;
                }
                IsCanceling = true;
                Dispose();
            }
        }

        private void GameVersionsComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            if (GameVersionsComboBox.SelectedItem != null) { if (ModListView.Items.Count != 0) { UpdateButton.Enabled = true; } else { UpdateButton.Enabled = false; } }
        }

        private void UpdateButton_Click(object sender, EventArgs e) {
            UpdateMods();
        }

        private void SaveButton_Click(object sender, EventArgs e) {
            if (SaveModListDialog.ShowDialog() == DialogResult.OK) { SaveModList(SaveModListDialog.FileName); }
        }

        private async Task UpdateMods() {
            IsUpdating = true;
            LoadFromPanel.Enabled = false;
            GameVersionsComboBox.Enabled = false;
            UpdateButton.Enabled = false;
            SavePanel.Enabled = false;

            Color working = Color.LightBlue;
            Color available = Color.LightGreen;
            Color skipped = Color.Honeydew;
            Color notAvailable = Color.LightGray;
            Color error = Color.Tomato;

            int errorCount = 0;
            foreach (ListViewItem item in ModListView.Items) {
                if (IsCanceling) { break; }
                if (HasErrors) { if (item.BackColor != error) { continue; } }

                Mod itemMod = (Mod)item.Tag;
                if (itemMod.UpdateMode != UpdateMode.Automatic) {
                    item.BackColor = skipped;
                    item.EnsureVisible();
                    continue;
                }
                string oldMD5 = itemMod.MD5;

                item.BackColor = working;
                item.EnsureVisible();

                string selectedGameVersion = null;
                switch (GameVersionsComboBox.SelectedItem) {
                    case "1.10.2":
                        selectedGameVersion = GameVersion1102;
                        break;
                    case "1.11.2":
                        selectedGameVersion = GameVersion1112;
                        break;
                    case "1.2":
                        selectedGameVersion = GameVersion112;
                        break;
                }

                try {
                    await Task.Run(() => { itemMod = ParseForUpdate(itemMod, selectedGameVersion).Mod; });

                    if (itemMod.MD5 == oldMD5) {
                        item.BackColor = notAvailable;
                    } else {
                        item.BackColor = available;
                        item.SubItems.Add(new ListViewItem.ListViewSubItem { Text = itemMod.File });
                        item.Tag = itemMod;
                    }
                } catch {
                    errorCount++;
                    item.BackColor = error;
                }

            }

            if (errorCount == 0) {
                UpdateButton.Text = "Finished";

                SaveLabel.Text = "Click save to choose where to save the updated mod list.";
                SavePanel.BackColor = Color.LightGreen;
                if (SavePanel.Visible == false) { BlinkSave(Color.LightGreen); }
                SavePanel.Visible = true;
            } else {
                errorCount = 0;
                HasErrors = true;
                UpdateButton.Text = "Retry Failed Mods";
                UpdateButton.Enabled = true;

                SaveLabel.Text = "Some mods failed to update, you can still save the complete mod list. Any failed mods will be exactly the same as they were.";
                SavePanel.BackColor = Color.LightYellow;
                if (SavePanel.Visible == false) { BlinkSave(Color.LightYellow); }
                SavePanel.Visible = true;
            }

            SavePanel.Enabled = true;
            IsUpdating = false;
        }

        private async void BlinkSave(Color color) {
            while (true) {
                await Task.Delay(750);

                if (color == Color.LightGreen) {
                    SavePanel.BackColor = SavePanel.BackColor == Color.LightGreen ? Color.LimeGreen : Color.LightGreen;
                } else if (color == Color.LightYellow) {
                    SavePanel.BackColor = SavePanel.BackColor == Color.LightYellow ? Color.PaleGoldenrod : Color.LightYellow;
                }
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

                if (GameVersionsComboBox.SelectedItem != null) { if (ModListView.Items.Count != 0) { UpdateButton.Enabled = true; } else { UpdateButton.Enabled = false; } }
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

                    if (GameVersionsComboBox.SelectedItem != null) { if (ModListView.Items.Count != 0) { UpdateButton.Enabled = true; } else { UpdateButton.Enabled = false; } }
                }
            } catch (Exception ex) {
                MessageBox.Show($"There was an error loading the mod list.\r\n\r\nType: {ex.GetType().Name}\r\n\r\n{ex.Message}", "Error Loading Mod List", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadModList(string file, string fromString = null) {
            try {
                List<Mod> loadedMods = new List<Mod>();
                if (fromString == null) {
                    loadedMods = JsonConvert.DeserializeObject<List<Mod>>(File.ReadAllText(file));
                } else {
                    loadedMods = JsonConvert.DeserializeObject<List<Mod>>(fromString);
                }

                foreach (Mod mod in loadedMods) { AddListViewItem(new ListViewItem(new string[] { mod.Name, mod.File }), mod); }
            } catch (Exception ex) {
                MessageBox.Show($"There was an error loading the mod list.\r\n\r\nType: {ex.GetType().Name}\r\n\r\n{ex.Message}", "Error Loading Mod List", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveModList(string file) {
            try {
                List<Mod> modList = new List<Mod>();
                foreach (ListViewItem item in ModListView.Items) { modList.Add((Mod)item.Tag); }

                JsonSerializerSettings jsonSettings = new JsonSerializerSettings() { Formatting = Formatting.Indented };
                File.WriteAllText(file, JsonConvert.SerializeObject(modList, jsonSettings), Encoding.UTF8);

            } catch (Exception ex) {
                MessageBox.Show($"There was an error saving the mod list.\r\n\r\nType: {ex.GetType().Name}\r\n\r\n{ex.Message}", "Error Saving Mod List", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                LoadingLabel.TextAlign = ContentAlignment.MiddleCenter;
                LoadingLabel.Font = new Font("Segoe UI Semibold", 32F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
                LoadingLabel.Text = "Loading...";

                Application.DoEvents();
            } else {
                LoadingLabel.Visible = false;
            }
        }

    }
}