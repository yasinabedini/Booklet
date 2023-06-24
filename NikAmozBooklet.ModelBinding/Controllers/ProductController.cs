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



        //we can Recive Collection From Model Binding
        [HttpPost]
        public IActionResult Register(Product product, [FromServices] MbDbContext context)
        {
            context.Products.Add(product);
            context.SaveChanges();
            return View(product);
        }


        [HttpGet]
        public async Task<IActionResult> RegisterManual()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> RegisterManual([FromServices] MbDbContext dbContext)
        {
            Product product = new Product();
            await TryUpdateModelAsync<Product>(product);
            dbContext.Products.Add(product);
            dbContext.SaveChanges();
            return View(product);
        }
    }
}
