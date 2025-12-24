# helloapi

.NET 8 Web API starter generated via cookiecutter with a lightweight DDD-inspired layout.

## Quickstart
- Build: `dotnet build helloapi.sln`
- Run: `dotnet run --project helloapi.csproj`
- Test: `dotnet test helloapi.sln`
- Endpoint: `GET http://localhost:5000/hello/{name}` -> `{"name":"{name}","message":"Hello, {name}!"}`

## Structure
- `Domain` (model + ports): `Greeting`, `IGreetingService`
- `Application` (use cases): `DefaultGreetingService`
- `Controllers` (web adapters): `HelloController`

## Requirements
- .NET SDK net8.0 or later
