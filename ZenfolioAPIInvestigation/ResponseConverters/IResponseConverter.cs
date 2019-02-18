namespace ZenfolioAPIInvestigation.ResponseConverters
{
    public interface IResponseConverter
    {
        T XMLTo<T>(string xmlResponse);
    }
}
