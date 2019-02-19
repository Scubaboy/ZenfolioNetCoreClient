namespace ZenfolioAPIInvestigation.WebClient
{
    using System.Threading.Tasks;
    using ZenfolioAPIInvestigation.Constants;
    using ZenfolioAPIInvestigation.Models;
    using ZenfolioAPIInvestigation.ResponseConverters;
    using ZenfolioAPIInvestigation.TransportClients;
    using ZenfolioAPIInvestigation.Types;

    public class ZenfolioWebClient : IZenfolioWebClient
    {
        private ITransportClient transportClient;
        private IResponseConverterFactory responseConverterFactory;
        private IApiConstants apiConstants;


        public ZenfolioWebClient(ITransportClient transportClient, IResponseConverterFactory responseConverterFactory, IApiConstants apiConstants)
        {
            this.transportClient = transportClient;
            this.responseConverterFactory = responseConverterFactory;
            this.apiConstants = apiConstants;

        }

        public void Authenticate()
        {
            //Code when authentication required.
        }

        public async Task<Group> LoadGroupAsync(string groupId, ZenfolioLevel level, bool includeChildren)
        {
            var requestUrlEndpoint = string.Format(this.apiConstants.LoadGroupUri, groupId, level, includeChildren);
            var result = await this.transportClient.Get(requestUrlEndpoint);

            return await Task.Run(() => 
            {
                return this.responseConverterFactory.CreateResponseConverter<Group>().XMLTo(result);
            });
        }

        public async Task<PhotoSet> LoadPhotoSetAsync(string photoSetId, ZenfolioLevel level, bool includeChildren)
        {
            var requestUrlEndpoint = string.Format(this.apiConstants.LoadPhotoSetUri, photoSetId, level, includeChildren);
            var result = await this.transportClient.Get(requestUrlEndpoint);

            return await Task.Run(() =>
            {
                return this.responseConverterFactory.CreateResponseConverter<PhotoSet>().XMLTo(result);
            });
        }
    }
}
