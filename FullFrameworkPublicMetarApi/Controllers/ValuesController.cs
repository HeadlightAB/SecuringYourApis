using System.Collections.Generic;
using System.Web.Http;

namespace FullFrameworkPublicMetarApi.Controllers
{
    public class ValuesController : ApiController
    {
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        [Authorize]
        public string Get(int id)
        {
            return "value";
        }
    }
}
