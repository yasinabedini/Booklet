using Microsoft.AspNetCore.Mvc;
using NikAmozBooklet.ModelValidation.Models;

namespace NikAmozBooklet.ModelValidation.Contorllers
{
    public class ProductController : Controller
    {
        public static List<Product> Products { get; set; } = new List<Product>();

        public IActionResult Index()
        {
            return View(Products);
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(Product product)
        {
            if (ModelState.IsValid) Products.Add(product);

            return View();
        }

        public bool checkName(string name)
        {
            if (name.Length>5)
            {
                return true;
            }
            return false;
        }
     
    }
}
