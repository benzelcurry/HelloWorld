using HelloWorld.Business.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore.Storage;
using System.Transactions;

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
            using (IDbContextTransaction transaction = dataContext.Database.BeginTransaction())
            {
                try
                {
                    Movie movieToDelete = dataContext.Movies.Single(x => x.Id == id);

                    dataContext.Remove(movieToDelete);
                    dataContext.SaveChanges();

                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                }
            }
        }

        public void Update(Movie movie)
        {
            using (IDbContextTransaction transaction = dataContext.Database.BeginTransaction())
            {
                try
                {
                    if (movie.Id <= 0)
                        throw new Exception("Movie does not exist.");

                    Movie movieToUpdate = dataContext.Movies.Single(x => x.Id == movie.Id);

                    movieToUpdate.Seen = movie.Seen;
                    movieToUpdate.Title = movie.Title;
                    movieToUpdate.Plot = movie.Plot;

                    dataContext.SaveChanges();

                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                }
            }
        }
    }
}
