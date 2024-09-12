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

//Se creo Iloger utilizando el tipo de datos WeatherForecastController, lo recibe dentro del constructor
    //private readonly ILogger<WeatherForecastController> _logger;
    private readonly ILoggerService _loggerService;

    //Se crea lista statatica y se inicializa
    private static List<WeatherForecast> ListWeatherForecast = new List<WeatherForecast>();

//Constructor
    public WeatherForecastController(ILoggerService logerService)//(ILogger<WeatherForecastController> logger)
    {
        //_logger = logger;   
        _loggerService = logerService;     
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
        //_logger.LogInformation("LogInformation: Retornadno la lista de WeatherForecast");
        //_logger.LogDebug("LogDebug: Retornadno la lista de WeatherForecast");   
        try{
            throw new InvalidOperationException("Algo salió mal");
            //_loggerService.SaveTrace(new LogTrace(Component.Business, "WeatherForecast", "Metodo Post Ejecutado correctamente"));
        }
        catch(Exception ex)
        {
            var logException = new LogException(
                Component.Business,
                $"Error en DoSomething: {ex.Message}",
                ex.StackTrace ?? "No stack trace available",
                ex
            );
            _loggerService.SaveException(logException);
        }
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
