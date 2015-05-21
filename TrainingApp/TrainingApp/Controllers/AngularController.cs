using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace TrainingApp.Controllers
{
    public class AngularController : ApiController
    {
        // GET: Home
        public HttpResponseMessage Get()
        {
            var response = new HttpResponseMessage();
            response.Content = new StreamContent(File.Open(AppDomain.CurrentDomain.BaseDirectory + "WebApp/index.html", FileMode.Open));
            return response;
        }
    }
}