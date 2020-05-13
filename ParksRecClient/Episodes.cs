using System;
using System.Threading.Tasks;
using Newtonsoft.Json;
using ParksRec.Client.Helpers;
using ParksRec.Client.Models;

namespace ParksRec.Client
{
    public class Episodes
    {
        private readonly Requests _requests;

        public Episodes(Requests requests)
        {
            _requests = requests;
        }

        public async Task<Episode[]> Get()
        {
            string response = await _requests.GetContent("episodes");
            return JsonConvert.DeserializeObject<Episode[]>(response);
        }

        public async Task<Episode[]> Get(string title)
        {
            string response = await _requests.GetContent($"episodes/{title}");
            return JsonConvert.DeserializeObject<Episode[]>(response);
        }
    }
}
