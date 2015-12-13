using Microsoft.Owin.Security.Google;
using Owin;
using Owin.Security.Providers.Tony;
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
            //var options = new TonyAuthenticationOptions("BobFredBob","SecretCombinations");
            //app.UseTonyAuthentication(options);

            //   AIzaSyDC1UiyKhhXId5DUvEVqkrNKNNndtH4KL4
            // var options = new GoogleAuthenticationOptions("729844026001 - a9e7nr1b27e6uicsu769q9nhsj9k95pt.apps.googleusercontent.com", "OH9VjWS4hvXb7Oxh-3S-wzMK");


            // 729844026001 - a9e7nr1b27e6uicsu769q9nhsj9k95pt.apps.googleusercontent.com

            // OH9VjWS4hvXb7Oxh-3S-wzMK 

            app.Properties["Microsoft.Owin.Security.Constants.DefaultSignInAsAuthenticationType"] = "ExternalCookie";

            var options = new GoogleOAuth2AuthenticationOptions();
            options.ClientId = "729844026001-pjpv7i3emrh6kqhuapc7leksev76rhna.apps.googleusercontent.com";
            options.ClientSecret = "5h3VOIiB49RkHL-_efHPcXBW";
            options.AuthenticationType = "Google OAuth";

            app.UseGoogleAuthentication(options);

            
        }

    }
}
