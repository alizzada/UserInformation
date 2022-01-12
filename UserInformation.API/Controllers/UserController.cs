using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UserInformation.Business.Abstract;
using UserInformation.Entities;

namespace UserInformation.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public List<User> GetAllUsers()
        {
            return _userService.GetAllUsers();
        }
    }
}
