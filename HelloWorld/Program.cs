using HelloWorld.Business;
using HelloWorld.Business.Models;

MovieService movieService = new();

List<Movie> moviesList =  movieService.Get();

foreach (Movie movie in moviesList)
{
    Console.WriteLine(movie.Title);
    Console.WriteLine(movie.ReleaseDate);
    Console.WriteLine(movie.Plot);
    Console.WriteLine("------------------------------");
}
