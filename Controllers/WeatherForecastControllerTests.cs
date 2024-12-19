using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api1.Controllers;
using Microsoft.Extensions.Logging;
using Xunit;

public class WeatherForecastControllerTests
{
    private readonly WeatherForecastController _controller;
    private readonly ILogger<WeatherForecastController> _logger;

    public WeatherForecastControllerTests()
    {
        _logger = new LoggerFactory().CreateLogger<WeatherForecastController>();
        _controller = new WeatherForecastController(_logger);
    }

    [Fact]
    public async Task GetAsync_ReturnsWeatherForecasts()
    {
        // Act
        var result = await _controller.GetAsync();

        // Assert
        Assert.NotNull(result);
        var forecasts = result.ToList();
        Assert.Equal(5, forecasts.Count);
        Assert.Equal("Mild", forecasts[0].Summary);
        Assert.Equal(20, forecasts[0].TemperatureC);
        Assert.Equal("Warm", forecasts[1].Summary);
        Assert.Equal(25, forecasts[1].TemperatureC);
        Assert.Equal("Hot", forecasts[2].Summary);
        Assert.Equal(30, forecasts[2].TemperatureC);
        Assert.Equal("Balmy", forecasts[3].Summary);
        Assert.Equal(28, forecasts[3].TemperatureC);
        Assert.Equal("Mild", forecasts[4].Summary);
        Assert.Equal(22, forecasts[4].TemperatureC);
    }
}