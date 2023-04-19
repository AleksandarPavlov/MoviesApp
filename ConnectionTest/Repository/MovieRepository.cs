using ConnectionTest.Data;

namespace ConnectionTest.Repository
{
    public class MovieRepository
    {
        private readonly MyDbContext _context;

        public MovieRepository(MyDbContext context)
        {
            _context = context;
        }

        public Movie getMovieById(int id)
        {
            return _context.Movie.Find(id);
        }

        public Movie CreateMovie(Movie newMovie)
        {
            _context.Movie.Add(newMovie);
            _context.SaveChanges();
            return newMovie;
        }
    }
}
