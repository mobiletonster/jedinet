using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Owin.Security.Providers.Tony.Provider
{
    public class TonyAuthenticationProvider: ITonyAuthenticationProvider
    {
        public TonyAuthenticationProvider()
        {
            OnAuthenticated = context => Task.FromResult<object>(null);
            OnReturnEndpoint = context => Task.FromResult<object>(null);
        }

        public Func<TonyAuthenticatedContext, Task> OnAuthenticated { get; set; }
        public Func<TonyReturnEndpointContext, Task> OnReturnEndpoint { get; set; }

        public virtual Task Authenticated(TonyAuthenticatedContext context)
        {
            return OnAuthenticated(context);
        }

        public virtual Task ReturnEndpoint(TonyReturnEndpointContext context)
        {
            return OnReturnEndpoint(context);
        }
    }
}
