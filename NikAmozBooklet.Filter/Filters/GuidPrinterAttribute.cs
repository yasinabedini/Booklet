using Microsoft.AspNetCore.Mvc.Filters;

namespace NikAmozBooklet.Filter.Filters
{
    public class GuidPrinterAttribute:ActionFilterAttribute
    {
        public string MyGuid { get; set; } = Guid.NewGuid().ToString();
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            Console.WriteLine(MyGuid);
        }
    }
}
