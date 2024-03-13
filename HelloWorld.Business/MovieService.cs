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
            }
        }
    }
}
