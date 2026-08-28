using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HalmolenCA.Api.Controllers.Facilities
{
    [Route("api/facilities")]
    [ApiController]
    public class FacilitiesController : ControllerBase
    {
        [HttpPost("floors")]
        public IActionResult CreateFloor()
        {
        
        }
    }
}
