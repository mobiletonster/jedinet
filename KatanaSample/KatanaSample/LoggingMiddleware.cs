
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AppFunc = System.Func<System.Collections.Generic.IDictionary<string, object>, System.Threading.Tasks.Task>;

namespace KatanaSample
{
    public class LoggingMiddleware
    {
        private AppFunc next;
        public LoggingMiddleware()
        {

        }
        public LoggingMiddleware(AppFunc next)
        {
            Initialize(next);
        }
        public void Initialize(AppFunc next)
        {
            this.next = next;
        }

        public async Task Invoke(IDictionary<string, object> environment)
        {
            Console.WriteLine("Begin Request");
            await next.Invoke(environment);
            Console.WriteLine("End Request");
        }
    }
}
