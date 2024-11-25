var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.MapGet("/api3", () => "Api3");

app.Run();