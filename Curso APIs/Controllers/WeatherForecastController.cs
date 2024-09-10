using Microsoft.AspNetCore.Mvc;

namespace Curso_APIs.Controllers;

[ApiController]
[Route("api/[controller]")]
public class WeatherForecastController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<WeatherForecastController> _logger;

    //Se crea lista statatica y se inicializa
    private static List<WeatherForecast> ListWeatherForecast = new List<WeatherForecast>();

//Constructor
    public WeatherForecastController(ILogger<WeatherForecastController> logger)
    {
        _logger = logger;        
        if(ListWeatherForecast == null || !ListWeatherForecast.Any())
        {
        // Se le asigna a la lista la coleccion dinamica que se esta generando de elementos
        ListWeatherForecast = Enumerable.Range(1, 5).Select(index => new WeatherForecast
        {
            Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        })
        .ToList();

        }
    }

    //Atributo
    [HttpGet(Name = "GetWeatherForecast")]
    [Route("get/GetWeatherForecast")]
    [Route("Get/GetWeatherForecast2")]
    [Route("[action]")]
    public IEnumerable<WeatherForecast> Get()
    {
        return ListWeatherForecast;
    }

    
    [HttpPost]
    public IActionResult Post(WeatherForecast weatherForecast)
    {
        ListWeatherForecast.Add(weatherForecast);
        return Ok();
    }

    [HttpDelete("{index}")]
    public IActionResult Delete(int index)
    {
         ListWeatherForecast.RemoveAt(index);

         return Ok();
    } 
}
