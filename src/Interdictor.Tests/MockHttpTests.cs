using RichardSzalay.MockHttp;

namespace Interdictor.Tests;

public class MockHttpTests
{
    public void MockHttp()
    {
        var client = new MockHttpMessageHandler();

        client.When("");
        client.When(HttpMethod.Get, "localhost");
    }
}
