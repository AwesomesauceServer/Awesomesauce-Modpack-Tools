using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;
using HtmlAgilityPack;
using static AwesomesauceModpackTools.Utilities;
using static AwesomesauceModpackTools.Utilities.Storage;

namespace AwesomesauceModpackTools.ChangelogCompiler {

    public partial class ChangelogCompilerForm : Form {

        /// <summary>
        /// Set when calling form programmatically.
        /// </summary>
        public string ModURLAuto { get; set; } = string.Empty;

        /// <summary>
        /// Set when calling form programmatically.
        /// </summary>
        public string GameVersionsAuto { get; set; } = string.Empty;

        public ChangelogCompilerForm() {
            InitializeComponent();
            Icon = Properties.Resources.AwesomesauceIcon;

            HTMLWebBrowser.DocumentText = Properties.Resources.ChangelogCompiler_HTML_Default;
            GameVersionsComboBox.Items.AddRange(Filters.GameVersions.Keys.ToArray());
        }

        private void ChangelogCompilerForm_Load(object sender, EventArgs e) {
            Show();
            if (Filters.GameVersions.Keys.Contains(GameVersionsAuto)) { GameVersionsComboBox.SelectedItem = GameVersionsAuto; }
            ModURLTextBox.Text = ModURLAuto;
            if (GameVersionsComboBox.SelectedItem != null && ModURLTextBox.Text.Trim() != string.Empty) { CompileButton.PerformClick(); }
        }

