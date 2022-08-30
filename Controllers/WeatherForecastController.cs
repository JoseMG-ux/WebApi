using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastController> _logger;

        //private static List<WeatherForecast> _ListWeatherForecast = new List<WeatherForecast>();//Instancia
        //public WeatherForecastController(ILogger<WeatherForecastController> logger)
        //{
        //    _logger = logger;

        //    if (_ListWeatherForecast == null || !_ListWeatherForecast.Any())
        //    {
        //        _ListWeatherForecast = Enumerable.Range(1, 5).Select(index => new WeatherForecast
        //        {
                  
        //            Date = DateTime.Now,
        //            TemperatureC = Random.Shared.Next(-20, 55),
        //            Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        //        })
        //        .ToList();
        //    }
        //}

        //[HttpGet]
        ////Pueden haber multiples rutas
        ////[Route("Get/weatherforecast")]//other example
        ////[Route("Get/weatherforecast2")]
        //[Route("[action]")]
        //public IEnumerable<WeatherForecast> GetList()
        //{
        //    _logger.LogDebug("Retornando la list de WeatherForecast");
        //    return _ListWeatherForecast;
        //}

        //[HttpPost]
        //[Route("[action]")]
        //public IActionResult PostList(WeatherForecast weatherForecast)
        //{
        //    _ListWeatherForecast.Add(weatherForecast);

        //    return Ok();
        //}

        //[HttpDelete]
        //[Route("[action]/{index}")]
        //public IActionResult DeleteList(int index)
        //{
        //    _ListWeatherForecast.RemoveAt(index);

        //    return Ok();
        //}
    }
}