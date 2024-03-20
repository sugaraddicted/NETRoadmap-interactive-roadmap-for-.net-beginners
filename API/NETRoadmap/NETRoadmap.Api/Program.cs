using Microsoft.EntityFrameworkCore;
using NETRoadmap.Infrastructure.Persistence;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("Postgres");

builder.Services.AddDbContextPool<AppDbContext>(options =>
{
    options.UseNpgsql(connectionString,
        b => b.MigrationsAssembly("NETRoadmap.Infrastructure"));
});

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
