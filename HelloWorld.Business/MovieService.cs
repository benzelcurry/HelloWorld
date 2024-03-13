using HelloWorld.Business.Models;
using Microsoft.Data.SqlClient;

namespace HelloWorld.Business
{
    public class MovieService
    {
        private string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;" +
            "Initial Catalog=MovieLibrary;" +
            "Integrated Security=True;" +
            "Connect Timeout=30;" +
            "Encrypt=False;" +
            "Trust Server Certificate=False;" +
            "Application Intent=ReadWrite;" +
            "Multi Subnet Failover=False";

        public List<Movie> Get()
        {
            string query = "SELECT * FROM Movies ORDER BY Title";
            List<Movie> movies = new();

            using (SqlConnection connection = new(connectionString))
            {
                SqlCommand command = new(query, connection);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Movie movie = new()
                        {
                            Id = int.Parse(reader["Id"].ToString()),
                            Plot = reader["Plot"].ToString(),
                            ReleaseDate = DateTime.Parse(reader["ReleaseDate"].ToString()),
                            Seen = bool.Parse(reader["Seen"].ToString()),
                            Title = reader["Title"].ToString(),
                        };
                        movies.Add(movie);
                    }

                    return movies;
                }
                catch (Exception ex)
                {
                    throw;
                }
            }
        }

        public void Create(Movie movie)
        {
            string query = "INSERT INTO Movies (Title, Plot, ReleaseDate, Seen) " +
                           "VALUES (@Title, @Plot, @ReleaseDate, @Seen)";

            using (SqlConnection connection = new(connectionString))
            {
                SqlCommand command = new(query, connection);

                command.Parameters.Add("@Title", System.Data.SqlDbType.VarChar).Value = movie.Title;
                command.Parameters.Add("@Plot", System.Data.SqlDbType.VarChar).Value = movie.Plot;
                command.Parameters.Add("@ReleaseDate", System.Data.SqlDbType.DateTime2).Value = movie.ReleaseDate;
                command.Parameters.Add("@Seen", System.Data.SqlDbType.Bit).Value = movie.Seen;

                connection.Open();

                command.ExecuteNonQuery();
            }
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

            string query = "UPDATE MOVIES SET Title=@Title, Plot=@Plot, ReleaseDate=@ReleaseDate, Seen=@Seen";

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
