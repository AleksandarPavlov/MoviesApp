using ConnectionTest.Data;
using ConnectionTest.Service;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace ConnectionTest.Controllers
{
    [ApiController]
    [Route("movies")]
    public class MovieController : ControllerBase
    {
        private readonly MovieService _movieService;

        public MovieController(MovieService movieService)
        {
            _movieService = movieService;
        }

        [HttpGet("{id}")]
        public ActionResult<Movie> GetMovieById(int id)
        {
            var movie = _movieService.GetMovieById(id);
            if (movie == null)
            {
                return NotFound();
            }

            return movie;
        }

        [HttpGet()]
        public ActionResult<List<Movie>> GetAllMovies()
        {
            var movies = _movieService.GetAllMovies ();
            if (movies == null)
            {
                return NotFound();
            }

            return movies;
        }

        [HttpPost()]
        public ActionResult<Movie> CreateUser(Movie newMovie)
        {
            var movie = _movieService.CreateMovie(newMovie);
            return movie;
        }

        [HttpGet("categories")]
        public ActionResult<List<string>> GetAllCategories()
        {
            var categories = _movieService.GetAllCategories();
            if (categories == null)
            {
                return NotFound();
            }

            return categories;
        }
    }
}
