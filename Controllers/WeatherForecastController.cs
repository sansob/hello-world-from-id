using hello_world_from_id.Models;
using Microsoft.AspNetCore.Mvc;
using hello_world_from_id.Services;

namespace hello_world_from_id.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private readonly IWeatherForecastService _service;

    public WeatherForecastController(IWeatherForecastService service)
    {
        _service = service;
    }

    [HttpGet(Name = "GetWeatherForecast")]
    public IEnumerable<WeatherForecast> Get()
    {
        return _service.GetForecast();
    }
}