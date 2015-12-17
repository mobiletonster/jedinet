using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Owin.Security.Providers.Tony
{
    public static class TonyAuthenticationExtensions
    {
        public static IAppBuilder UseTonyAuthentication(this IAppBuilder app, object options)
        {
            if (app == null)
            {
                throw new ArgumentNullException("app");
            }
            if (options == null)
            {
                throw new ArgumentNullException("options");
            }
            app.Use(typeof(TonyAuthenticationMiddleware), app, options); 
            return app;
        }
    }
}
