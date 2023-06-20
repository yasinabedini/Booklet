using Microsoft.AspNetCore.Mvc;
using NikAmozBooklet.ModelBinding.Models;

namespace NikAmozBooklet.ModelBinding.Controllers
{
    public class ProductController : Controller
    {        

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Register(Product product, [FromServices]MbDbContext context)
        {
            context.Products.Add(product);
            context.SaveChanges();
            return View(product);
        }
    }
}
