using Newtonsoft.Json;

namespace ParksRecClient.Models
{
    class BandName
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
