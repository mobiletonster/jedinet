using Microsoft.Owin;
using Microsoft.Owin.Logging;
using Microsoft.Owin.Security;
using Microsoft.Owin.Security.Infrastructure;
using Microsoft.Owin.Security.DataHandler;
using Microsoft.Owin.Security.DataProtection;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Owin.Security.Providers.TonyAuth
{
    public class TonyAuthMiddleware: AuthenticationMiddleware<TonyAuthOptions>
    {
        private readonly HttpClient httpClient;
        private readonly ILogger logger;
        public TonyAuthMiddleware(OwinMiddleware next, IAppBuilder app, TonyAuthOptions options):base(next,options)
        {
            if (String.IsNullOrWhiteSpace(Options.ClientId))
            {
                throw new ArgumentException(String.Format(CultureInfo.CurrentCulture, "Option must be provided {0}", "ClientId"));
            }

            if (String.IsNullOrWhiteSpace(Options.ClientSecret))
            {
                throw new ArgumentException(String.Format(CultureInfo.CurrentCulture, "Option must be provided {0}", "ClientSecret"));
            }

            logger = app.CreateLogger<TonyAuthMiddleware>();
        }

        protected override AuthenticationHandler<TonyAuthOptions> CreateHandler()
        {
            return new TonyAuthenticationHandler(httpClient, logger);
        }

    }
}
