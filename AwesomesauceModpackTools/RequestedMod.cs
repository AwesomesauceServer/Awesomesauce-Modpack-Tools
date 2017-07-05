using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace AwesomesauceModpackTools {

    public class RequestedMod {

        /// <summary>
        /// <see cref="AwesomesauceModpackTools.Status" /> of the mod request.
        /// </summary>
        [JsonProperty(PropertyName = "Status", Order = 1)]
        [JsonConverter(typeof(StatusConverter))]
        public Status Status { get; set; }

        /// <summary>
        /// Timestamp of when the mod was requested
        /// </summary>
        [JsonProperty("Timestamp", Order = 2)]
        [JsonConverter(typeof(IsoDateTimeConverter))]
        public DateTime Timestamp { get; set; }

        /// <summary>
        /// Minecraft username of who submitted the request.
        /// </summary>
        [JsonProperty(PropertyName = "Minecraft Username", Order = 3)]
        public string Username { get; set; }

        /// <summary>
        /// Link to the mod that was requested.
        /// </summary>
        [JsonProperty(PropertyName = "Mod", Order = 4)]
        public string Mod { get; set; }

        /// <summary>
        /// Why do you want this mod?
        /// </summary>
        [JsonProperty(PropertyName = "Why do you want this mod?", Order = 5)]
        public string Why { get; set; }

        /// <summary>
        /// Notes about the status of the request.
        /// </summary>
        [JsonProperty(PropertyName = "Notes", Order = 6)]
        public string Notes { get; set; }
    }

}
