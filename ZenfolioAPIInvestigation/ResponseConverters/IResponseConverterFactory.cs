namespace ZenfolioAPIInvestigation.ResponseConverters
{
    public interface IResponseConverterFactory
    {
        IResponseConverter<T> CreateResponseConverter<T>();
    }
}
