using Microsoft.Owin.Security;
using Owin.Security.Providers.Tony.Provider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Owin.Security.Providers.Tony
{
    public class TonyAuthenticationOptions : AuthenticationOptions
    {
        public string ClientId { get; set; }
        public string ClientSecret { get; set; }
        public ITonyAuthenticationProvider Provider { get; set; }
        public TonyAuthenticationOptions() : base("Tony")
        {
            AuthenticationMode = Microsoft.Owin.Security.AuthenticationMode.Passive;
        }

        public TonyAuthenticationOptions(string clientId, string clientSecret) : base("Tony")
        {
            ClientId = clientId;
            ClientSecret = clientSecret;
            AuthenticationMode = Microsoft.Owin.Security.AuthenticationMode.Passive;
        }
    }
}
