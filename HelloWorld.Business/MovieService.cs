using HelloWorld.Business.Models;
using Microsoft.Data.SqlClient;

namespace HelloWorld.Business
{
    public class MovieService
    {
        private DataContext dataContext;

        public MovieService()
        {
            dataContext = new DataContext();
        }

        public List<Movie> Get()
        {
            List<Movie> movies = dataContext.Movies.ToList();
            return movies;
        }

        public void Create(Movie movie)
        {
            dataContext.Movies.Add(movie);
            dataContext.SaveChanges();
        }

        public void Delete(int id)
        {
            Movie movieToDelete = dataContext.Movies.Single(x => x.Id == id);

            dataContext.Remove(movieToDelete);
            dataContext.SaveChanges();
        }

        public void Update(Movie movie)
        {
            if (movie.Id <= 0)
                throw new Exception("Movie does not exist.");

            Movie movieToUpdate = dataContext.Movies.Single(x => x.Id == movie.Id);

            movieToUpdate.Seen = movie.Seen;
            movieToUpdate.Title = movie.Title;
            movieToUpdate.Plot = movie.Plot;

            dataContext.SaveChanges();
        }
    }
}
