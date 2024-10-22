var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapPost("/", () => "Hello World!");

app.Run();
