var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();

// Till krypteringen används Cesarchiffer med H som startposition

// Metod för kryptering

// Metod för dekryptering