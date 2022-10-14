using DNT370_Assignments.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;

namespace DNT370_Assignments.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        
        public IActionResult Login()
        {
            
            return View("Login");
        }

        public IActionResult Dashboard(AdminModel admin)
        {
            if (ModelState.IsValid)
            {
                TempData["UserName"] = admin.UserName;                
            }
            return View("Index");
        }

        public IActionResult Profile(AdminModel admin)
        {
            if (ModelState.IsValid)
            {
                TempData["UserName"] = admin.UserName;
            }
            return View("Profile");
        }
    }
}
