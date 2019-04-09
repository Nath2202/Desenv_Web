using System;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using Microsoft.AspNetCore.Mvc.Filters;
using tecweb2.webapi.Models.Proxy;

namespace tecweb2.webapi.Extensions.Attributes
{
    public class ModelUserAttribute: ActionFilterAttribute
    {
        /// <summary>
        ///     Gets user information
        /// </summary>
        /// <param name="context">Context</param>
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            var keyValuePairs = context.ActionArguments.Where(y => y.Value is UserToken).ToList();

            if (!keyValuePairs.Any()) return;

            var substring = context.HttpContext.Request.Headers["Authorization"][0].Substring(7);

            var jwtSecurityToken = new JwtSecurityTokenHandler().ReadJwtToken(substring); 
            var id = Guid.Parse(jwtSecurityToken.Claims.FirstOrDefault(x => x.Type == ClaimTypes.Name)?.Value);
            var roles = jwtSecurityToken.Claims.Where(x => x.Type == ClaimTypes.Role).Select(x => x.Value);

            foreach (var pair in keyValuePairs)
                context.ActionArguments[pair.Key] = new UserToken
                {
                    Id = id,
                    Roles = roles
                };
        }
    }
}