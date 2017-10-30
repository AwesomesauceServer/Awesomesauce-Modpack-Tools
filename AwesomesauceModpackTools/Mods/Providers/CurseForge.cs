using System;
using System.Net;
using HtmlAgilityPack;
using static AwesomesauceModpackTools.Utilities;
using static AwesomesauceModpackTools.Utilities.Storage;

namespace AwesomesauceModpackTools.Mods.Providers {

    public static class CurseForge {

        private static string _GameVersion1122 = "?filter-game-version=2020709689%3A6756";
        /// <summary>
        /// Minecraft game version. 1.12.2
        /// </summary>
        public static string GameVersion1122 { get => _GameVersion1122; }

        private static string _GameVersion112 = "?filter-game-version=2020709689%3A6580";
        /// <summary>
        /// Minecraft game version. 1.12
        /// </summary>
        public static string GameVersion112 { get => _GameVersion112; }

        private static string _GameVersion1112 = "?filter-game-version=2020709689%3A6452";
        /// <summary>
        /// Minecraft game version. 1.11.2
        /// </summary>
        public static string GameVersion1112 { get => _GameVersion1112; }

        private static string _GameVersion1102 = "?filter-game-version=2020709689%3A6170";
        /// <summary>
        /// Minecraft game version. 1.10.2
        /// </summary>
        public static string GameVersion1102 { get => _GameVersion1102; }

        /// <summary>
        /// Parse a CurseForge mod page for information.
        /// </summary>
        /// <param name="mod">Initialized <see cref="Mod"/> with a set <see cref="Mod.Link"/>.</param>
        /// <returns><see cref="Mod"/> and <see cref="Exception"/>. If there was a exception, <see cref="Mod"/> will be null; if there was no exception, <see cref="Exception"/> will be null.</returns>
        public static (Mod Mod, Exception Exception) ParseForInfo(Mod mod) {
            try {
                HtmlWeb htmlWeb = new HtmlWeb() { UserAgent = UserAgent };
                mod.HTML_Link = htmlWeb.Load(mod.Link);

                if (htmlWeb.StatusCode == HttpStatusCode.OK) {
                    HtmlNode node = mod.HTML_Link.DocumentNode;

                    mod.Name = node.SelectSingleNode("//span[@class='overflow-tip']").InnerText.Trim();
                    mod.File = node.SelectSingleNode("//div[@class='details-info']/ul/li[1]/div[@class='info-data overflow-tip']").InnerText.Trim();
                    mod.Date = EpochConverter(node.SelectSingleNode("//div[@class='details-info']/ul/li[3]/div[@class='info-data']/abbr[@class='tip standard-date standard-datetime']").Attributes["data-epoch"].Value.Trim());
                    mod.Size = node.SelectSingleNode("//div[@class='details-info']/ul/li[4]/div[@class='info-data']").InnerText.Trim();
                    mod.MD5 = node.SelectSingleNode("//div[@class='details-info']/ul/li[6]/div[@class='info-data']/span[@class='md5']").InnerText.Trim();

                    mod.Link = HtmlEntity.DeEntitize(mod.Link);
                    mod.Name = HtmlEntity.DeEntitize(mod.Name);
                    mod.File = HtmlEntity.DeEntitize(mod.File);
                    mod.Size = HtmlEntity.DeEntitize(mod.Size);
                    mod.MD5 = HtmlEntity.DeEntitize(mod.MD5);

                    mod.Link_Download = $"{mod.Link}/download";
                    mod.Link_Files = GetParentURL(mod.Link);

                    return (mod, null);
                } else {
                    return (null, new HtmlWebException($"HTTP returned status ({(int)htmlWeb.StatusCode}) {htmlWeb.StatusCode}."));
                }
            } catch (Exception ex) {
                return (null, ex);
            }
        }

        /// <summary>
        /// Parse a CurseForge file list page for information.
        /// </summary>
        /// <param name="mod">Initialized <see cref="Mod"/> with a set <see cref="Mod.Link"/>.</param>
        /// <param name="gameVersion">Game version to filter the page by. e.g. <see cref="GameVersion1112"/></param>
        /// <returns><see cref="Mod"/> and <see cref="Exception"/>. If there was a exception, <see cref="Mod"/> will be null; if there was no exception, <see cref="Exception"/> will be null.</returns>
        public static (Mod Mod, Exception Exception) ParseForUpdate(Mod mod, string gameVersion) {
            try {
                HtmlWeb htmlWeb = new HtmlWeb() { UserAgent = UserAgent };
                mod.HTML_Files = htmlWeb.Load($"{mod.Link_Files}{gameVersion}");

                if (htmlWeb.StatusCode == HttpStatusCode.OK) {
                    HtmlNode node = mod.HTML_Files.DocumentNode;

                    string modURL = node.SelectSingleNode("(//div/div[@class='project-file-name-container']/a[@class='overflow-tip twitch-link'])[1]").Attributes["href"].Value.Trim();

                    if (modURL != "") {
                        mod.Link = $"https://minecraft.curseforge.com{modURL}";
                        mod = ParseForInfo(mod).Mod;

                        return (mod, null);
                    } else {
                        return (mod, null);
                    }
                } else {
                    return (null, new HtmlWebException($"HTTP returned status ({(int)htmlWeb.StatusCode}) {htmlWeb.StatusCode}."));
                }
            } catch (Exception ex) {
                return (null, ex);
            }
        }

        /// <summary>
        /// Get the redirected url of a download.
        /// </summary>
        /// <param name="url">Inital URL of the request.</param>
        /// <returns>Direct link to the file; or null if <see cref="Exception"/>.</returns>
        public static string GetDirectDownload(string url) {
            try {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.AllowAutoRedirect = false;

                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                string location = response.Headers["Location"];
                response.Close();

                return location;
            } catch {
                return null;
            }
        }

    }
}
