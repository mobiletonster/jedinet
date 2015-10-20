using Microsoft.Owin.Logging;
using Microsoft.Owin.Security;
using Microsoft.Owin.Security.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Owin.Security.Providers.TonyAuth
{
    public class TonyAuthenticationHandler: AuthenticationHandler<TonyAuthOptions>
    {
        private readonly ILogger logger;
        private readonly HttpClient httpClient;
        public TonyAuthenticationHandler(HttpClient httpClient, ILogger logger)
        {
            this.httpClient = httpClient;
            this.logger = logger;
        }

        protected override async Task<AuthenticationTicket> AuthenticateCoreAsync()
        {
            // AuthenticationProperties properties = null;

            return new AuthenticationTicket(null, null);
        }
    }
}
