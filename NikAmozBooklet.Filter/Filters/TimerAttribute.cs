using Microsoft.AspNetCore.Mvc.Filters;
using System.Diagnostics;

namespace NikAmozBooklet.Filter.Filters
{
    //action filter
    //زمانی که بخوایم یه کاری رو قبل و بعد از انجام اکشن انجام بدیم 
    public class TimerAttribute : ActionFilterAttribute
    {
        public Stopwatch MyTimer { get; set; } = new Stopwatch();
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            MyTimer.Start();
            Console.WriteLine("this Action was Started;");

        }

        public override void OnActionExecuted(ActionExecutedContext context)
        {
            MyTimer.Stop();
            Console.WriteLine($"exection time of this action : {MyTimer.ElapsedMilliseconds}");
        }
    }
}
