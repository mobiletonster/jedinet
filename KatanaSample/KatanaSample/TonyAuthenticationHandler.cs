﻿using Microsoft.Owin.Logging;
using Microsoft.Owin.Security;
using Microsoft.Owin.Security.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Claims;
using System.Security.Principal;
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
            AuthenticationHeaderValue authorization = null;

            if (Request.Headers["authorization"] != null)
            {
                authorization = AuthenticationHeaderValue.Parse(Request.Headers["authorization"]);
            }

            if(authorization!= null)
            {
                var identity = new GenericIdentity("user");
                var principal = new GenericPrincipal(identity, null);

                var claimsIdentity = (ClaimsIdentity)((ClaimsPrincipal)principal).Identity;
                var ticket = new AuthenticationTicket(claimsIdentity, null);
                return ticket;
            }

            return EmptyTicket();

            
        }

        protected override Task ApplyResponseChallengeAsync()
        {
            if (Response.StatusCode != 401)
            {
                return Task.FromResult<object>(null);
            }
            string[] scheme = new string[1];
            scheme[0] = "TonyAuth Scheme is awesome";

            Response.Headers.Add("WWW-Authenticate", scheme);

            return base.ApplyResponseChallengeAsync();
        }


        private static AuthenticationTicket EmptyTicket()
        {
            return new AuthenticationTicket(null, null);
        }


    }
}
