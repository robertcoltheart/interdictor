using Interdictor;
using Microsoft.Extensions.Http;

namespace Microsoft.Extensions.DependencyInjection;

public static class InterdictorServicesExtensions
{
    public static MockHttpClientBuilder AddMockHttpClient(this IServiceCollection services)
    {
        if (!services.Any(x => x.ServiceType == typeof(IHttpMessageHandlerFactory) && x.ImplementationType == typeof(HttpClientInterceptionFilter)))
        {
            services.AddSingleton<IHttpMessageHandlerBuilderFilter, HttpClientInterceptionFilter>();
        }

        return new MockHttpClientBuilder(services);
    }
}
