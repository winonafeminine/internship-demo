using Microsoft.AspNetCore.Mvc;
using internship_api.Models.user;
using internship_api.Models.user.model;
using internship_api.Models.user.route;
using internship_api.Models;

namespace internship_api.Controllers.user
{

    [ApiController]
    [Route("api/users")]
    public class UserController : ControllerBase
    {
        private readonly IUser userRepo;
        public UserController(IUser userRepo)
        {
            this.userRepo = userRepo;
        }


        // add new user to db
        // take 2 required props
        // Name, LastName
        [HttpPost]
        public async Task<ActionResult<Res>> Post([FromBody] AddModel model)
        {
            Res res = await userRepo.AddAsync(model);
            return Ok(res);
        }
        

        // get the user by name

        [Route("{name}")]
        [HttpGet]
        public async Task<ActionResult<UserModel>> Get([FromRoute] GetRoute route)
        {
            UserModel model = await userRepo.GetAsync(route);

            if(model.UserId == null)
                return NoContent();

            return Ok(model);
        }

        

        public ActionResult<IEnumerable<UserModel>> Get()
        {
            IEnumerable<UserModel> models = userRepo.GetRange();

            return Ok(models);
        }
    }
}