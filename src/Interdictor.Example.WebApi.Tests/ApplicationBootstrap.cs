using Alba;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.DependencyInjection;
using TUnit.Core.Interfaces;

namespace Interdictor.Example.WebApi.Tests;

public class ApplicationBootstrap : IAsyncInitializer, IAsyncDisposable
{
    public IAlbaHost Host { get; private set; } = null!;

    public async Task InitializeAsync()
    {
        Host = await AlbaHost.For<Program>(builder =>
        {
            builder
                .ConfigureTestServices(services =>
                {
                    services
                        .AddMockHttpClient();
                });
        });
    }

    public async ValueTask DisposeAsync()
    {
        await Host.DisposeAsync();
    }
}
