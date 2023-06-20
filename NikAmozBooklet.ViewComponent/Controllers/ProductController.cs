using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;

namespace NikAmozBooklet.ViewComponent.Controllers
{
    //الان هم میتوان به عنوان کنترلر هم ویو کامپوننت استفاده کرد 
    //[ViewComponent]
    public class ProductController : Controller
    {

        public IActionResult GetAllProduct()
        {
            return View();
        }

        // public void Invoke()
        // {            
        // }
    }
}
