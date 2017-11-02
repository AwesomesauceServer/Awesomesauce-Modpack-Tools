﻿using System;
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

        public ChangelogCompilerForm() {
            InitializeComponent();
            Icon = Properties.Resources.AwesomesauceIcon;

            HTMLWebBrowser.DocumentText = Properties.Resources.ChangelogCompiler_HTML_Default;
            GameVersionsComboBox.Items.AddRange(Minecraft.GameVersions.Keys.ToArray());
        }

        private void ChangelogCompilerForm_Load(object sender, EventArgs e) {

        }

        private void CompileButton_Click(object sender, EventArgs e) {
            CompilingProgressBar.Style = ProgressBarStyle.Marquee;
            CompilingProgressBar.Value = 0;
            CompilingProgressBar.Visible = true;
            ShowMessage("Compiling...");
            GameVersionsComboBox.Enabled = false;
            ModURLTextBox.Enabled = false;
            CompileButton.Enabled = false;

            ModURLTextBox.Text = RemoveURLQueryString(ModURLTextBox.Text.Trim());
            if (ModURLTextBox.Text.EndsWith("/")) { ModURLTextBox.Text = ModURLTextBox.Text.Remove(ModURLTextBox.Text.Length - 1, 1); }
            if (ModURLTextBox.Text.EndsWith("/files")) { ModURLTextBox.Text = ModURLTextBox.Text.Remove(ModURLTextBox.Text.Length - 6, 6); }
            Dictionary<string, string> workingURLS = new Dictionary<string, string>();
            Dictionary<string, (string link, string html)> workingChangelogs = new Dictionary<string, (string link, string html)>();
            StringBuilder changelogBuilder = new StringBuilder();

            try {
                ShowMessage("Compiling...", "Gathering a list of links");

                HtmlWeb htmlWeb = new HtmlWeb() { UserAgent = UserAgent };
                HtmlAgilityPack.HtmlDocument tempHTML = htmlWeb.Load($"{ModURLTextBox.Text}/files{Minecraft.GameVersions[(string)GameVersionsComboBox.SelectedItem]}");

                if (htmlWeb.StatusCode == HttpStatusCode.OK) {
                    HtmlNode node = tempHTML.DocumentNode;

                    HtmlNodeCollection foundURLS = node.SelectNodes("(//div/div[@class='project-file-name-container']/a[@class='overflow-tip twitch-link'])");
                    foreach (HtmlNode foundURL in foundURLS) { workingURLS.Add(foundURL.InnerText.Trim(), $"https://minecraft.curseforge.com{foundURL.Attributes["href"].Value.Trim()}"); }
                } else {
                    CompilingProgressBar.Visible = false;
                    ShowMessage("There was a HTTP status error while processing the links", $"Server response was '{htmlWeb.StatusCode.ToString()}'. Can not continue.");
                    GameVersionsComboBox.Enabled = true;
                    ModURLTextBox.Enabled = true;
                    CompileButton.Enabled = true;
                    return;
                }
            } catch (Exception ex) {
                CompilingProgressBar.Visible = false;
                ShowMessage("There was an error while processing the links", ex.Message);
                GameVersionsComboBox.Enabled = true;
                ModURLTextBox.Enabled = true;
                CompileButton.Enabled = true;
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

                        string changelog = node.SelectSingleNode("//div[@class='details-content']/section[@class='details-changelog']/div[@class='logbox']").OuterHtml.Trim();
                        changelog = HtmlEntity.DeEntitize(changelog);
                        workingChangelogs.Add(url.Key, (url.Value, changelog));
                    } else {
                        CompilingProgressBar.Visible = false;
                        ShowMessage("There was a HTTP status error while processing a link", $"Server response was '{htmlWeb.StatusCode.ToString()}'. Can not continue.");
                        GameVersionsComboBox.Enabled = true;
                        ModURLTextBox.Enabled = true;
                        CompileButton.Enabled = true;
                        return;
                    }
                } catch (Exception ex) {
                    CompilingProgressBar.Visible = false;
                    ShowMessage("There was an error while processing a link", ex.Message);
                    GameVersionsComboBox.Enabled = true;
                    ModURLTextBox.Enabled = true;
                    CompileButton.Enabled = true;
                }

                CompilingProgressBar.Value = (CompilingProgressBar.Value + 1);
            }

            foreach (KeyValuePair<string, (string link, string html)> changelog in workingChangelogs) {
                changelogBuilder.AppendLine($"<a href=\"{changelog.Value.link}\"><h3 class=\"exclude\">{changelog.Key}</h3 class=\"exclude\"></a>");
                changelogBuilder.AppendLine(changelog.Value.html);
            }

            changelogBuilder = changelogBuilder.Replace("<h1>", "");
            changelogBuilder = changelogBuilder.Replace("</h1>", "");
            changelogBuilder = changelogBuilder.Replace("<h2>", "");
            changelogBuilder = changelogBuilder.Replace("</h2>", "");
            changelogBuilder = changelogBuilder.Replace("<h3>", "");
            changelogBuilder = changelogBuilder.Replace("</h3>", "");
            changelogBuilder = changelogBuilder.Replace("<pre>", "");
            changelogBuilder = changelogBuilder.Replace("</pre>", "");
            changelogBuilder = changelogBuilder.Replace("<b>", "");
            changelogBuilder = changelogBuilder.Replace("</b>", "");
            changelogBuilder = changelogBuilder.Replace("<strong>", "");
            changelogBuilder = changelogBuilder.Replace("</strong>", "");

            HTMLWebBrowser.DocumentText = Properties.Resources.ChangelogCompiler_HTML_Changelog.Replace("%CHANGELOG%", changelogBuilder.ToString());

            CompilingProgressBar.Visible = false;
            GameVersionsComboBox.Enabled = true;
            ModURLTextBox.Enabled = true;
            CompileButton.Enabled = true;
        }

        private void HTMLWebBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e) {
            for (int i = 0; i < HTMLWebBrowser.Document.Links.Count; i++) { HTMLWebBrowser.Document.Links[i].Click += new HtmlElementEventHandler(HTMLWebBrowser_LinkClicked); }
        }

        private void HTMLWebBrowser_Navigating(object sender, WebBrowserNavigatingEventArgs e) {
            if (_LinkClickHandled == true) { e.Cancel = true; _LinkClickHandled = false; }
        }

        private bool _LinkClickHandled = false;
        private void HTMLWebBrowser_LinkClicked(object sender, EventArgs e) {
            _LinkClickHandled = true;

            HtmlElement element = ((HtmlElement)sender);
            string id = element.Id;
            string href = element.GetAttribute("href");

            try { Process.Start(href); } catch { }
        }

        private void ShowMessage(string title, string message = "") {
            string workingHTML = Properties.Resources.ChangelogCompiler_HTML_Message;
            workingHTML = workingHTML.Replace("%TITLE%", title);
            workingHTML = workingHTML.Replace("%MESSAGE%", message);
            HTMLWebBrowser.DocumentText = workingHTML;
        }

    }

}
