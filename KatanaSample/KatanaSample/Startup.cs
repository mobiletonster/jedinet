using Owin;
using Owin.Security.Providers.TonyAuth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KatanaSample
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var options = new TonyAuthOptions();
            app.UseTonyAuth(options);

            //app.Run(context =>
            //{
            //    context.Response.ContentType =
            //    "text/plain";
            //    return context.Response.WriteAsync("Hello, world.");
            //});
        }

    }
}
