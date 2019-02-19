namespace ZenfolioAPIInvestigation.Constants
{
    public class ZenfolioApiConstants : IApiConstants
    {
        public string LoadGroupUri => "api/1.8/zfapi.asmx/LoadGroup?groupId={0}&level={1}&includeChildren={2}";

        public string LoadPhotoSetUri => "api/1.8/zfapi.asmx/LoadPhotoSet?photoSetId={0}&level={1}&includePhotos={2}";
    }
}
