using System.Net;

namespace Interdictor;

public class MockHttpClient
{
    public static implicit operator DelegatingHandler(MockHttpClient client)
    {
        return new InterceptingHttpMessageHandler(null);
    }

    // Supports wildcards
    public MockHttpClient Where(string url)
    {
        return this;
    }

    // Supports wildcards
    public MockHttpClient Where(HttpMethod method, string url)
    {
        return this;
    }

    public MockHttpClient Where(Func<HttpRequestMessage, bool> predicate)
    {
        return this;
    }

    public MockHttpClient Returns(Action<HttpResponseMessage> response)
    {
        return this;
    }

    public MockHttpClient ReturnsJson<T>(T value, HttpStatusCode? statusCode = null)
    {
        return this;
    }

    public HttpClient CreateHttpClient()
    {
        return new HttpClient(new InterceptingHttpMessageHandler(null));
    }

    public DelegatingHandler CreateDelegatingHandler()
    {
        return new InterceptingHttpMessageHandler(null);
    }

    public int GetMatchCount()
    {
        return 0;
    }
}
