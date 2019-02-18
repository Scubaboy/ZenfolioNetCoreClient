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
        private IResponseConverter responseConverter;
        private IApiConstants apiConstants;


        public ZenfolioWebClient(ITransportClient transportClient, IResponseConverter responseConverter, IApiConstants apiConstants)
        {
            this.transportClient = transportClient;
            this.responseConverter = responseConverter;
            this.apiConstants = apiConstants;

        }

        public void Authenticate()
        {

        }

        public async Task<Group> LoadGroup(string groupId, ZenfolioLevel level, bool includeChildren)
        {
            var requestUrlEndpoint = string.Format(this.apiConstants.LoadGroupUri, groupId, level, includeChildren);// $"api/1.8/zfapi.asmx/LoadGroup?groupId={groupId}&level={level}&includeChildren={includeChildren}";
            var result = await this.transportClient.Get(requestUrlEndpoint);

            return await Task.Run(() => 
            {
                return this.responseConverter.XMLTo<Group>(result);
            });
        }
    }
}
