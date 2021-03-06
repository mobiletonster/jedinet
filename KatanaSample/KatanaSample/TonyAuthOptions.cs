﻿using Microsoft.Owin.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Owin.Security.Providers.TonyAuth
{
    public class TonyAuthOptions: AuthenticationOptions
    {
        public string ClientId { get; set; }
        public string ClientSecret { get; set; }
        public TonyAuthOptions():base("TonyAuth")
        {
            AuthenticationMode = Microsoft.Owin.Security.AuthenticationMode.Passive;
        }

        public TonyAuthOptions(string clientId, string clientSecret):base("TonyAuth")
        {
            ClientId = clientId;
            ClientSecret = clientSecret;
            AuthenticationMode = Microsoft.Owin.Security.AuthenticationMode.Passive;
        }
    }
}
