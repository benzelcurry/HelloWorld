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
            string query = $"DELETE FROM Movies WHERE Id={id}";

            using (SqlConnection connection = new(connectionString))
            {
                connection.Open();
                SqlCommand command = new(query, connection);
                command.ExecuteNonQuery();
            }
        }

        public void Update(Movie movie)
        {
            if (movie.Id <= 0)
                throw new Exception("Id can't be zero or less.");

            string query = "UPDATE MOVIES SET Title=@Title, Plot=@Plot, ReleaseDate=@ReleaseDate, Seen=@Seen WHERE Id=@Id";

            using (SqlConnection connection = new(connectionString))
            {
                connection.Open();
                SqlCommand command = new(query, connection);
                command.Parameters.Add("@Title", System.Data.SqlDbType.VarChar).Value = movie.Title;
                command.Parameters.Add("@Plot", System.Data.SqlDbType.VarChar).Value = movie.Plot;
                command.Parameters.Add("@ReleaseDate", System.Data.SqlDbType.DateTime2).Value = movie.ReleaseDate;
                command.Parameters.Add("@Seen", System.Data.SqlDbType.Bit).Value = movie.Seen;
                command.Parameters.Add("@Id", System.Data.SqlDbType.Int).Value = movie.Id;
                command.ExecuteNonQuery();
            }
        }
    }
}
