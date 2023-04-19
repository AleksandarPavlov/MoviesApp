using ConnectionTest.Data;
using ConnectionTest.Service;
using Microsoft.AspNetCore.Mvc;

namespace ConnectionTest.Controllers
{
    [ApiController]
    [Route("users")]
    public class UserController : ControllerBase
    {
        private readonly UserService _userService;

        public UserController(UserService userService)
        {
            _userService = userService;
        }

        [HttpGet("{id}")]
        public ActionResult<User> GetUserById(int id)
        {
            var user = _userService.GetUserById(id);
     
            if (user == null)
            {
               

                return NotFound();
            }

            return user;
        }

        [HttpPost()]
        public ActionResult<User> CreateUser(User newUser)
        {
            var user = _userService.CreateUser(newUser);
            return user;
        }
    }
}
