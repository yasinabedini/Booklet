using Microsoft.AspNetCore.Mvc;
using NikAmozBooklet.Filter.Filters;

namespace NikAmozBooklet.Filter.Controllers
{
    public class PersonController : Controller
    {
        [MyHttpsFilter]

        //میتونیم به فیلتر ها ترتیب بدیم
        [Timer(Order =999)]        


        //خودش میاد و نمونه سازی مکنه و با استفاده از زیر ساخت وابستگی ها رو تزریق مکنه 
        [TypeFilter(typeof(MyLoggerAttribute))]


        //با این روش میتونیم مدیریت طول عمر رو خودمون بر عهده بگیریم و اگر وابستگی دیگری هم نیاز داشت خودمون محیا کنیم
        [ServiceFilter(typeof(GuidPrinterAttribute))]
        [ServiceFilter(typeof(GuidPrinterAttribute))]
        [ServiceFilter(typeof(GuidPrinterAttribute))]
        public IActionResult Index()
        {
            return View();
        }
    }
}
