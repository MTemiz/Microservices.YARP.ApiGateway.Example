var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.MapGet("/api2", () => "Api2");

app.Run();