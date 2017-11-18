using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace AwesomesauceModpackTools {

    /// <summary>
    /// General utilities that do not fit anywhere else.
    /// </summary>
    public static partial class Utilities {

        /// <summary>
        /// Contains general shared data and data generated from <see cref="Utilities"/>.
        /// </summary>
        public static class Storage  {

            /// <summary>
            /// URI to download the modpack list info from.
            /// </summary>
            public static Uri ModpackList_URI = new Uri("https://raw.githubusercontent.com/AwesomesauceServer/Awesomesauce-Modpack/master/packs.json");

            /// <summary>
            /// URI to download the current filters from.
            /// </summary>
            public static Uri Filters_URI = new Uri("https://raw.githubusercontent.com/AwesomesauceServer/Awesomesauce-Modpack-Tools/master/filters.json");

            private static string _AppName = "Awesomesauce-Modpack-Tools";
            /// <summary>
            /// The programs name.
            /// </summary>
            public static string AppName => _AppName;

            private static string _EXELocation = Process.GetCurrentProcess().MainModule.FileName;
            /// <summary>
            /// Current location (including filename and extension) of the running executable.
            /// </summary>
            public static string EXELocation => _EXELocation;

            private static string _EXEDirectory = Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName);
            /// <summary>
            /// Current directory of the running executable.
            /// </summary>
            public static string EXEDirectory => _EXEDirectory;

            private static string _UserAgent = $"{AppName}/{Version.Parse(System.Windows.Forms.Application.ProductVersion).ToString(3)} ({Environment.OSVersion}; {((Environment.Is64BitOperatingSystem) ? "x64" : "x86")}) [https://git.io/vQ6dQ]";
            /// <summary>
            /// The programs user-agent.
            /// </summary>
            public static string UserAgent => _UserAgent;

            private static List<Pack> _ModpackList = new List<Pack>();
            /// <summary>
            /// Modpack list downloaded from GitHub at startup.
            /// </summary>
            public static List<Pack> ModpackList { get => _ModpackList; set => _ModpackList = value; }

            private static bool _HasInternet = HasInternetConnection();
            /// <summary>
            /// Value of <see cref="HasInternetConnection()"/>.
            /// </summary>
            public static bool HasInternet => _HasInternet;

            private static string _GithubCredentials = SetupGithubCredentials();
            /// <summary>
            /// Value of <see cref="SetupGithubCredentials()"/>.
            /// </summary>
            public static string GithubCredentials => _GithubCredentials;

        }

    }

}
