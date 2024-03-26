using HelloWorld.Business.Models;
using Microsoft.EntityFrameworkCore;

namespace HelloWorld.Business;

public class DataContext : DbContext
{
    public DbSet<Movie> Movies { get; set; }
    public DbSet<Genre> Genres { get; set; }

    public DataContext(DbContextOptions<DataContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Movie>().Property(x => x.GenreId).HasDefaultValue(1);

        modelBuilder.Entity<Genre>().HasData(new Genre()
        {
            Id = 1,
            Name = "Action"
        },
        new Genre()
        {
            Id = 2,
            Name = "Horror"
        },
        new Genre()
        {
            Id = 3,
            Name = "Humor"
        },
        new Genre()
        {
            Id = 4,
            Name = "SciFi"
        });

        modelBuilder.Entity<Movie>().HasData(new Movie()
        {
            Id = 2,
            Plot = "When a beautiful stranger leads computer hacker Neo to a forbidding underworld, he discovers the shocking truth--the life he knows is the elaborate deception of an evil cyber-intelligence.",
            ReleaseDate = new DateTime(1999, 03, 31),
            Seen = false,
            Title = "The Matrix"
        },
        new Movie()
        {
            Id = 3,
            Plot = "78-year-old Carl Fredricksen travels to Paradise Falls in his house equipped with balloons, inadvertently taking a young stowaway.\r\n\r\n",
            ReleaseDate = new DateTime(2009, 05, 29),
            Seen = false,
            Title = "Up"
        });
    }
}
