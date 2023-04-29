using ConnectionTest.Data;
using ConnectionTest.Service;
using Microsoft.AspNetCore.Mvc;

namespace ConnectionTest.Controllers
{

    [ApiController]
    [Route("trailers")]
    public class TrailerController : ControllerBase
    {
        private readonly TrailerService _trailerService;

        public TrailerController(TrailerService trailerService)
        {
            _trailerService = trailerService;
        }

        [HttpGet("{id}")]
        public ActionResult<Trailer> GetTrailerById(int id)
        {
            var trailer = _trailerService.GetTrailerById(id);
            if (trailer == null)
            {
                return NotFound();
            }

            return trailer;
        }

        [HttpGet()]
        public ActionResult<List<Trailer>> GetAllTrailers()
        {
            var trailers = _trailerService.GetAllTrailers();
            if (trailers == null)
            {
                return NotFound();
            }

            return trailers;
        }

        [HttpPost()]
        public ActionResult<Trailer> CreateTrailer(Trailer newTrailer)
        {
            var trailer = _trailerService.CreateTrailer(newTrailer);
            return trailer;
        }
    }
}
