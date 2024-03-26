using HelloWorld.Business.Models;

namespace HelloWorld.Business.Interfaces
{
    public interface IMovieService
    {
        List<Movie> Get();
        void Create(Movie movie);
        void Delete(int id);
        void Update(Movie movie);
    }
}
