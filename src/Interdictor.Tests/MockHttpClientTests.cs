using System.Net;
using MockHttpClient;

namespace Interdictor.Tests;

public class MockHttpClientTests
{
    public void MockHttpClient()
    {
        var client = new global::MockHttpClient.MockHttpClient();

        client
            .When(x => x.HasMethod(HttpMethod.Get))
            .When(x => x.HasHeader("header", "abc"))
            .Then(x => new HttpResponseMessage()
                .WithHeader("Content", "application/json")
                .WithJsonContent(new object()));
    }
}
