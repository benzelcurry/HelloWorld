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
        }
    }
}
