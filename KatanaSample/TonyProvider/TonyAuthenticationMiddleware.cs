using Microsoft.Owin.Security.Infrastructure;
using Microsoft.Owin.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using Microsoft.Owin;
using System.Globalization;
using Owin.Security.Providers.Tony.Provider;

namespace Owin.Security.Providers.Tony
{
    public class TonyAuthenticationMiddleware : AuthenticationMiddleware<TonyAuthenticationOptions>
    {
        private readonly HttpClient httpClient;
        private readonly ILogger logger;
        public TonyAuthenticationMiddleware(OwinMiddleware next, IAppBuilder app, TonyAuthenticationOptions options) : base(next, options)
        {
            if (String.IsNullOrWhiteSpace(Options.ClientId))
            {
                throw new ArgumentException(String.Format(CultureInfo.CurrentCulture, "Option must be provided {0}", "ClientId"));
            }

            if (String.IsNullOrWhiteSpace(Options.ClientSecret))
            {
                throw new ArgumentException(String.Format(CultureInfo.CurrentCulture, "Option must be provided {0}", "ClientSecret"));
            }

            logger = app.CreateLogger<TonyAuthenticationMiddleware>();

            if (Options.Provider == null)
            {
                Options.Provider = new TonyAuthenticationProvider();
            }

            //httpClient = new HttpClient(ResolveHttpMessageHandler(Options))
            //{
            //    Timeout = TimeSpan.FromSeconds(30),
            //    MaxResponseContentBufferSize = 1024 * 1024 * 10
            //};
            //httpClient.DefaultRequestHeaders.UserAgent.ParseAdd("Microsoft Owin Tony middleware");
            //httpClient.DefaultRequestHeaders.ExpectContinue = false;
        }

        protected override AuthenticationHandler<TonyAuthenticationOptions> CreateHandler()
        {
            return new TonyAuthenticationHandler(httpClient, logger);
        }

        private HttpMessageHandler ResolveHttpMessageHandler(TonyAuthenticationOptions options)
        {
            HttpMessageHandler handler = new HttpClientHandler();
            return handler;
        }

    }
}
