using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace PublicMetarApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MetarController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        [HttpGet("{icao}")]
        public ActionResult<string> Get(string icao)
        {
            return "value";
        }
    }
}
