using ConnectionTest.Data;
using ConnectionTest.Repository;

namespace ConnectionTest.Service
{
    public class MovieService
    {
        private readonly MovieRepository _movieRepository;

        public MovieService(MovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }

        public Movie GetMovieById(int id)
        {
            return _movieRepository.getMovieById(id);
        }

        public Movie CreateMovie(Movie newMovie)
        {
            return _movieRepository.CreateMovie(newMovie);
        }
    }
}
