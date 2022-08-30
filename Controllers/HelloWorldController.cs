using Microsoft.AspNetCore.Mvc;
using WebApi.Services;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class HelloWorldController : ControllerBase
    {

        //IHelloWorldService helloWorldServices;

        //private readonly ILogger _logger;

        //public HelloWorldController(IHelloWorldService helloWorld, ILogger<HelloWorldController> logger)
        //{
        //    helloWorldServices = helloWorld;
        //    _logger = logger;
        //}

        //public HelloWorldController(ILogger<HelloWorldController> logger)
        //{
        //    _logger = logger;
        //}

        //[HttpGet]
       
        //public IActionResult Get()
        //{
        //    _logger.LogInformation("Hola, que tal?!");
        //    return Ok(helloWorldServices.GetHelloWorld());
        //}
    }
}
