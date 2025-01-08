using System.Net.Http.Json;

namespace Interdictor.Example.WebApi.Tests.Rest;

public class WebApiClient(HttpClient client) : IWebApiClient
{
    public Task<Weather[]?> GetWeatherForecast()
    {
        return client.GetFromJsonAsync<Weather[]>("/weatherforecast");
    }
}
