using Microsoft.Extensions.Http;

namespace Interdictor;

public class HttpClientInterceptionFilter(InterdictorOptions options) : IHttpMessageHandlerBuilderFilter
{
    public Action<HttpMessageHandlerBuilder> Configure(Action<HttpMessageHandlerBuilder> next)
    {
        return builder =>
        {
            next(builder);

            builder.AdditionalHandlers.Add(options.GetHttpMessageHandler(builder.Name));
        };
    }
}
