namespace Interdictor;

internal class RequestMatchRegistry
{
    public void Register(IHttpRequestMatch match)
    {

    }

    public IHttpRequestMatch? GetRequestMatch(HttpRequestMessage message)
    {
        return null;
    }
}
