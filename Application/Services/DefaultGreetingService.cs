using Company.Platform.Hello.Domain.Models;
using Company.Platform.Hello.Domain.Services;

namespace Company.Platform.Hello.Application.Services
{
    public class DefaultGreetingService : IGreetingService
    {
        public Greeting Greet(string? name)
        {
            return new Greeting(name);
        }
    }
}
