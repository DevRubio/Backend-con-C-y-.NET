using Microsoft.AspNetCore.Mvc;

namespace Curso_APIs.Controllers;

[ApiController]
[Route("api/[controller]")]
public class HelloWordController: ControllerBase
{
    IHelloWordService helloWordService;

    /*
    Se recibe la instancia que el inyector a creado y esta pasando por el constructor y se guarda en la propiedad IHelloWordService
    */
    public HelloWordController(IHelloWordService helloWord)
    {
        helloWordService = helloWord;
    }

    public IActionResult Get()
    {
        return Ok(helloWordService.GetHelloWorld());
    }
}