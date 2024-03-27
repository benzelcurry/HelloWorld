using HelloWorld.Business;
using HelloWorld.Business.Interfaces;
using HelloWorld.Domain.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IMovieService, MovieService>();

builder.Services.AddDbContext<DataContext>(o => o.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;" +
        "Initial Catalog=MoviesLibrary;" +
        "Integrated Security=True;" +
        "Connect Timeout=30;" +
        "Encrypt=False;" +
        "Trust Server Certificate=False;" +
        "Application Intent=ReadWrite;" +
        "Multi Subnet Failover=False"), ServiceLifetime.Transient);

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

app.MapDelete("/api/movies/{id:int}", (int id, IMovieService movieService) =>
{
    movieService.Delete(id);

    return Results.NoContent();
});

app.MapPost("/api/movies", (Movie movie, IMovieService movieService) =>
{
    movieService.Create(movie);

    return Results.NoContent();
});

app.Run();