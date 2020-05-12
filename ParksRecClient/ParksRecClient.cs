using System;
using System.Net.Http;
using Microsoft.Extensions.Http;

namespace ParksRec.Client
{
    public class ParksRecClient
    {
        public ParksRecConfig ParksRecConfig { get; set; }

        public ParksRecClient(ParksRecConfig config)
        {
            ParksRecConfig = config;

            HttpClientFactory httpClientFactory = new HttpClientFactory();
            httpClientFactory.Register("ParksRecClient", builder => builder
                .ConfigureHttpClient(c => c.BaseAddress = ParksRecConfig.Uri)
                .ConfigureHttpClient(c => c.DefaultRequestHeaders.Add("Authorization", $"Bearer {ParksRecConfig.Token}"))
                .ConfigureHttpClient(c => c.DefaultRequestHeaders.Add("Accept", "application/json")));

            HttpClient httpClient = httpClientFactory.CreateClient("ParksRecClient");


        }
    }
}
