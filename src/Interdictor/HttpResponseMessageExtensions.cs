using System.Net;
using System.Net.Http.Json;

namespace Interdictor;

public static class HttpResponseMessageExtensions
{
    public static HttpResponseMessage WithStatusCode(this HttpResponseMessage message, HttpStatusCode statusCode)
    {
        message.StatusCode = statusCode;

        return message;
    }

    public static HttpResponseMessage WithHeader(this HttpResponseMessage message, string name, string value)
    {
        message.Headers.TryAddWithoutValidation(name, value);

        return message;
    }

    public static HttpResponseMessage WithJsonContent<T>(this HttpResponseMessage message, T value)
    {
        message.Content = JsonContent.Create(value);

        return message;
    }
}
