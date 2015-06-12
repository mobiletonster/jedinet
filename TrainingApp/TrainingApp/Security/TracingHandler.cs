using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TrainingApp.Security
{
    public class TracingHandler: DelegatingHandler
    {
        protected async override Task<HttpResponseMessage> SendAsync(
        HttpRequestMessage request, CancellationToken cancellationToken)
        {
            Debug.WriteLine("Process request " + request.RequestUri.AbsoluteUri);
                var response = await base.SendAsync(request, cancellationToken);
                Debug.WriteLine("Process response");
                return response;

            // Call the inner handler.

            //}
        }
    }


}
