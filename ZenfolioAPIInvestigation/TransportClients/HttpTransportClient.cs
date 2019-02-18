namespace ZenfolioAPIInvestigation.TransportClients
{
    using System;
    using System.Net;
    using System.Net.Http;
    using System.Net.Http.Headers;
    using System.Threading.Tasks;

    public class HttpTransportClient : ITransportClient
    {
        private IHttpClientFactory httpClientFactory;

        public HttpTransportClient (IHttpClientFactory httpClientFactory)
        {
            this.httpClientFactory = httpClientFactory;

        }
        public async Task<string> Get(string urlEndpointRequest)
        {
            var client = this.httpClientFactory.CreateClient("zenfoliHttpClient");

            client.DefaultRequestHeaders.Add("User-Agent", "C# App");

            var response = await client.GetAsync(urlEndpointRequest);

            response.EnsureSuccessStatusCode();

            return await response.Content.ReadAsStringAsync();
        }
        
    }
}
