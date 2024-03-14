using Microsoft.EntityFrameworkCore;
using HelloWorld.Business.Models;

namespace HelloWorld.Business
{
    public class DataContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }

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
