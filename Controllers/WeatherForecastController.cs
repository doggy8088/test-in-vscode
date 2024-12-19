using Microsoft.AspNetCore.Mvc;

namespace api1.Controllers;

[ApiController]
[Route("api/[controller]")]
public class WeatherForecastController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<WeatherForecastController> _logger;

    public WeatherForecastController(ILogger<WeatherForecastController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public async Task<IEnumerable<WeatherForecast>> GetAsync()
    {
        var data = new[]
        {
            new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(1)),
                TemperatureC = 20,
                Summary = "Mild"
            },
            new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(2)),
                TemperatureC = 25,
                Summary = "Warm"
            },
            new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(3)),
                TemperatureC = 30,
                Summary = "Hot"
            },
            new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(4)),
                TemperatureC = 28,
                Summary = "Balmy"
            },
            new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(5)),
                TemperatureC = 22,
                Summary = "Mild"
            }
        };

        return await Task.FromResult(data.ToList());
    }
}
