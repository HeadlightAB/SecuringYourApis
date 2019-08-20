using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace PublicMetarApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TafController : ControllerBase
    {
        [HttpGet("{icao}")]
        [Authorize("public.api.read")]
        public ActionResult<string> Get(string icao)
        {
            return "ESSA 201130Z 2012/2112 21014KT CAVOK PROB40 2012/2015 SCT040TCU PROB40 2015/2018 SCT050CB BECMG 2018/2020 19004KT TEMPO 2104/2107 BKN010";
        }

        [HttpPost]
        [WriteScopeRequired]
        public ActionResult Post()
        {
            return Ok();
        }
    }
}