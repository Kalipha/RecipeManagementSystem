using Microsoft.AspNetCore.Mvc;

namespace RecipeManagement_System.Controllers
{
    public class RecipeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Recipe()
        {
            return View();
        }
    }
}
