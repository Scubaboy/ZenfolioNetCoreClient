namespace ZenfolioAPIInvestigation.ResponseConverters
{
    using Microsoft.Extensions.DependencyInjection;
    using System;

    public class ResponseConverterFactory : IResponseConverterFactory
    {
        private IServiceProvider services;

        public ResponseConverterFactory(IServiceProvider services)
        {
            this.services = services;
        }
        public IResponseConverter<T> CreateResponseConverter<T>()
        {
            return this.services.GetService<IResponseConverter<T>>();

        }
    }
}
