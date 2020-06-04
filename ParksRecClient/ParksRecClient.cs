using ParksRec.Client.Helpers;
using System.Net.Http;
using HttpClientFactoryLite;

namespace ParksRec.Client
{
    public class ParksRecClient
    {
        public ParksRecConfig ParksRecConfig { get; set; }
        public Bands Bands { get; set; }
        public Characters Characters { get; set; }
        public Episodes Episodes { get; set; }
        public Seasons Seasons { get; set; }

        public ParksRecClient(ParksRecConfig config)
        {
            ParksRecConfig = config;

            HttpClientFactory httpClientFactory = new HttpClientFactory();
            httpClientFactory.Register("ParksRecClient", builder => builder
                .ConfigureHttpClient(c => c.BaseAddress = ParksRecConfig.Uri)
                .ConfigureHttpClient(c => c.DefaultRequestHeaders.Add("Authorization", $"Bearer {ParksRecConfig.Token}"))
                .ConfigureHttpClient(c => c.DefaultRequestHeaders.Add("Accept", "application/json")));

            HttpClient httpClient = httpClientFactory.CreateClient("ParksRecClient");

            Requests request = new Requests(httpClient);

            Bands = new Bands(request);
            Characters = new Characters(request);
            Episodes = new Episodes(request);
            Seasons = new Seasons(request);

        }
    }
}
