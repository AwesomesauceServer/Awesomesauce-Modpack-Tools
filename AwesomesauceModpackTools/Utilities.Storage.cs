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
            
            /// <summary>
            /// The programs name.
            /// </summary>
            public static string AppName { get; } = "Awesomesauce-Modpack-Tools";

            /// <summary>
            /// Current location (including filename and extension) of the running executable.
            /// </summary>
            public static string EXELocation { get; } = Process.GetCurrentProcess().MainModule.FileName;

            /// <summary>
            /// Current directory of the running executable.
            /// </summary>
            public static string EXEDirectory { get; } = Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName);

            /// <summary>
            /// The programs user-agent.
            /// </summary>
            public static string UserAgent { get; } = $"{AppName}/{Version.Parse(System.Windows.Forms.Application.ProductVersion).ToString(3)} (compatible; {Environment.OSVersion.ToString().Replace("Microsoft ", string.Empty)}; {((Environment.Is64BitOperatingSystem) ? "x64" : "x86")}; Trident/7.0) (+https://git.io/vQ6dQ)";

            /// <summary>
            /// Modpack list downloaded from GitHub at startup.
            /// </summary>
            public static List<Pack> ModpackList { get; set; } = new List<Pack>();

            /// <summary>
            /// Value of <see cref="HasInternetConnection()"/>.
            /// </summary>
            public static bool HasInternet { get; } = HasInternetConnection();

            /// <summary>
            /// Value of <see cref="SetupGithubCredentials()"/>.
            /// </summary>
            public static string GithubCredentials { get; } = SetupGithubCredentials();

            /// <summary>
            /// Common color for status notifications and controls.
            /// </summary>
            public static StatusColors StatusColor { get; } = new StatusColors();

        }

    }

}
