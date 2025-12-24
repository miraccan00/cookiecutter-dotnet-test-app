using Microsoft.AspNetCore.Mvc;
using Company.Platform.Hello.Domain.Models;
using Company.Platform.Hello.Domain.Services;

namespace Company.Platform.Hello.Controllers
{
    [ApiController]
    [Route("hello")]
    public class HelloController : ControllerBase
    {
        private readonly IGreetingService _greetingService;

        public HelloController(IGreetingService greetingService)
        {
            _greetingService = greetingService;
        }

        [HttpGet("{name?}")]
        public ActionResult<Greeting> Get(string? name)
        {
            return _greetingService.Greet(name);
        }
    }
}
