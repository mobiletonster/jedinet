using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Owin.Security.Providers.TonyAuth
{
    public static class TonyAuthExtensions
    {
        public static IAppBuilder UseTonyAuth(this IAppBuilder app, object options)
        {
            if(app== null)
            {
                throw new ArgumentNullException("app");
            }
            if (options == null)
            {
                throw new ArgumentNullException("options");
            }
            app.Use(typeof(TonyAuthMiddleware), app, options); //, app, options);
            return app;
        }
    }
}
