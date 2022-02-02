using Microsoft.AspNetCore.Mvc;
using internship_api.Models.user;

namespace internship_api.Controllers.user
{

    [ApiController]
    [Route("api/users")]
    public class UserController : ControllerBase
    {
        public ActionResult<IEnumerable<User>> Get()
        {
            IEnumerable<User> users = new List<User>(){
                new User{
                    Name="Romdon",
                    LastName="Uma"
                },
                new User{
                    Name="Kim",
                    LastName="Wang"
                }
            };

            return Ok(users);
        }
    }
}