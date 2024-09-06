using Microsoft.AspNetCore.Mvc;

/// <summary>
/// Interface for the Web (API) and the Direct API for the 
/// URL Shortening service. Includes the API specifications 
/// for the Create, Update and Delete functionality for the 
/// URL Mapping. For the simplicity we will link the 
/// Controller directly with the Data layer for this project.
/// </summary>
namespace UrlShortener2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UrlShortenerApi : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<UrlShortenerApi> _logger;

        public UrlShortenerApi(ILogger<UrlShortenerApi> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}
