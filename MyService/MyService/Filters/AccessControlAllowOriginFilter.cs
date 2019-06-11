using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Filters;

namespace MyService.Filters
{
    public class AccessControlAllowOriginFilter : ActionFilterAttribute
    {
        public override void OnActionExecuted(HttpActionExecutedContext actionExecutedContext)
        {
            actionExecutedContext.Response.Content.Headers.Add("Access-Control-Allow-Origin", "*");

            if (HttpContext.Current.Request.HttpMethod == "OPTIONS")
            {
                //These headers are handling the "pre-flight" OPTIONS call sent by the browser
                actionExecutedContext.Response.Content.Headers.Add("Access-Control-Allow-Methods", "GET, POST, OPTIONS,PUT, DELETE");
                actionExecutedContext.Response.Content.Headers.Add("Access-Control-Allow-Headers", "Content-Type, Accept");
                actionExecutedContext.Response.Content.Headers.Add("Access-Control-Max-Age", "1728000");
            }
        }
    }
}