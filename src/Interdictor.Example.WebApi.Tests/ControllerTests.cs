namespace Interdictor.Example.WebApi.Tests;

public class ControllerTests
{
    public void Api()
    {
        new MockHttpClient()
            .Where(x => x.IsHttps())
            .ReturnsJson(new object());
    }
}
