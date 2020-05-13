using System.Threading.Tasks;
using Newtonsoft.Json;
using ParksRec.Client.Helpers;
using ParksRec.Client.Models;

namespace ParksRec.Client
{
    public class Characters
    {
        private readonly Requests _requests;

        public Characters(Requests requests)
        {
            _requests = requests;
        }

        public async Task<Character[]> Get()
        {
            string response = await _requests.GetContent("characters");
            return JsonConvert.DeserializeObject<Character[]>(response);
        }

        public async Task<Character[]> Get(string name)
        {
            string response = await _requests.GetContent($"characters/{name}");
            return JsonConvert.DeserializeObject<Character[]>(response);
        }
    }
}
