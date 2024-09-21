using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Middleware to handle HTTP requests and respond with "Hello, World!"
app.MapGet("/", () => "Hello, World!");

app.Run();
