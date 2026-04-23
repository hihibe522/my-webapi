using Microsoft.AspNetCore.Mvc;
using my_webapi.Models;
using my_webapi.Services;

namespace my_webapi.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private readonly WeatherForecastService _service;

    public WeatherForecastController(WeatherForecastService service)
    {
        _service = service;
    }

    [HttpGet]
    public WeatherForecast[] Get() => _service.GetForecast();
}
