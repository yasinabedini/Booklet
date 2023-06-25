using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using NikAmozBooklet.AAA.Models;
using System.Reflection.Metadata.Ecma335;

namespace NikAmozBooklet.AAA.Controllers
{
    public class User : Controller
    {
        private readonly UserManager<CustomUserIdentity> userManager;

        public User(UserManager<CustomUserIdentity> userManager)
        {
            this.userManager = userManager;
        }


        public IActionResult Index()
        {
            IEnumerable<CustomUserIdentity> userList = userManager.Users.ToList();
            return View(userList);            
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(CustomUserIdentity newUser)
        {
            if (ModelState.IsValid)
            {
                IdentityResult result = await userManager.CreateAsync(newUser);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index");
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }
            return View();
        }
    }
}
