using Newtonsoft.Json;

namespace ParksRec.Client.Models
{
    class BandName
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
