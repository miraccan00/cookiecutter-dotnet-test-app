using Company.Platform.Hello.Domain.Models;

namespace Company.Platform.Hello.Domain.Services
{
    public interface IGreetingService
    {
        Greeting Greet(string? name);
    }
}
