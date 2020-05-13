using System.Threading.Tasks;
using Newtonsoft.Json;
using ParksRec.Client.Helpers;
using ParksRec.Client.Models;

namespace ParksRec.Client
{
    public class Bands
    {
        private readonly Requests _requests;

        public Bands(Requests requests)
        {
            _requests = requests;
        }

        public async Task<BandName[]> Get()
        {
            string response = await _requests.GetContent("bandnames");
            return JsonConvert.DeserializeObject<BandName[]>(response);
        }

        public async Task<BandName[]> Get(string name)
        {
            string response = await _requests.GetContent($"bandnames/{name}");
            return JsonConvert.DeserializeObject<BandName[]>(response);
        }
    }
}
