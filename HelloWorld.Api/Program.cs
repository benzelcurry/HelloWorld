using HelloWorld.Business;
using HelloWorld.Business.Models;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapGet("/api/movies", () =>
{
    MovieService movieService = new();
    List<Movie> movies = movieService.Get();

    return Results.Ok(movies);
});

app.MapDelete("/api/movies/{id:int}", (int id) =>
{
    MovieService movieService = new();
    movieService.Delete(id);

    return Results.NoContent();
});

app.MapPost("/api/movies", (Movie movie) =>
{
    MovieService movieService = new();
    movieService.Create(movie);

    return Results.NoContent();
});

app.Run();