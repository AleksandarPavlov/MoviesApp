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

        public List<Movie> getAllMovies()
        {
            return _context.Movie.ToList();
        }

        public List<Movie> getTopRatedMovies()
        {
            return _context.Movie
                   .OrderByDescending(m => m.Rating)
                   .Take(100)
                   .ToList();
        }
        public List<Movie> GetNewestMovies(int page)
        {
            int pageSize = 10;
            int skipCount = (page - 1) * pageSize;
            var movies = _context.Movie.OrderByDescending(m => m.ReleaseDate).Take(100)
                                      .Skip(skipCount)
                                      .Take(pageSize)
                                      .ToList();
            return movies;
        }

        public List<Movie> GetMoviesByCategory(string category)
        {
            var movies = _context.Movie.Where(m => m.Category == category).ToList();
            return movies;
        }

        public List<Movie> GetTopRatedMoviesSorted(string sort)
        {
            switch (sort.ToLower())
            {
                case "newest":
                    return _context.Movie.OrderByDescending(m => m.ReleaseDate).Take(100).ToList();
                case "oldest":
                    return _context.Movie.OrderBy(m => m.ReleaseDate).Take(100).ToList();
                case "best":
                    return _context.Movie.OrderByDescending(m => m.Rating).Take(100).ToList();
                default:
                    return _context.Movie.OrderByDescending(m => m.Rating).Take(100).ToList();
            }
        }

        public Movie CreateMovie(Movie newMovie)
        {
            _context.Movie.Add(newMovie);
            _context.SaveChanges();
            return newMovie;
        }

        public List<string> GetAllCategories()
        {
            return _context.Movie.Select(m => m.Category).Distinct().ToList();
        }
    }
}
