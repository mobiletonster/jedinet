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
            var options = new TonyAuthenticationOptions("BobFredBob","SecretCombinations");
            app.UseTonyAuthentication(options);
        }

    }
}
