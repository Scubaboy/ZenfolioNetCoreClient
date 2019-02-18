namespace ZenfolioAPIInvestigation.WebClient
{
    using System.Threading.Tasks;
    using ZenfolioAPIInvestigation.Models;
    using ZenfolioAPIInvestigation.Types;

    public interface IZenfolioWebClient
    {
        void Authenticate();

        Task<Group> LoadGroup(string groupId, ZenfolioLevel level, bool includeChildren);
    }
}
