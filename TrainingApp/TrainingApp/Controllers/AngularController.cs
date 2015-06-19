using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using System.Web.Http.Description;
using System.Web.Mvc;

namespace TrainingApp.Controllers
{
    [ApiExplorerSettings(IgnoreApi=true)]
    public class AngularController : ApiController
    {
        // GET: Home
        public HttpResponseMessage Get()
        {
            var response = new HttpResponseMessage();
            response.Content = new StreamContent(File.Open(AppDomain.CurrentDomain.BaseDirectory + "cdn.html", FileMode.Open));
            return response;
        }
    }
}