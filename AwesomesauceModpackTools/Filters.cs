using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using static AwesomesauceModpackTools.Utilities.Storage;

namespace AwesomesauceModpackTools {

    /// <summary>
    /// Contains all supported Minecraft game versions, and XPaths needed to parse CurseForges site.
    /// </summary>
    public static class Filters {

        private static Dictionary<string, string> _GameVersions = new Dictionary<string, string>();
        /// <summary>
        /// Dictionary of all supported Minecraft game versions. The key is the game version, value is CurseForge url filter string.
        /// </summary>
        /// <remarks>
        /// Example: [key = 1.10.2, value = ?filter-game-version=2020709689%3A6170]
        /// </remarks>
        public static Dictionary<string, string> GameVersions => _GameVersions;

        private static Filter.XPath _XPaths = new Filter.XPath();
        /// <summary>
        /// XPaths for HTML node selections.
        /// </summary>
        public static Filter.XPath XPaths => _XPaths;

        /// <summary>
        /// Download the most recent filter list from Github, if any errors fallback to embedded list.
        /// </summary>
        public static void Setup() {
            Filter tempFilters = new Filter();

            try {
                if (!HasInternet) { throw new Exception("Filters: A connection to the internet can not be established."); }

                WebClient client = new WebClient();
                client.Headers.Add("user-agent", UserAgent);
                string filterJSON = client.DownloadString(Filters_URI);

                using (StringReader jsonFile = new StringReader(filterJSON)) {
                    JsonSerializer jsonSerializer = new JsonSerializer() {
                        NullValueHandling = NullValueHandling.Include,
                        Formatting = Formatting.Indented,
                        ContractResolver = new CamelCasePropertyNamesContractResolver()
                    };
                    tempFilters = (Filter)jsonSerializer.Deserialize(jsonFile, typeof(Filter));
                }
            } catch {
                using (StringReader jsonFile = new StringReader(Properties.Resources.Filters_JSON)) {
                    JsonSerializer jsonSerializer = new JsonSerializer() {
                        NullValueHandling = NullValueHandling.Include,
                        Formatting = Formatting.Indented,
                        ContractResolver = new CamelCasePropertyNamesContractResolver()
                    };
                    tempFilters = (Filter)jsonSerializer.Deserialize(jsonFile, typeof(Filter));
                }
            }

            _GameVersions = tempFilters.GameVersions;
            _XPaths = tempFilters.XPaths;
        }

        public class Filter {

            public Dictionary<string, string> GameVersions { get; set; } = new Dictionary<string, string>();
            public XPath XPaths { get; set; } = new XPath();

            public class XPath {

                public Parsing Parsing { get; set; } = new Parsing();
                public ChangelogCompiler ChangelogCompiler { get; set; } = new ChangelogCompiler();

            }

            public class Parsing {

                public Info Info { get; set; } = new Info();
                public Update Update { get; set; } = new Update();

            }

            public class Info {

                [JsonProperty(PropertyName = "name", Order = 1)]
                public string Name { get; set; }

                [JsonProperty(PropertyName = "file", Order = 2)]
                public string File { get; set; }

                [JsonProperty(PropertyName = "date", Order = 3)]
                public string Date { get; set; }

                [JsonProperty(PropertyName = "size", Order = 4)]
                public string Size { get; set; }

                [JsonProperty(PropertyName = "md5", Order = 5)]
                public string MD5 { get; set; }

                [JsonProperty(PropertyName = "versions", Order = 6)]
                public string Versions { get; set; }

            }

            public class Update {

                [JsonProperty(PropertyName = "url", Order = 1)]
                public string URL { get; set; }

            }

            public class ChangelogCompiler {

                [JsonProperty(PropertyName = "url", Order = 1)]
                public string URL { get; set; }

                [JsonProperty(PropertyName = "log", Order = 2)]
                public string Log { get; set; }

            }

        }

    }

}
