using Newtonsoft.Json;

namespace ParksRec.Client.Models
{
    public class BandName
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
