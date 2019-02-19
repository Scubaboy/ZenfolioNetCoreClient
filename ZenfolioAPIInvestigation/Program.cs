namespace ZenfolioAPIInvestigation
{
    using Microsoft.Extensions.DependencyInjection;
    using System;
    using System.Threading.Tasks;
    using ZenfolioAPIInvestigation.Constants;
    using ZenfolioAPIInvestigation.Models;
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

            //Wire up DI container.
            serviceProvider.AddSingleton<IApiConstants, ZenfolioApiConstants>();
            serviceProvider.AddSingleton<IResponseConverter<Group>, GroupXmlResponseConverter>();
            serviceProvider.AddSingleton<IZenfolioWebClient, ZenfolioWebClient>();
            serviceProvider.AddSingleton<ITransportClient, HttpTransportClient>();
            serviceProvider.AddSingleton<IResponseConverter<PhotoSet>, PhotoSetXmlResponseConverter>();
            serviceProvider.AddSingleton<IResponseConverterFactory, ResponseConverterFactory>();
            serviceProvider.AddHttpClient("zenfoliHttpClient", client =>
            {
                client.BaseAddress = new Uri("https://api.zenfolio.com/");
                client.DefaultRequestHeaders.Add("User-Agent", ".NetCore App");
            });

            //Build DI container.
            var provider = serviceProvider.BuildServiceProvider();
            var rep= provider.GetService<ITransportClient>();
            var zenfolioClient = provider.GetService<IZenfolioWebClient>();

            //Test group and photoset load requests.
            var groupResult = await zenfolioClient.LoadGroupAsync("752364489", ZenfolioLevel.Full, true);
            var photosetResult = await zenfolioClient.LoadPhotoSetAsync(groupResult.Elements[0].Id.ToString(), ZenfolioLevel.Full, true);
        }
    }
}
