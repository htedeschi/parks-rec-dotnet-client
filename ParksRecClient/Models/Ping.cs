using Newtonsoft.Json;
using System;

namespace ParksRec.Client.Models
{
    public class Ping
    {
        [JsonProperty("success")]
        public bool Success { get; set; }
        
        [JsonProperty("date")]
        public DateTime DateTime { get; set; }
    }
}
