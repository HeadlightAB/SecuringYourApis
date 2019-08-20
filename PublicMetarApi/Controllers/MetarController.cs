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
            return new[]
            {
                "ESOE 201720Z 21010KT 9999 VCSH SCT055CB 18/10 Q1017",
                "ESMQ 201720Z 22002KT 9999 FEW039CB 16/15 Q1020"
            };
        }

        [HttpGet("{icao}")]
        public ActionResult<string> Get(string icao)
        {
            return "ESSA 201720Z 18010KT CAVOK 18/10 Q1016 NOSIG";
        }
    }
}
