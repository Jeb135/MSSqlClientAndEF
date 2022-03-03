using DAL;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace MSSqlClientAndEF.Controllers
{
    [RoutePrefix("Status")]
    public class StatusController : ApiController
    {
        public StatusController() { }

        [Route("Test")]
        [HttpGet]
        public int Test()
        {
            // Just use the console app for now. The ASP.NET aspect of this doesn't seem to be related.
            // Use this endpoint to test EF
            using (EFModels models = new EFModels())
            {
                List<Test> testEntities = models.Tests.Where(x => !string.IsNullOrWhiteSpace(x.TestString)).ToList();
            }

            return 1;
        }
    }
}
