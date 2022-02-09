using Microsoft.AspNetCore.Mvc;
using internship_api.Models.landing;
namespace internship_api.Controllers.landing
{
    [Route("api/[controller]")]
    [ApiController]
    public class LandingController : ControllerBase
    {

      public IEnumerable<Landing> Get()
      {
        IEnumerable<Landing> landings = new List<Landing>(){
            new Landing 
            {
                LandingName = "Spray",
                LandingDescription = "Spray2spray"
            },
            new Landing 
            {
                LandingName = "Barsoap",
                LandingDescription = "Barsoap2Barsoap"
            },

            

        } ;
        return  landings;
      }

      [Route("{name}")]
        [HttpGet]
        public Landing? Get([FromRoute] string? name)
        {
            IEnumerable<Landing> landings = new List<Landing>(){
                new Landing{
                    LandingName="Barsoap",
                    LandingDescription="Barsoap2Barsoap"
                },
                new Landing{
                    LandingName="Spray",
                   LandingDescription="Spray2spray"
                },
            };


            Landing? landing = landings.Where(p => p.LandingName == name).FirstOrDefault();

            return landing;
        }
      

    }
}