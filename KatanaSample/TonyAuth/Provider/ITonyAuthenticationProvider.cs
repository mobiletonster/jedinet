using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Owin.Security.Providers.Tony.Provider
{
    public interface ITonyAuthenticationProvider
    {
        Task Authenticated(TonyAuthenticatedContext context);
        Task ReturnEndpoint(TonyReturnEndpointContext context);
    }
}
