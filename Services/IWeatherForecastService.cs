using hello_world_from_id.Models;

namespace hello_world_from_id.Services;

public interface IWeatherForecastService
{
    IEnumerable<WeatherForecast> GetForecast();
}