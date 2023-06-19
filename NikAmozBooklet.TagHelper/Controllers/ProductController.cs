using Microsoft.AspNetCore.Mvc;

namespace NikAmozBooklet.TagHelpers.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult List()
        {            
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }
    }
}
