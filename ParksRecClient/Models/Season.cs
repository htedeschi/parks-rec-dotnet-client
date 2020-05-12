using System;
using Newtonsoft.Json;

namespace ParksRec.Client.Models
{
    public class Season
    {
        [JsonProperty("season")]
        public string SeasonNumber { get; set; }

        [JsonProperty("episodes")]
        public Episode[] Episodes { get; set; }

        [JsonProperty("first_aired")]
        public DateTime FirstAired { get; set; }

        [JsonProperty("last_aired")]
        public DateTime? LastAired { get; set; }

        [JsonProperty("rank")]
        public int? Rank { get; set; }

        [JsonProperty("viewers")]
        public int? Viewers { get; set; }


    }
}
