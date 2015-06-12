using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Routing;
using System.IO;

namespace TrainingApp
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected async void Application_Start()
        {
            HttpClient client = new HttpClient();
            //https://edge.ldscdn.org/cdn2/esm/csa/index.html
            var index = await client.GetStreamAsync("https://tonyshare.blob.core.windows.net/tony-cdn/good.html"); // https://tonyshare.blob.core.windows.net/tony-cdn/good.html");
            var file = File.Create(AppDomain.CurrentDomain.BaseDirectory + "cdn.html");
            index.CopyTo(file);
            file.Close();
            GlobalConfiguration.Configure(WebApiConfig.Register);
        }
    }
}
