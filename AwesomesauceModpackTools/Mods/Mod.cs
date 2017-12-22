using System;
using System.Collections.Generic;
using HtmlAgilityPack;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace AwesomesauceModpackTools.Mods {

    /// <summary>
    /// A single Minecraft mod.
    /// </summary>
    public class Mod {

        /// <summary>
        /// Name of the mod.
        /// </summary>
        [JsonProperty(PropertyName = "name", Order = 1)]
        public string Name { get; set; }

        /// <summary>
        /// ID (guid, as string) of the mod.
        /// </summary>
        [JsonProperty(PropertyName = "id", Order = 2)]
        public string ID { get; set; } = Guid.NewGuid().ToString();

        /// <summary>
        /// File name.
        /// </summary>
        [JsonProperty(PropertyName = "file", Order = 3)]
        public string File { get; set; }

        /// <summary>
        /// <see cref="AwesomesauceModpackTools.Side" /> that the mod is required.
        /// </summary>
        [JsonProperty(PropertyName = "side", Order = 4)]
        [JsonConverter(typeof(StringEnumConverter))]
        public Side Side { get; set; }

        /// <summary>
        /// Posted date and time.
        /// </summary>
        [JsonProperty(PropertyName = "date", Order = 5)]
        public DateTime Date { get; set; }

        /// <summary>
        /// File size.
        /// </summary>
        [JsonProperty(PropertyName = "size", Order = 6)]
        public string Size { get; set; }

        /// <summary>
        /// Mods needed to work. List of <see cref="RequiredMod" />.
        /// </summary>
        [JsonProperty(PropertyName = "requires", Order = 7, NullValueHandling = NullValueHandling.Include)]
        public List<RequiredMod> Requires { get; set; } = new List<RequiredMod>();

        /// <summary>
        /// Link to the mods website.
        /// </summary>
        [JsonProperty(PropertyName = "link", Order = 8)]
        public string Link { get; set; }

        /// <summary>
        /// Download link to the mod file.
        /// </summary>
        [JsonProperty(PropertyName = "linkDownload", Order = 9)]
        public string Link_Download { get; set; }

        /// <summary>
        /// Mod files link.
        /// </summary>
        [JsonProperty(PropertyName = "linkFiles", Order = 10)]
        public string Link_Files { get; set; }

        /// <summary>
        /// MD5 of the mod file.
        /// </summary>
        [JsonProperty(PropertyName = "md5", Order = 11)]
        public string MD5 { get; set; }

        /// <summary>
        /// List of supported minecraft versions.
        /// </summary>
        [JsonProperty(PropertyName = "minecraftVersion", Order = 12, NullValueHandling = NullValueHandling.Include)]
        public List<string> MinecraftVersion { get; set; } = new List<string>();

        /// <summary>
        /// <see cref="AwesomesauceModpackTools.UpdateMode" /> of the mod.
        /// </summary>
        [JsonProperty(PropertyName = "updateMode", Order = 13)]
        [JsonConverter(typeof(StringEnumConverter))]
        public UpdateMode UpdateMode { get; set; }

        /// <summary>
        /// Notes about the mod.
        /// </summary>
        [JsonProperty(PropertyName = "notes", Order = 14, NullValueHandling = NullValueHandling.Ignore)]
        public string Notes { get; set; }

        /// <summary>
        /// <see cref="HtmlDocument"/> of the <see cref="Link"/> fetch.
        /// </summary>
        [JsonIgnore]
        public HtmlDocument HTML_Link { get; set; }

        /// <summary>
        /// <see cref="HtmlDocument"/> of the <see cref="Link_Files"/> fetch.
        /// </summary>
        [JsonIgnore]
        public HtmlDocument HTML_Files { get; set; }

        /// <summary>
        /// Format the <see cref="Requires" /> list into a sting.
        /// </summary>
        /// <returns><see cref="Requires" /> as a single line, comma seperated string.</returns>
        public string RequiresToString() {
            string working = string.Empty;
            foreach (RequiredMod required in Requires) {
                working += $"{required.Name}, ";
            }
            working = working.Trim();
            if (working.EndsWith(",")) { working = working.Remove(working.Length - 1); }
            return working;
        }

        /// <summary>
        /// Format the <see cref="MinecraftVersion" /> list into a sting.
        /// </summary>
        /// <returns><see cref="MinecraftVersion" /> as a single line, comma seperated string.</returns>
        public string MinecraftVersionToString() {
            string working = string.Empty;
            foreach (string version in MinecraftVersion) {
                working += $"{version}, ";
            }
            working = working.Trim();
            if (working.EndsWith(",")) { working = working.Remove(working.Length - 1); }
            return working;
        }

    }

}
