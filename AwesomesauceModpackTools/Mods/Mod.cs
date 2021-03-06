﻿using System;
using System.Collections.Generic;
using System.Linq;
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
        /// <see cref="Mods.Side" /> that the mod is required.
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
        /// <see cref="Mods.ReleaseType" /> (status) of the mod.
        /// </summary>
        [JsonProperty(PropertyName = "releaseType", Order = 12)]
        [JsonConverter(typeof(StringEnumConverter))]
        public ReleaseType ReleaseType { get; set; }

        /// <summary>
        /// List of supported minecraft versions.
        /// </summary>
        [JsonProperty(PropertyName = "minecraftVersion", Order = 13, NullValueHandling = NullValueHandling.Include)]
        public List<string> MinecraftVersion { get; set; } = new List<string>();

        /// <summary>
        /// <see cref="Mods.UpdateMode" /> of the mod.
        /// </summary>
        [JsonProperty(PropertyName = "updateMode", Order = 14)]
        [JsonConverter(typeof(StringEnumConverter))]
        public UpdateMode UpdateMode { get; set; }

        /// <summary>
        /// Notes about the mod.
        /// </summary>
        [JsonProperty(PropertyName = "notes", Order = 15, NullValueHandling = NullValueHandling.Ignore)]
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
        public string RequiresToString() => string.Join(", ", Requires.Select(r => r.Name).ToArray());

        /// <summary>
        /// Format the <see cref="MinecraftVersion" /> list into a sting.
        /// </summary>
        /// <returns><see cref="MinecraftVersion" /> as a single line, comma seperated string.</returns>
        public string MinecraftVersionToString() => string.Join(", ", MinecraftVersion);

    }

}
