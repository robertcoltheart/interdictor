using Interdictor.Example.WebApi.Tests.Rest;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.DependencyInjection;

namespace Interdictor.Example.WebApi.Tests;

internal class ApplicationFactory : WebApplicationFactory<Program>
{
    private static ApplicationFactory? instance;

    protected override void ConfigureWebHost(IWebHostBuilder builder)
    {
        builder
            .UseEnvironment("Integration")
            .ConfigureTestServices(services =>
            {
                services
                    .AddSingleton<IWebApiClient>(_ => new WebApiClient(CreateDefaultClient()));

                services
                    .AddMockHttpClient();
            });
    }

    [Before(TestSession)]
    public static void BeforeTest()
    {
        instance = new ApplicationFactory();
    }
}
