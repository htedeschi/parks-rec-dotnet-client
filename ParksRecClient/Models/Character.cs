using Newtonsoft.Json;

namespace ParksRecClient.Models
{
    public class Character
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("portrayed")]
        public string Portrayed { get; set; }

        [JsonProperty("background")]
        public string Background { get; set; }

        [JsonProperty("personality")]
        public string Personality { get; set; }
    }
}
