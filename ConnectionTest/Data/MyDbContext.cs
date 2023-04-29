using Microsoft.EntityFrameworkCore;

namespace ConnectionTest.Data
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options): base(options) { 

        }

        public DbSet<User> User { get; set; }

        public DbSet<Movie> Movie { get; set; }

        public DbSet<Trailer> Trailer { get; set; }
    }
}
