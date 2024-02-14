using Business.Abstract;
using Business.Concrete;
using Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ReactApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        IUserService userService;
        public UserController(IUserService _userService)
        {
            userService = _userService;
        }

        [HttpGet]
        public List<User> Get()
        {
            return userService.GetAllUser();
        }

        [HttpGet("{id}")]
        public User Get(int id)
        {
            return userService.GetUserById(id);
        }

        [HttpPost]
        public User Post([FromBody]User user)
        {
            return userService.CreateUser(user);
        }

        [HttpPut]
        public User Put([FromBody] User user)
        {
            return userService.UpdateUser(user);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            userService.DeleteUser(id);
        }
    }
}
