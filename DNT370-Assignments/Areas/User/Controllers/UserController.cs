using DNT370_Assignments.Areas.User.Models;
using Microsoft.AspNetCore.Mvc;

namespace DNT370_Assignments.Areas.User.Controllers
{
    [Area("User")]
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View("Login");
        }

        public IActionResult Dashboard(UserModel user)
        {
            if (ModelState.IsValid)
            {
                TempData["UserName"] = user.UserName;
            }
            return View("Index");
        }

        public IActionResult Profile(UserModel user)
        {
            if (ModelState.IsValid)
            {
                TempData["UserName"] = user.UserName;
            }
            return View("Profile");
        }
    }
}
