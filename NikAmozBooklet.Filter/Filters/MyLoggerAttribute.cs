using Microsoft.AspNetCore.Mvc.Filters;

namespace NikAmozBooklet.Filter.Filters
{
    public class MyLoggerAttribute:ActionFilterAttribute
    {
        private readonly ILogger logger;

        public MyLoggerAttribute(ILogger logger)
        {
            this.logger = logger;
        }
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            logger.LogInformation("Log Sample");
        }
    }
}
