namespace Interdictor;

public static class HttpRequestMessageExtensions
{
    public static bool IsHttps(this HttpRequestMessage message)
    {
        return false;
    }
}
