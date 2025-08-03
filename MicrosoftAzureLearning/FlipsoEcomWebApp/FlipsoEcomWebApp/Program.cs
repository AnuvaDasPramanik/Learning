var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello to Flipso Ecom World! Starting Module 2 Assignment");

app.Run();
