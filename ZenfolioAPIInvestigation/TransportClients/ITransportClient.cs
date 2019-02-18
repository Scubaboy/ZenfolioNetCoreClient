using System.Threading.Tasks;

namespace ZenfolioAPIInvestigation.TransportClients
{
    public interface ITransportClient
    {
       Task<string> Get(string urlEndpointRequest);
    }
}
