using ConnectionTest.Data;
using ConnectionTest.Service;
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

        [HttpPost()]
        public ActionResult<Movie> CreateUser(Movie newMovie)
        {
            var movie = _movieService.CreateMovie(newMovie);
            return movie;
        }
    }
}
