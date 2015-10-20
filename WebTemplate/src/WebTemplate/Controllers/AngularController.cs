using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using System.IO;
using Microsoft.AspNet.Http;
using Microsoft.AspNet.Hosting;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace WebTemplate.Controllers
{
    public class AngularController : Controller
    {
        // GET: api/values
        // [HttpGet]
        //[Route("{url}")]
        public IActionResult Get()
        {
            
            // return View("index.html");
            return File("index.html","text/html");
            
            //var response = this.Context.Response;
            

            //var fileStream = System.IO.File.Open(AppDomain.CurrentDomain.BaseDirectory + "index.html", FileMode.Open);
            //response.Body = fileStream;
            //return response;
        }
        //[HttpGet]
        //public HttpResponseMessage Get()
        //{
        //    var response = new HttpResponseMessage();
        //    response.Content = new StreamContent(File.Open(AppDomain.CurrentDomain.BaseDirectory + "index.html", FileMode.Open));
        //    return response;
        //}
    }
}

