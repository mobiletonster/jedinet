using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using TrainingApp.Security;

namespace TrainingApp
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            config.Formatters.JsonFormatter.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();

            config.MessageHandlers.Add(new TracingHandler());

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            // Default Routes
            config.Routes.MapHttpRoute(
                name: "ExtensionlessDefault",
                routeTemplate: "",
                defaults: new { controller="Angular" }
            );
            config.Routes.MapHttpRoute(
                name: "AngularDefault",
                routeTemplate: "{url}",
                defaults: new { controller = "Angular" }
            );


            //,
            //constraints: null,
            //    handler:
            //new AngularHandler(GlobalConfiguration.Configuration)

            //config.Routes.MapHttpRoute(
            //   name: "Default",
            //   routeTemplate: "{*url}",
            //   defaults: new { action = "Index.html" }
            //);
        }
    }
}
