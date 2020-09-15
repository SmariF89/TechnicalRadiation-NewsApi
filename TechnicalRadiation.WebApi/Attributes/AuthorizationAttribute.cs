using System;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;

namespace TechnicalRadiation.WebApi.Attributes
{
    public class AuthorizationAttribute : ActionFilterAttribute
    {
        private readonly string secretKey = "ARnarERBEstur";
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            if(!context.HttpContext.Request.Headers.Keys.Contains("Authorization") &&
               !context.HttpContext.Request.Headers.Values.Contains(secretKey)) {
                   context.Result = new StatusCodeResult(401);
            }
        }
    }
}