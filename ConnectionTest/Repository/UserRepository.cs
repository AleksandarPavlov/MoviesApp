using ConnectionTest.Data;

namespace ConnectionTest.Repository
{
    public class UserRepository
    {
      
            private readonly MyDbContext _context;

            public UserRepository(MyDbContext context)
            {
                _context = context;
            }

            public User getUserById(int id)
            {
                return _context.User.Find(id);
            }

            public User CreateUser(User newUser) 
            {
                _context.User.Add(newUser);
                _context.SaveChanges();
                return newUser;
            }
                
                
    }
}
