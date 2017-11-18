using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography;

namespace AwesomesauceModpackTools {

    /// <summary>
    /// General utilities that do not fit anywhere else.
    /// </summary>
    public static partial class Utilities {

        /// <summary>
        /// Search a list of mods for an exact <see cref="Mod.ID" />.
        /// </summary>
        /// <param name="modID"><see cref="Mod.ID" /> to find.</param>
        /// <param name="modList">List of mods to search.</param>
        /// <returns><see cref="Mod" />; if nothing was found then null.</returns>
        public static Mods.Mod FindModByID(string modID, List<Mods.Mod> modList) {
            if (modList.Exists(mod => mod.ID == modID)) {
                return modList.Find(mod => mod.ID == modID);
            } else {
                return null;
            }
        }

        /// <summary>
        /// Search a list of packs for an exact <see cref="Downloader.Pack.ID" />.
        /// </summary>
        /// <param name="packID"><see cref="Downloader.Pack.ID" /> to find.</param>
        /// <param name="packList">List of packs to search.</param>
        /// <returns><see cref="Downloader.Pack" />; if nothing was found then null.</returns>
        public static Pack FindPackByID(string packID, List<Pack> packList) {
            if (packList.Exists(pack => pack.ID == packID)) {
                return packList.Find(pack => pack.ID == packID);
            } else {
                return null;
            }
        }

        /// <summary>
        /// Unix epoch time string to <see cref="DateTime" />.
        /// </summary>
        /// <param name="unixTime">Unix epoch time string.</param>
        /// <returns><see cref="DateTime" />.</returns>
        public static DateTime EpochConverter(string unixTime) {
            long unixTimeLong = long.Parse(unixTime);

            DateTime epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            return epoch.AddSeconds(unixTimeLong);
        }

        /// <summary>
        /// Get parent of the full URL.
        /// </summary>
        /// <param name="url">The complete URL.</param>
        /// <returns><see cref="string" />.</returns>
        public static string GetParentURL(string url) {
            Uri uri = new Uri(url);
            string working = uri.AbsoluteUri.Remove(uri.AbsoluteUri.Length - uri.Segments.Last().Length).Trim();
            if (working.EndsWith("/")) { working = working.Remove(working.Length - 1); }
            return working;
        }

        /// <summary>
        /// Determine if the URL is a valid URL. It must contain the protocol to be valid e.g. http.
        /// </summary>
        /// <param name="url">The complete URL.</param>
        /// <param name="kind">What type of the url is it?</param>
        /// <returns>True if valid; False if anything else.</returns>
        public static bool IsValidURL(string url, UriKind kind) {
            return Uri.IsWellFormedUriString(url, kind);
        }

        /// <summary>
        /// Gets the domain (host) part of the url.
        /// </summary>
        /// <param name="url">The complete URL.</param>
        /// <returns>www.google.com part of https://www.google.com/search?q=example</returns>
        public static string GetDomainFromURL(string url) {
            Uri uri = new Uri(url);
            return uri.Host;
        }

        /// <summary>
        /// Check if the URL is a match to the domain (host) supplied.
        /// </summary>
        /// <param name="url">The complete URL.</param>
        /// <param name="domain">Domain to match the URL against.</param>
        /// <returns>True if the URL contains the domain; False if anything else.</returns>
        public static bool URLContainsDomain(string url, string domain) {
            try {
                Uri uri = new Uri(url);
                return (uri.Host == domain);
            } catch {
                return false;
            }
        }

        /// <summary>
        /// Removes the query string from a URL.
        /// </summary>
        /// <param name="url">The complete URL.</param>
        /// <returns>www.google.com/search part of https://www.google.com/search?q=example</returns>
        public static string RemoveURLQueryString(string url) {
            Uri uri = new Uri(url);
            return $"{uri.Scheme}{Uri.SchemeDelimiter}{uri.Authority}{uri.AbsolutePath}";
        }

        /// <summary>
        /// MD5 hash a local file.
        /// </summary>
        /// <param name="file">Path to the file.</param>
        /// <returns>MD5 hash if successful; empty string if error.</returns>
        public static string MD5File(string file) {
            try {
                using (MD5 md5 = MD5.Create()) {
                    using (FileStream stream = File.OpenRead(file)) {
                        return string.Concat(md5.ComputeHash(stream).Select(x => x.ToString("x2")));
                    }
                }
            } catch {
                return "";
            }
        }

        /// <summary>
        /// Deletes a local file.
        /// </summary>
        /// <param name="file">Path to the file.</param>
        /// <returns>True if deleted; False if anything else.</returns>
        public static bool DeleteFile(string file) {
            try {
                if (File.Exists(file)) { File.Delete(file); }
                if (!File.Exists(file)) {
                    return true;
                } else {
                    return false;
                }
            } catch {
                return false;
            }
        }

        /// <summary>
        /// Try to connect to Google.
        /// </summary>
        /// <returns>True if has internet connection; False if connection failed or any exceptions.</returns>
        public static bool HasInternetConnection() {
            try {
                using (WebClient client = new WebClient()) { using (Stream stream = client.OpenRead("https://www.google.com")) { return true; } }
            } catch {
                return false;
            }
        }

        /// <summary>
        /// If there is a Github credential token file in the app directory, process it.
        /// </summary>
        /// <returns>Token if has valid file; string.Empty if no file or any exceptions.</returns>
        public static string SetupGithubCredentials() {
            try {
                string tokenFile = $@"{Storage.EXEDirectory}\github.token";
                if (File.Exists(tokenFile)) {
                    return File.ReadAllText(tokenFile);
                } else {
                    return string.Empty;
                }
            } catch {
             return string.Empty;
            }
        }

    }

}
