using AtFileshare.Application;
using AtFileshare.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddApplication()
    .AddInfrastructure();

builder.Services.AddControllers();

var app = builder.Build();
app.MapControllers();
app.Run();