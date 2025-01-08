using FakeItEasy;

namespace Interdictor.Tests;

public class Api
{
    public void Test()
    {
        var client = new MockHttpClient();

        client
            .Where("*ringfence/*/get-something")
            .Returns(x => x.WithJsonContent(new object()));

        var fake = A.Fake<ICloneable>();

        A.CallTo(() => fake.Clone()).Returns(new object());
    }
}
