using System;
using Newtonsoft.Json;

namespace AwesomesauceModpackTools {

    /// <summary>
    /// Modpack information downloaded from GitHub.
    /// </summary>
    public class Pack {

        /// <summary>
        /// Name of the pack.
        /// </summary>
        [JsonProperty(PropertyName = "name", Order = 1)]
        public string Name { get; set; }

        /// <summary>
        /// ID (guid, as string) of the pack.
        /// </summary>
        [JsonProperty(PropertyName = "id", Order = 2)]
        public string ID { get; set; } = Guid.NewGuid().ToString();

        /// <summary>
        /// Minecraft version.
        /// </summary>
        [JsonProperty(PropertyName = "minecraftVersion", Order = 3)]
        public string MinecraftVersion { get; set; }

        /// <summary>
        /// Pack number.
        /// </summary>
        [JsonProperty(PropertyName = "packNumber", Order = 4)]
        public string PackNumber { get; set; }

        /// <summary>
        /// URL of the mod list.
        /// </summary>
        [JsonProperty(PropertyName = "modListURL", Order = 5)]
        public string ModListURL { get; set; }

        /// <summary>
        /// URL of the repository.
        /// </summary>
        [JsonProperty(PropertyName = "repositoryURL", Order = 6)]
        public string RepositoryURL { get; set; }

        public override string ToString() {
            return Name;
        }

    }

}
