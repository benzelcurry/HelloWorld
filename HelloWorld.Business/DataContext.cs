using Microsoft.EntityFrameworkCore;

namespace HelloWorld.Business
{
    public class DataContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;" +
            "Initial Catalog=MoviesLibrary;" +
            "Integrated Security=True;" +
            "Connect Timeout=30;" +
            "Encrypt=False;" +
            "Trust Server Certificate=False;" +
            "Application Intent=ReadWrite;" +
            "Multi Subnet Failover=False";

            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
