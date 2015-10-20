using Microsoft.Owin.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Owin.Security.Providers.TonyAuth
{
    public class TonyAuthOptions: AuthenticationOptions
    {
        public TonyAuthOptions():base("TonyAuth")
        {

        }
    }
}
