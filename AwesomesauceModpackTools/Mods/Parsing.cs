﻿using System;
using System.Net;
using HtmlAgilityPack;
using static AwesomesauceModpackTools.Utilities;
using static AwesomesauceModpackTools.Utilities.Storage;

namespace AwesomesauceModpackTools.Mods {

    public static class Parsing {

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

                    mod.Name = node.SelectSingleNode(Filters.XPaths.Parsing.Info.Name).InnerText.Trim();
                    mod.File = node.SelectSingleNode(Filters.XPaths.Parsing.Info.File).InnerText.Trim();
                    mod.Date = EpochConverter(node.SelectSingleNode(Filters.XPaths.Parsing.Info.Date).Attributes["data-epoch"].Value.Trim());
                    mod.Size = node.SelectSingleNode(Filters.XPaths.Parsing.Info.Size).InnerText.Trim();
                    mod.MD5 = node.SelectSingleNode(Filters.XPaths.Parsing.Info.MD5).InnerText.Trim();

                    ReleaseType releaseType = ReleaseType.MostRecent;
                    Enum.TryParse(node.SelectSingleNode(Filters.XPaths.Parsing.Info.ReleaseType).Attributes["title"].Value.Trim(), out releaseType);
                    mod.ReleaseType = releaseType;

                    if (mod.MinecraftVersion.Count != 0) { mod.MinecraftVersion.Clear(); }
                    HtmlNodeCollection minecraftVersions = node.SelectNodes(Filters.XPaths.Parsing.Info.Versions);
                    foreach (HtmlNode minectaftVersion in minecraftVersions) { mod.MinecraftVersion.Add(HtmlEntity.DeEntitize(minectaftVersion.InnerText.Trim())); }

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
        /// <param name="gameVersion">Game version to filter the page by. e.g. <see cref="Minecraft.GameVersions"/></param>
        /// <returns><see cref="Mod"/> and <see cref="Exception"/>. If there was a exception, <see cref="Mod"/> will be null; if there was no exception, <see cref="Exception"/> will be null.</returns>
        public static (Mod Mod, Exception Exception) ParseForUpdate(Mod mod, string gameVersion, ReleaseType releaseType) {
            try {
                HtmlWeb htmlWeb = new HtmlWeb() { UserAgent = UserAgent };
                mod.HTML_Files = htmlWeb.Load($"{mod.Link_Files}{gameVersion}");

                if (htmlWeb.StatusCode == HttpStatusCode.OK) {
                    HtmlNode node = mod.HTML_Files.DocumentNode;

                    //string modURL = node.SelectSingleNode(Filters.XPaths.Parsing.Update.URL).Attributes["href"].Value.Trim();

                    string modURL = string.Empty;
                    if (releaseType == ReleaseType.Alpha) {
                        try {
                            modURL = node.SelectSingleNode(Filters.XPaths.Parsing.Update.Alpha).Attributes["href"].Value.Trim();
                        } catch { modURL = string.Empty; }
                    } else if (releaseType == ReleaseType.Beta) {
                        try {
                            modURL = node.SelectSingleNode(Filters.XPaths.Parsing.Update.Beta).Attributes["href"].Value.Trim();
                        } catch { modURL = string.Empty; }
                    } else if (releaseType == ReleaseType.Release) {
                        try {
                            modURL = node.SelectSingleNode(Filters.XPaths.Parsing.Update.Release).Attributes["href"].Value.Trim();
                        } catch { modURL = string.Empty; }
                    } else {
                        try {
                            modURL = node.SelectSingleNode(Filters.XPaths.Parsing.Update.URL).Attributes["href"].Value.Trim();
                        } catch { modURL = string.Empty; }
                    }

                    if (modURL != string.Empty) {
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
