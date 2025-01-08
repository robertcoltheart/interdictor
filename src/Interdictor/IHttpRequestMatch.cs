namespace Interdictor;

internal interface IHttpRequestMatch
{
    Task<bool> IsMatch(HttpRequestMessage message);
}
