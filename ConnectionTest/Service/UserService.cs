using ConnectionTest.Data;
using ConnectionTest.Repository;

namespace ConnectionTest.Service
{
    public class UserService
    {
        private readonly UserRepository _userRepository;

        public UserService(UserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public User GetUserById(int id)
        {
            return _userRepository.getUserById(id);
        }

        public User CreateUser(User newUser)
        {
            return _userRepository.CreateUser(newUser);
        }
    }
}
