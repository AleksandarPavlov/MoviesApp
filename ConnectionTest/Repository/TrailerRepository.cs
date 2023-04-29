using ConnectionTest.Data;

namespace ConnectionTest.Repository
{
    public class TrailerRepository
    {
        private readonly MyDbContext _context;

        public TrailerRepository(MyDbContext context)
        {
            _context = context;
        }

        public Trailer getTrailerById(int id)
        {
            return _context.Trailer.Find(id);
        }

        public List<Trailer> getAllTrailers()
        {
            return _context.Trailer.ToList();
        }

        public Trailer CreateTrailer(Trailer newTrailer)
        {
            _context.Trailer.Add(newTrailer);
            _context.SaveChanges();
            return newTrailer;
        }
    }
}
