using Newtonsoft.Json;
using ParksRec.Client.Helpers;
using ParksRec.Client.Models;
using System.Threading.Tasks;

namespace ParksRec.Client
{
    public class Seasons
    {
        private readonly Requests _requests;

        public Seasons(Requests requests)
        {
            _requests = requests;
        }

        public async Task<Season[]> Get()
        {
            string response = await _requests.GetContent("seasons");
            return JsonConvert.DeserializeObject<Season[]>(response);
        }

        public async Task<Season[]> Get(string season)
        {
            string response = await _requests.GetContent($"seasons/{season}");
            return JsonConvert.DeserializeObject<Season[]>(response);
        }
    }
}
