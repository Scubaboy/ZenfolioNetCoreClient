namespace ZenfolioAPIInvestigation.ResponseConverters
{
    public interface IResponseConverter<T>
    {
        T XMLTo(string xmlResponse);
        
    }
}
