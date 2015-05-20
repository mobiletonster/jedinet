using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace TrainingApp
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //config.Routes.MapHttpRoute(
            //   name: "Default",
            //   routeTemplate: "{*url}",
            //   defaults: new { action = "Index.html" }
            //);

            routes.MapRoute(
    name: "NotDefault",
    url: "{controller}/{action}/{id}",
    defaults: new { action = "Index", id = UrlParameter.Optional }
);

            //All else falls through to our SPA routing done with Angular on the client end
           // routes.MapRoute(
           //    name: "Default",
           //    url: "{resource}",
           //    defaults: new { action = "index.html" }
           //);


        }
    }
}

