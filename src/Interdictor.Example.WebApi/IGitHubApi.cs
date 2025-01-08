using Refit;

namespace Interdictor.Example.WebApi;

public interface IGitHubApi
{
    [Get("/events")]
    Task GetEvents(int? page = null);

    [Get("/repos/{owner}/{repo}")]
    Task GetRepo(string owner, string repo);
}
