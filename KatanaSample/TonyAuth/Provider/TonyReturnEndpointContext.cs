using Microsoft.Owin;
using Microsoft.Owin.Security;
using Microsoft.Owin.Security.Provider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Owin.Security.Providers.Tony.Provider
{
    public class TonyReturnEndpointContext: ReturnEndpointContext
    {
        public TonyReturnEndpointContext(IOwinContext context, AuthenticationTicket ticket):base(context, ticket)
        {

        }
    }
}
