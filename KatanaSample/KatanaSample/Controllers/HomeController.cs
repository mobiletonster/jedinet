using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace KatanaSample.Controllers
{
    public class HomeController : ApiController
    {
        [Route("api/hello")]
        public string GetHello()
        {
            return "Hello everybody";
        }

        [Route("api/secure")]
        [Authorize]
        public string GetSecuredHello()
        {
            return "This is secured!";
        }
    }
}
