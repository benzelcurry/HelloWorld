using HelloWorld.Business;
using HelloWorld.Business.Models;

MovieService movieService = new();
List<Movie> movies = movieService.Get();

foreach (Movie movie in movies)
{
    Console.WriteLine(movie.Title);
    Console.WriteLine(movie.ReleaseDate.ToString());
    Console.WriteLine("");
    Console.WriteLine(movie.Plot);
    Console.WriteLine("----------------------");
}
