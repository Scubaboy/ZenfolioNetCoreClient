namespace ZenfolioAPIInvestigation.WebClient
{
    using System;
    using System.Threading.Tasks;
    using ZenfolioAPIInvestigation.Models;
    using ZenfolioAPIInvestigation.ResponseConverters;
    using ZenfolioAPIInvestigation.TransportClients;
    using ZenfolioAPIInvestigation.Types;

    public class ZenfolioWebClient : IZenfolioWebClient
    {
        private ITransportClient transportClient;
        private IResponseConverter responseConverter;

        public ZenfolioWebClient(ITransportClient transportClient, IResponseConverter responseConverter)
        {
            this.transportClient = transportClient;
            this.responseConverter = responseConverter;

        }

        public void Authenticate()
        {

        }

        public async Task<Group> LoadGroup(string groupId, ZenfolioLevel level, bool includeChildren)
        {
            var requestUrlEndpoint = $"api/1.8/zfapi.asmx/LoadGroup?groupId={groupId}&level={level}&includeChildren={includeChildren}";
            var result = await this.transportClient.Get(requestUrlEndpoint);

            return await Task.Run(() => 
            {
                return this.responseConverter.XMLTo<Group>(result);
            });
        }
    }
}
