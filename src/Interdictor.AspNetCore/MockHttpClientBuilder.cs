using Microsoft.Extensions.DependencyInjection;

namespace Interdictor;

public class MockHttpClientBuilder(IServiceCollection services)
{
    public MockHttpClientBuilder Where(Action<MockHttpClient> configure)
    {
        return this;
    }
}
