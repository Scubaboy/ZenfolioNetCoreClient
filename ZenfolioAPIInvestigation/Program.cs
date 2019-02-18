namespace ZenfolioAPIInvestigation
{
    using Microsoft.Extensions.DependencyInjection;
    using System;
    using System.Threading.Tasks;
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

            serviceProvider.AddSingleton<IResponseConverter, XmlResponseConverter>();
            serviceProvider.AddSingleton<IZenfolioWebClient, ZenfolioWebClient>();
            serviceProvider.AddSingleton<ITransportClient, HttpTransportClient>();
            serviceProvider.AddSingleton<IResponseConverter, XmlResponseConverter>();
                serviceProvider.AddHttpClient("zenfoliHttpClient", client => 
                {
                    client.BaseAddress = new Uri("https://api.zenfolio.com/"); 
                });
            var provider = serviceProvider.BuildServiceProvider();
            var rep= provider.GetService<ITransportClient>();
            var zenfolioClient = provider.GetService<IZenfolioWebClient>();

            var result = await zenfolioClient.LoadGroup("752364489", ZenfolioLevel.Full, true);
        }
    }
}
