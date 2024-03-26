using HelloWorld.Business;
using HelloWorld.Business.Interfaces;
using HelloWorld.Business.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<DataContext>(o => o.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;" +
        "Initial Catalog=MoviesLibrary;" +
        "Integrated Security=True;" +
        "Connect Timeout=30;" +
        "Encrypt=False;" +
        "Trust Server Certificate=False;" +
        "Application Intent=ReadWrite;" +
        "Multi Subnet Failover=False"));
builder.Services.AddScoped<IMovieService, MovieService>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapGet("/api/movies", (IMovieService movieService) =>
{
    List<Movie> movies = movieService.Get();

    return Results.Ok(movies);
});

app.MapDelete("/api/movies/{id:int}", (IMovieService movieService, int id) =>
{
    movieService.Delete(id);

    return Results.NoContent();
});

app.MapPost("/api/movies", (IMovieService movieService, Movie movie) =>
{
    movieService.Create(movie);

    return Results.NoContent();
});

app.Run();