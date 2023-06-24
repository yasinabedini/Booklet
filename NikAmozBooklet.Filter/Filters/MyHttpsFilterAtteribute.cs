using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace NikAmozBooklet.Filter.Filters
{
    //1. AuthorizationFilter
    public class MyHttpsFilterAttribute : Attribute,IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            if (!context.HttpContext.Request.IsHttps)
            {
                context.Result = new StatusCodeResult(StatusCodes.Status500InternalServerError);
            }            
        }
    }
}
