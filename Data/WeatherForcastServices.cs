namespace WheatherForecastBlazorWithRedisCache;

public class WeatherForcastService
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching" 
    };

    public async Task<WeatherForecast[]> getForecastAsync(DateTime startDate)
    {
        // Simulate asynchronous loading to demonstrate streaming rendering
        var rng = new Random();
        await Task.Delay(500);

        // var startDate = DateOnly.FromDateTime(DateTime.Now);

        return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        {
            Date = startDate.AddDays(index),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = Summaries[rng.Next(Summaries.Length)]
        }).ToArray();
    }

}
