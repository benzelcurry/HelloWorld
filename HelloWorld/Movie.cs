using System.ComponentModel.DataAnnotations;

namespace HelloWorld;

public class Movie
{
    public int Id { get; set; }
    [Required]
    
    public string Title { get; set; }
    public string Plot { get; set; }
    public DateTime ReleaseDate { get; set; }
    public bool Seen { get; set; }
    public int GenreId { get; set; }
    public virtual Genre Genre { get; set; }
}