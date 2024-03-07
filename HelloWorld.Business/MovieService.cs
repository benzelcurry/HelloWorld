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

        public void Get()
        {
            string query = "SELECT * FROM Movies ORDER BY Title";

            using (SqlConnection connection = new(connectionString))
            {
                SqlCommand command = new(query, connection);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Console.WriteLine(reader["Title"]);
                        Console.WriteLine(reader["ReleaseDate"]);
                        Console.WriteLine("");
                        Console.WriteLine(reader["Plot"]);
                        Console.WriteLine("--------------------------");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Oops!");
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
