using Microsoft.AspNetCore.Mvc;

namespace RecipeManagement_System.Controllers
{
    public class Auth : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult SignUp()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
    }
}
