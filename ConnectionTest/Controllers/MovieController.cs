using ConnectionTest.Data;
using ConnectionTest.Service;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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

        [HttpGet("best")]
        public ActionResult<List<Movie>> GetTopRatedMovies()
        {
            var movies = _movieService.GetTopRatedMovies();
            if (movies == null)
            {
                return NotFound();
            }

            return movies;
        }

        [HttpGet("chart/top")]
        public ActionResult<List<Movie>> GetTopRatedMoviesSorted(string sort)
        {
            var movies = _movieService.GetTopRatedMoviesSorted(sort);
            if (movies == null)
            {
                return NotFound();
            }

            return movies;
        }

        [HttpGet("genre")]
        public ActionResult<List<Movie>> GetMoviesByCategory([FromQuery] string category)
        {
            var movies = _movieService.GetMoviesByCategory(category);
            if (movies.Count == 0)
            {
                return NotFound();
            }

            return movies;
        }

        [HttpGet("newest/{page}")]
        public ActionResult<List<Movie>> GetNewestMovies(int page)
        {
            var movies = _movieService.GetNewestMovies(page);
            if (movies == null)
            {
                return NotFound();
            }

            return movies;
        }


        [HttpPost()]
        public ActionResult<List<Movie>> CreateMovies(List<Movie> newMovies)
        {
            var movies = new List<Movie>();
            foreach (var newMovie in newMovies)
            {
                var movie = _movieService.CreateMovie(newMovie);
                movies.Add(movie);
            }
            return movies;
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
