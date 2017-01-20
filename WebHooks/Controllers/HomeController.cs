using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebHooks.Controllers
{
    [RoutePrefix("home")]
    public class HomeController : ApiController
    {
        [Route("teste")]
        [HttpGet]
        public HttpResponseMessage teste()
        {
            return Request.CreateResponse(HttpStatusCode.OK, "OK");
        }
    }
}
