﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Http;
using Microsoft.Framework.DependencyInjection;
using Microsoft.AspNet.Hosting;
using Microsoft.AspNet.StaticFiles;

namespace WebTemplate
{
    public class Startup
    {
        public Startup(IHostingEnvironment env)
        {

        }
        // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseStaticFiles();
            app.UseMvc(routes=> {
                routes.MapRoute("Angular",
                "{*url}",
                defaults: new { controller = "Angular",action="Get"});
            });           
            
             
        }
    }
}
