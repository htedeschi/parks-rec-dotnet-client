using System;
using Newtonsoft.Json;
using ParksRec.Client.Helpers;

namespace ParksRec.Client.Models
{
    public class Episode
    {
        [JsonProperty("season")]
        public string Season { get; set; }

        [JsonProperty("number_overall")]
        public int NumberOverall { get; set; }

        [JsonProperty("number_season")]
        public int NumberSeason { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("directed_by")]
        public string DirectedBy { get; set; }

        [JsonProperty("written_by")]
        public string WrittenBy { get; set; }

        [JsonProperty("air_date")]
        public DateTime AirDate { get; set; }

        [JsonProperty("viewers")]
        public int? Viewers { get; set; }
    }
}
