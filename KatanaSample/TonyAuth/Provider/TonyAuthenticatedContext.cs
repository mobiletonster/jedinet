using Microsoft.Owin;
using Microsoft.Owin.Security.Provider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using System.Security.Claims;
using Microsoft.Owin.Security;

namespace Owin.Security.Providers.Tony.Provider
{
    public class TonyAuthenticatedContext: BaseContext
    {
        public TonyAuthenticatedContext(IOwinContext context, JObject user, string accessToken):base(context)
        {
            User = user;
            AccessToken = accessToken;
            UserId = TryGetValue(user, "userId");
            UserName = TryGetValue(user, "user");
        }

        public JObject User { get; private set; }
        public string AccessToken { get; private set; }
        public string UserId { get; private set; }
        public string UserName { get; private set; }
        public ClaimsIdentity Identity { get; set; }
        public AuthenticationProperties Properties { get; set; }

        private static string TryGetValue(JObject user, string propertyName)
        {
            JToken value;
            return user.TryGetValue(propertyName, out value) ? value.ToString() : null;
        }
    }
}
