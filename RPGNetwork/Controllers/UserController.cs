using Microsoft.AspNetCore.Mvc;
using Project.Models;

namespace RPGNetwork.Controllers
{
    [ApiController]
    [Route("any")]
    public class UserController : ControllerBase
    {
        //private static User _user = new User();
        //to-do: make all async 

        [HttpPost("new")]
        public ActionResult<string> CreateUser()
        {
            return Created("", "User creation successful!");
        }

        [HttpGet]
        public ActionResult<string> GetUser(string name)
        {
            return new EmptyResult();
        }

        [HttpPut]
        public User UpdateUser([FromBody] User user)
        {
            return user;
        }

        [HttpDelete]
        public string DeleteUser([FromBody] User user)
        {
            return user.name;
        }



    }

}