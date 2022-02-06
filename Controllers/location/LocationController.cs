using Microsoft.AspNetCore.Mvc;
using internship_api.Models.locations.thLocation;
using internship_api.Models.locations.thLocation.model;
using internship_api.Models.locations.thLocation.param;

namespace internship_api.Controllers.product
{
    [Route("api/locations")]
    [ApiController]
    public class LocationController : ControllerBase
    {
        private readonly IThLocation locRepo;
        public LocationController(IThLocation locRepo)
        {
            this.locRepo = locRepo;
        }


        [HttpGet]
        public ActionResult<IEnumerable<ThLocationModel>> Get([FromQuery] GetParam param)
        {
            IEnumerable<ThLocationModel> models = locRepo.GetRangeFromParam(param);
            return Ok(models);
        }
        
    }
}