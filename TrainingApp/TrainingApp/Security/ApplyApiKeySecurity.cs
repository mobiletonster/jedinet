using Swashbuckle.Swagger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Filters;

namespace TrainingApp.Security
{
    public class ApplyApiKeySecurity : IDocumentFilter, IOperationFilter
    {
        public string Description { get; private set; }
        public string In { get; private set; }
        public string Key { get; private set; }
        public string Name { get; private set; }

        public ApplyApiKeySecurity(string key, string name, string description, string @in)
        {
            Key = key;
            Name = name;
            Description = description;
            In = @in;
        }
        public void Apply(SwaggerDocument swaggerDoc, SchemaRegistry schemaRegistry, System.Web.Http.Description.IApiExplorer apiExplorer)
        {
            IList<IDictionary<string, IEnumerable<string>>> security = new List<IDictionary<string, IEnumerable<string>>>();
            security.Add(new Dictionary<string, IEnumerable<string>> {
            {Key, new string[0]}
        });

            swaggerDoc.security = security;

        }

        public void Apply(Operation operation, SchemaRegistry schemaRegistry, System.Web.Http.Description.ApiDescription apiDescription)
        {
            var filterPipeline = apiDescription.ActionDescriptor.GetFilterPipeline();
            var isAuthorized = filterPipeline
                                             .Select(filterInfo => filterInfo.Instance)
                                             .Any(filter => filter is IAuthorizationFilter);

            var allowAnonymous = apiDescription.ActionDescriptor.GetCustomAttributes<AllowAnonymousAttribute>().Any();

            if(isAuthorized && !allowAnonymous){
            operation.parameters = operation.parameters ?? new List<Parameter>();
            operation.parameters.Add(new Parameter
            {
                name = Name,
                description = Description,
                @in = In,
                required = true,
                type = "string"
            });
            }
        }

        public void Apply(Swashbuckle.Application.SwaggerDocsConfig c)
        {
            c.ApiKey(Key)
                .Name(Name)
                .Description(Description)
                .In(In);
            c.DocumentFilter(() => this);
            c.OperationFilter(() => this);
        }


    }
}
