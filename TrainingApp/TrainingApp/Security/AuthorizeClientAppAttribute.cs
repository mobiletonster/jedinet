using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace TrainingApp.Security
{
    public class AuthorizeClientAppAttribute : AuthorizationFilterAttribute
    {
        private const string TRAIN_SCHEME = "train_token";
        private const string TRAIN_API_KEY = "train_key";
        private const string TRAIN_TOKEN = "dHJhaW5fa2V5OkUzODUwNkRDLUQ4MUMtNEFGNC1CMUI2LTE1OTZFM0Y4RTEzMg==";
        private const string TRAIN_API_KEY_VALUE = "190060CD-B797-4543-8D81-71B4E30BC0CB";

        // use this API_KEY:  train_token dHJhaW5fa2V5OkUzODUwNkRDLUQ4MUMtNEFGNC1CMUI2LTE1OTZFM0Y4RTEzMg==

        public override void OnAuthorization(HttpActionContext actionContext)
        {
            var authHeader = actionContext.Request.Headers.Authorization;
            if (authHeader != null)
            {
                if (authHeader.Scheme == TRAIN_SCHEME)
                {
                    var rawCredentials = authHeader.Parameter;
                    var keyValue = CheckCredentials(rawCredentials);
                    if (!string.IsNullOrEmpty(keyValue))
                    {
                       

                        if(true!=true)
                        {
                            HandleForbidden(actionContext);
                        }
                            //Thread.CurrentPrincipal = new GenericPrincipal(new GenericIdentity(appuser.LdapKey, "LdapKey"), null);
                            //((ApiController)actionContext.ControllerContext.Controller).User = Thread.CurrentPrincipal;

                        return;


                    }

                }
            }

            HandleUnauthorized(actionContext);

        }

        private void HandleUnauthorized(HttpActionContext actionContext)
        {
            var req = actionContext.Request;
            actionContext.Response = req.CreateResponse(HttpStatusCode.Unauthorized);
            actionContext.Response.Headers.Add("WWW-Authenticate", "token Scheme='" + TRAIN_SCHEME + "' ");
        }

        private void HandleForbidden(HttpActionContext actionContext)
        {
            var req = actionContext.Request;
            actionContext.Response = req.CreateResponse(HttpStatusCode.Forbidden);
        }
        
        private string CheckCredentials(string rawCredentials)
        {
            try
            {
                var encoding = Encoding.GetEncoding("iso-8859-1");
                var credentials = encoding.GetString(Convert.FromBase64String(rawCredentials));
                var split = credentials.Split(':');
                var apiKey = split[0];
                var keyValue = split[1];
                if (apiKey == TRAIN_API_KEY)
                {
                    return keyValue;
                }

            }
            catch
            {
                // failed.
                return string.Empty;
            }
            return string.Empty;
        }

        // Use this to generate the token.
        private string GetCredentials()
        {
            var encoding = Encoding.GetEncoding("iso-8859-1");
            var credentials = TRAIN_API_KEY + ":" + TRAIN_API_KEY_VALUE;
            var credentialsBytes = encoding.GetBytes(credentials);
            var tokenized = Convert.ToBase64String(credentialsBytes);
            return tokenized;
        }
    }
}
