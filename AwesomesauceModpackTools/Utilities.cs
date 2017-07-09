﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace AwesomesauceModpackTools {

    /// <summary>
    /// General utilities that do not fit anywhere else.
    /// </summary>
    public static class Utilities {

        private static string _EXELocation = Process.GetCurrentProcess().MainModule.FileName;
        /// <summary>
        /// Current location (including filename and extension) of the running executable.
        /// </summary>
        public static string EXELocation { get => _EXELocation; }

        private static string _EXEDirectory = Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName);
        /// <summary>
        /// Current directory of the running executable.
        /// </summary>
        public static string EXEDirectory { get => _EXEDirectory; }

        private static string _UserAgent = $"Awesomesauce-Modpack-Tools/{Version.Parse(System.Windows.Forms.Application.ProductVersion).ToString(3)} ({Environment.OSVersion}; {((Environment.Is64BitOperatingSystem == true) ? "x64" : "x86")}) [https://git.io/vQ6dQ]";
        /// <summary>
        /// The programs user-agent.
        /// </summary>
        public static string UserAgent { get => _UserAgent; }

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
        /// Format the supplied datetime to elapsed time.
        /// </summary>
        /// <param name="dateTime">DateTime of to process.</param>
        /// <returns>String of the formatted timespan, and the actual timespan.</returns>
        public static (string Formatted, TimeSpan TimeSpan) ElapsedTime(DateTime dateTime) {
            TimeSpan timeSpan = (DateTime.Now - dateTime);
            int intYears = (DateTime.Now.Year - dateTime.Year);
            int intMonths = (DateTime.Now.Month - dateTime.Month);
            int intDays = (DateTime.Now.Day - dateTime.Day);
            int intHours = (DateTime.Now.Hour - dateTime.Hour);
            int intMinutes = (DateTime.Now.Minute - dateTime.Minute);
            int intSeconds = (DateTime.Now.Second - dateTime.Second);

            if (intYears > 0) {
                return ($"{intYears} {((intYears == 1) ? "year" : "years")} ago", timeSpan);
            } else if (intMonths > 0) {
                return ($"{intMonths} {((intMonths == 1) ? "month" : "months")} ago", timeSpan);
            } else if (intDays > 0) {
                return ($"{intDays} {((intDays == 1) ? "day" : "days")} ago", timeSpan);
            } else if (intHours > 0) {
                return ($"{intHours} {((intHours == 1) ? "hour" : "hours")} ago", timeSpan);
            } else if (intMinutes > 0) {
                return ($"{intMinutes} {((intMinutes == 1) ? "minute" : "minutes")} ago", timeSpan);
            } else if (intSeconds > 0) {
                return ($"{intSeconds} {((intSeconds == 1) ? "second" : "seconds")} ago", timeSpan);
            } else { return ($"{ dateTime.ToShortDateString()} {dateTime.ToShortTimeString()} ago", timeSpan); }
        }

    }
}
