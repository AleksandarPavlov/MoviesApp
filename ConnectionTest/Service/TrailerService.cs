using ConnectionTest.Data;
using ConnectionTest.Repository;

namespace ConnectionTest.Service
{
    public class TrailerService
    {
        private readonly TrailerRepository _trailerRepository;

        public TrailerService(TrailerRepository trailerRepository)
        {
            _trailerRepository = trailerRepository;
        }

        public Trailer GetTrailerById(int id)
        {
            return _trailerRepository.getTrailerById(id);
        }

        public List<Trailer> GetAllTrailers()
        {
            return _trailerRepository.getAllTrailers();
        }
        public Trailer CreateTrailer(Trailer newTrailer)
        {
            return _trailerRepository.CreateTrailer(newTrailer);
        }
    }
}

