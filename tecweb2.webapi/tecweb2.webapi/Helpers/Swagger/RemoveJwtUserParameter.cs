using System.Linq;
using Swashbuckle.AspNetCore.Swagger;
using Swashbuckle.AspNetCore.SwaggerGen;
using tecweb2.webapi.Models.Proxy;

namespace tecweb2.webapi.Helpers.Swagger
{
    /// <summary>
    /// Adds the option to put the student Ra in the header on methods that require it and
    /// removes the wrong Ra query parameter from the request.
    /// </summary>
    public class RemoveJwtUserParameter : IOperationFilter
    {
        public void Apply(Operation operation, OperationFilterContext context)
        {
            var par = context.ApiDescription.ParameterDescriptions.Where(a =>
                a.ModelMetadata.ContainerType == typeof(UserToken)).ToList();

            if (!par.Any())
                return;

            var removePar = operation.Parameters.Where(w => par.Any(a => a.Name == w.Name)).ToList();

            foreach (var b in removePar)
            {
                operation.Parameters.Remove(b);
            }
        }
    }
}