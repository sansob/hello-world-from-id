using hello_world_from_id.Models;
using Microsoft.AspNetCore.Mvc;
using hello_world_from_id.Services;

namespace hello_world_from_id.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController(IWeatherForecastService service) : ControllerBase
{
    [HttpGet(Name = "GetWeatherForecast")]
    public IEnumerable<WeatherForecast> Get()
    {
        return service.GetForecast();
    }
}