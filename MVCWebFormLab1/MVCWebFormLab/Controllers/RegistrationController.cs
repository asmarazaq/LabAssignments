using Microsoft.AspNetCore.Mvc;
using MVCWebFormLab.Models;

namespace MVCWebFormLab.Controllers
{
    public class RegistrationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(UserModel userModel)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }

            return RedirectToAction("Welcome", userModel);
        }

        //public IActionResult Welcome(UserModel userModel)
        //{
        //    //ViewBag.FirstName = firstName;
        //    return View(userModel);
        //}

        public IActionResult Welcome()
        {
            List<string> menuItems = new List<string>()
            {
                "Latte, $2.0",
                "Capuccino, $3.5",
                "Muffin, $4.6",
                "Croissant, $2.15",
                "Salad, $7.15",
                "Fruit Cup, $1.3",
                "chai, $2.2",
                "bagal, $3.1",
                "pastry, $4.2"

            };

            return View(menuItems);
        }
        public IActionResult ThankYou()
        {
            return View();
        }
    }
}
