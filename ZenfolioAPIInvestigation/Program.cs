namespace ZenfolioAPIInvestigation
{
    using Microsoft.Extensions.DependencyInjection;
    using System;
    using System.Threading.Tasks;
    using ZenfolioAPIInvestigation.Constants;
    using ZenfolioAPIInvestigation.ResponseConverters;
    using ZenfolioAPIInvestigation.TransportClients;
    using ZenfolioAPIInvestigation.Types;
    using ZenfolioAPIInvestigation.WebClient;

    class Program
    {
        public static void Main(string[] args)
        {
            MainAsync(args).GetAwaiter().GetResult();

            Console.ReadKey();
        }

        public static async Task MainAsync(string[] args)
        {
            
            var serviceProvider = new ServiceCollection();

            serviceProvider.AddSingleton<IApiConstants, ZenfolioApiConstants>();
            serviceProvider.AddSingleton<IResponseConverter, XmlResponseConverter>();
            serviceProvider.AddSingleton<IZenfolioWebClient, ZenfolioWebClient>();
            serviceProvider.AddSingleton<ITransportClient, HttpTransportClient>();
            serviceProvider.AddSingleton<IResponseConverter, XmlResponseConverter>();
                serviceProvider.AddHttpClient("zenfoliHttpClient", client => 
                {
                    client.BaseAddress = new Uri("https://api.zenfolio.com/");
                    client.DefaultRequestHeaders.Add("User-Agent", ".NetCore App");
                });
            var provider = serviceProvider.BuildServiceProvider();
            var rep= provider.GetService<ITransportClient>();
            var zenfolioClient = provider.GetService<IZenfolioWebClient>();

            var result = await zenfolioClient.LoadGroup("752364489", ZenfolioLevel.Full, true);
        }
    }
}