        private void CompileButton_Click(object sender, EventArgs e) {
            if (GameVersionsComboBox.SelectedItem == null) {
                MessageBox.Show("Please pick a Game Version", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                GameVersionsComboBox.Focus();
                return;
            }
            if (ModURLTextBox.Text.Trim() == string.Empty) {
                MessageBox.Show("Please ender a Mod URL", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                ModURLTextBox.Focus();
                return;
            }
            if (!IsValidURL(ModURLTextBox.Text, UriKind.Absolute)) {
                MessageBox.Show("Please ender a valid Mod URL", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                ModURLTextBox.Focus();
                return;
            }
     
            ShowMessage("Compiling...");
            IsCompiling(true);

            ModURLTextBox.Text = RemoveURLQueryString(ModURLTextBox.Text.Trim());
            if (ModURLTextBox.Text.EndsWith("/")) { ModURLTextBox.Text = ModURLTextBox.Text.Remove(ModURLTextBox.Text.Length - 1, 1); }
            if (ModURLTextBox.Text.EndsWith("/files")) { ModURLTextBox.Text = ModURLTextBox.Text.Remove(ModURLTextBox.Text.Length - 6, 6); }
            Dictionary<string, string> workingURLS = new Dictionary<string, string>();
            Dictionary<string, (string link, string html)> workingChangelogs = new Dictionary<string, (string link, string html)>();
            StringBuilder changelogBuilder = new StringBuilder();

            try {
                ShowMessage("Compiling...", "Gathering a list of links");

                HtmlWeb htmlWeb = new HtmlWeb() { UserAgent = UserAgent };
                HtmlAgilityPack.HtmlDocument tempHTML = htmlWeb.Load($"{ModURLTextBox.Text}/files{Filters.GameVersions[(string)GameVersionsComboBox.SelectedItem]}");

                if (htmlWeb.StatusCode == HttpStatusCode.OK) {
                    HtmlNode node = tempHTML.DocumentNode;

                    HtmlNodeCollection foundURLS = node.SelectNodes(Filters.XPaths.ChangelogCompiler.URL);
                    foreach (HtmlNode foundURL in foundURLS) { workingURLS.Add(foundURL.InnerText.Trim(), $"https://minecraft.curseforge.com{foundURL.Attributes["href"].Value.Trim()}"); }
                } else {
                    IsCompiling(false);
                    ShowMessage("There was a HTTP status error while processing the links", $"Server response was '{htmlWeb.StatusCode.ToString()}'. Can not continue compiling the changelog.");
                    return;
                }
            } catch (Exception ex) {
                IsCompiling(false);
                ShowMessage("There was an error while processing the links", ex.Message);
                return;
            }

            CompilingProgressBar.Style = ProgressBarStyle.Blocks;
            CompilingProgressBar.Maximum = workingURLS.Count;

            foreach (KeyValuePair<string, string> url in workingURLS) {
                ShowMessage("Compiling...", $"Processing <a href=\"{url.Value}\">{url.Key}</a>");
                Application.DoEvents();

                try {
                    HtmlWeb htmlWeb = new HtmlWeb() { UserAgent = UserAgent };
                    HtmlAgilityPack.HtmlDocument tempHTML = htmlWeb.Load(url.Value);

                    if (htmlWeb.StatusCode == HttpStatusCode.OK) {
                        HtmlNode node = tempHTML.DocumentNode;

                        string changelog = node.SelectSingleNode(Filters.XPaths.ChangelogCompiler.Log).OuterHtml.Trim();
                        changelog = HtmlEntity.DeEntitize(changelog);
                        workingChangelogs.Add(url.Key, (url.Value, changelog));
                    } else {
                        CompilingProgressBar.Visible = false;
                        ShowMessage("There was a HTTP status error while processing a link", $"Server response was '{htmlWeb.StatusCode.ToString()}'. Can not continue compiling the changelog.");
                        GameVersionsComboBox.Enabled = true;
                        ModURLTextBox.Enabled = true;
                        CompileButton.Enabled = true;
                        ViewSourceLinkLabel.Enabled = true;
                        return;
                    }
                } catch (Exception ex) {
                    IsCompiling(false);
                    ShowMessage("There was an error while processing a link", ex.Message);      
                    return;
                }

                CompilingProgressBar.Value = (CompilingProgressBar.Value + 1);
            }

            if (workingURLS.Count != 0) {
                foreach (KeyValuePair<string, (string link, string html)> changelog in workingChangelogs) {
                    changelogBuilder.AppendLine($"<a href=\"{changelog.Value.link}\"><h3 class=\"exclude\">{changelog.Key}</h3 class=\"exclude\"></a>");
                    changelogBuilder.AppendLine(changelog.Value.html);
                }

                changelogBuilder = changelogBuilder.Replace("<h1>", string.Empty);
                changelogBuilder = changelogBuilder.Replace("</h1>", string.Empty);
                changelogBuilder = changelogBuilder.Replace("<h2>", string.Empty);
                changelogBuilder = changelogBuilder.Replace("</h2>", string.Empty);
                changelogBuilder = changelogBuilder.Replace("<h3>", string.Empty);
                changelogBuilder = changelogBuilder.Replace("</h3>", string.Empty);
                changelogBuilder = changelogBuilder.Replace("<pre>", string.Empty);
                changelogBuilder = changelogBuilder.Replace("</pre>", string.Empty);
                changelogBuilder = changelogBuilder.Replace("<b>", string.Empty);
                changelogBuilder = changelogBuilder.Replace("</b>", string.Empty);
                changelogBuilder = changelogBuilder.Replace("<strong>", string.Empty);
                changelogBuilder = changelogBuilder.Replace("</strong>", string.Empty);
                changelogBuilder = changelogBuilder.Replace("<p>", string.Empty);
                changelogBuilder = changelogBuilder.Replace("</p>", string.Empty);

                HTMLWebBrowser.DocumentText = Properties.Resources.ChangelogCompiler_HTML_Changelog.Replace("%CHANGELOG%", changelogBuilder.ToString());
            } else {
                ShowMessage("No changelogs found", "Or there were no supported game versions. Double check the Mod URL you entered.");
            }

            IsCompiling(false);
        }

        private void ViewSourceLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            if (ViewSourceLinkLabel.Text == "View Source") {
                ViewSourceLinkLabel.Text = "Normal View";
                SourceTextBox.BringToFront();
            } else if (ViewSourceLinkLabel.Text == "Normal View") {
                ViewSourceLinkLabel.Text = "View Source";
                SourceTextBox.SendToBack();
            }
        }

        private void HTMLWebBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e) {
            for (int i = 0; i < HTMLWebBrowser.Document.Links.Count; i++) { HTMLWebBrowser.Document.Links[i].Click += new HtmlElementEventHandler(HTMLWebBrowser_LinkClicked); }
            SourceTextBox.Text = HTMLWebBrowser.DocumentText;
        }

        private void HTMLWebBrowser_Navigating(object sender, WebBrowserNavigatingEventArgs e) {
            if (_LinkClickHandled) { e.Cancel = true; _LinkClickHandled = false; }
        }

        private bool _LinkClickHandled = false;
        private void HTMLWebBrowser_LinkClicked(object sender, EventArgs e) {
            _LinkClickHandled = true;

            HtmlElement element = ((HtmlElement)sender);
            string id = element.Id;
            string href = element.GetAttribute("href");

            try { Process.Start(href); } catch { }
        }

        private void IsCompiling(bool isCompiling) {
            if (isCompiling) {
                if (ViewSourceLinkLabel.Text == "Normal View") { ViewSourceLinkLabel_LinkClicked(null, null); }
                CompilingProgressBar.Style = ProgressBarStyle.Marquee;
                CompilingProgressBar.Value = 0;
                CompilingProgressBar.Visible = true;
                GameVersionsComboBox.Enabled = false;
                ModURLTextBox.Enabled = false;
                CompileButton.Enabled = false;
                ViewSourceLinkLabel.Enabled = false;
            } else if (!isCompiling) {
                CompilingProgressBar.Visible = false;
                GameVersionsComboBox.Enabled = true;
                ModURLTextBox.Enabled = true;
                CompileButton.Enabled = true;
                ViewSourceLinkLabel.Enabled = true;
            }
            Application.DoEvents();
        }

        private void ShowMessage(string title, string message = "") {
            string workingHTML = Properties.Resources.ChangelogCompiler_HTML_Message;
            workingHTML = workingHTML.Replace("%TITLE%", title);
            workingHTML = workingHTML.Replace("%MESSAGE%", message);
            HTMLWebBrowser.DocumentText = workingHTML;
        }

    }

}
