namespace Interdictor;

public class InterdictorOptions
{
    private readonly RequestMatchRegistry registry = new();

    public InterdictorOptions When(Action<InterdictorBuilder> action)
    {
        var builder = new InterdictorBuilder();
        action(builder);

        return this;
    }

    public DelegatingHandler GetHttpMessageHandler(string? clientName = null)
    {
        return new InterceptingHttpMessageHandler(registry);
    }
}
