namespace ZenfolioAPIInvestigation.TransportClients
{
    using System.Net.Http;
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
            var response = await client.GetAsync(urlEndpointRequest);

            response.EnsureSuccessStatusCode();

            return await response.Content.ReadAsStringAsync();
        }
        
    }
}
