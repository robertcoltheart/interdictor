namespace Interdictor.Example.WebApi.Tests.Rest;

public interface IWebApiClient
{
    Task<Weather[]?> GetWeatherForecast();
}
