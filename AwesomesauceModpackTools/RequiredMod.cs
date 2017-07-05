using Newtonsoft.Json;

namespace AwesomesauceModpackTools {

    public class RequiredMod {

        /// <summary>
        /// Name of the required mod.
        /// </summary>
        [JsonProperty(PropertyName = "name", Order = 1)]
        public string Name { get; set; }

        /// <summary>
        /// ID (guid, as string) of the required mod.
        /// </summary>
        [JsonProperty(PropertyName = "id", Order = 2)]
        public string ID { get; set; }

    }

}
