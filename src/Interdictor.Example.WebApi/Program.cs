using Interdictor.Example.WebApi;
using Refit;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRefitClient<IGitHubApi>().ConfigureHttpClient(client => client.BaseAddress = new Uri("http://refit"));
builder.Services.AddHttpClient();
builder.Services.AddHttpClient("Named", client => client.BaseAddress = new Uri("http://named"));
builder.Services.AddHttpClient<BasicGitHubApi>(client => client.BaseAddress = new Uri("http://typed"));

var app = builder.Build();

// Configure the HTTP request pipeline.

var summaries = new[]
{
    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
};

app.MapGet("/weatherforecast", () =>
{
    var forecast = Enumerable.Range(1, 5).Select(index =>
        new WeatherForecast
        (
            DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            Random.Shared.Next(-20, 55),
            summaries[Random.Shared.Next(summaries.Length)]
        ))
        .ToArray();
    return forecast;
});

app.MapGet("/github/{id}", async (string id, IGitHubApi api) =>
{
    return await api.GetEvents();
});

app.Run();

internal record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}

public partial class Program;
