namespace Interdictor.Example.WebApi;

public class BasicGitHubApi(HttpClient client)
{
    public async Task GetEvents()
    {
        var response = await client.GetAsync("/events");

        response.EnsureSuccessStatusCode();
    }
}
