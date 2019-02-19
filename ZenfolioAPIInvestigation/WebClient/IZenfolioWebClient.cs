namespace ZenfolioAPIInvestigation.WebClient
{
    using System.Threading.Tasks;
    using ZenfolioAPIInvestigation.Models;
    using ZenfolioAPIInvestigation.Types;

    public interface IZenfolioWebClient
    {
        void Authenticate();

        Task<Group> LoadGroupAsync(string groupId, ZenfolioLevel level, bool includeChildren);

        Task<PhotoSet> LoadPhotoSetAsync(string photoSetId, ZenfolioLevel level, bool includeChildren);
    }
}
