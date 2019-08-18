using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace PublicMetarApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TafController : ControllerBase
    {
        [HttpGet("{icao}")]
        [Authorize]
        public ActionResult<string> Get(string icao)
        {
            return "value";
        }
    }
}