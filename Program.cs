using Company.Platform.Hello.Application.Services;
using Company.Platform.Hello.Domain.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddSingleton<IGreetingService, DefaultGreetingService>();

var app = builder.Build();

app.MapControllers();

app.Run();

public partial class Program { }
