using Microsoft.AspNetCore.Identity;
using MovieCrud;
using Movies.Models;

var builder = WebApplication.CreateBuilder();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<MovieDbContext>();
builder.Services.AddDbContext<UserDbContext>();

var startup = new Startup();
startup.ConfigureServices(builder.Services);

    


var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


app.MapControllers();
app.MapGet("/", () => "Hello World!");
app.MapGet("/add movies", () => "Hello World!");
app.Run();
