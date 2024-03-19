using Microsoft.EntityFrameworkCore;
using HelloWorld.Business.Models;

namespace HelloWorld.Business
{
    public class DataContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }

        //public DataContext()
        //{
        //    this.Movies.Add(new Movie()
        //    {
        //        Id = 3,
        //        Plot = "When a beautiful stranger leads computer hacker Neo to a forbidding underworld, he discovers the shocking truth--the life he knows is the elaborate deception of an evil cyber-intelligence.",
        //        ReleaseDate = new DateTime(1999, 03, 31),
        //        Seen = false,
        //        Title = "The Matrix"
        //    });
        //    this.Movies.Add(new Movie()
        //    {
        //        Id = 4,
        //        Plot = "78-year-old Carl Fredricksen travels to Paradise Falls in his house equipped with balloons, inadvertently taking a young stowaway.\r\n\r\n",
        //        ReleaseDate = new DateTime(2009, 05, 29),
        //        Seen = false,
        //        Title = "Up!"
        //    });

        //    this.SaveChanges();
        //}

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

            //optionsBuilder.UseInMemoryDatabase("HelloWorldDatabase");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>().HasData(new Movie()
            {
                Id = 3,
                Plot = "When a beautiful stranger leads computer hacker Neo to a forbidding underworld, he discovers the shocking truth--the life he knows is the elaborate deception of an evil cyber-intelligence.",
                ReleaseDate = new DateTime(1999, 03, 31),
                Seen = false,
                Title = "The Matrix"
            },
            new Movie()
            {
                Id = 4,
                Plot = "78-year-old Carl Fredricksen travels to Paradise Falls in his house equipped with balloons, inadvertently taking a young stowaway.\r\n\r\n",
                ReleaseDate = new DateTime(2009, 05, 29),
                Seen = false,
                Title = "Up"
            });
        }
    }
}
