using System.ComponentModel.DataAnnotations;

namespace HelloWorld.Business.Models
{
    public class Movie
    {
        public int Id { get; set; }
        [MaxLength(100)]
        public string Title { get; set; }
        public string Plot {  get; set; }
        public DateTime ReleaseDate { get; set; }
        public bool Seen { get; set; }
    }
}
