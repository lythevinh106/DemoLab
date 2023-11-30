using Microsoft.AspNetCore.Mvc;
using ProjectDemo.Models.Modules.User.Models;
using ProjectDemo.Services.Contracts;

namespace ProjectDemo.Controllers
{
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService) 
        {
            _userService = userService;
        }
        
        [HttpGet("{id}")]
        public IActionResult GetUserById(int id)
        {
            return Ok(_userService.GetUserById(id));
        }
    }
}
