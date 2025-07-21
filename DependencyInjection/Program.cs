using DependencyInjection.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<ITeacher, Teacher>();
builder.Services.AddControllers();

var app = builder.Build();

app.MapControllers();

app.Run();
