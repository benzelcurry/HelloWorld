using HelloWorld.Business;
using HelloWorld.Business.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

// Begin HTTP routes

app.MapGet("/api/movies", () =>
{
    MovieService movieService = new();
    List<Movie> movies = movieService.Get();

    return Results.Ok(movies);
});

app.Run();
