using AspNetCoreHero.ToastNotification.Abstractions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RecipeManagement_System.Context;
using RecipeManagement_System.Data;
using RecipeManagement_System.Models.Recipe;
using System.Linq;
using System.Threading.Tasks;

namespace RecipeManagement_System.Controllers
{
    public class RecipeController : Controller
    {
        private readonly INotyfService _notyfService;
        private readonly RMSDbContext _rmsDbContext;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public RecipeController(
            INotyfService notyf,
            RMSDbContext rmsDbContext,
            IHttpContextAccessor httpContextAccessor)
        {
            _notyfService = notyf;
            _rmsDbContext = rmsDbContext;
            _httpContextAccessor = httpContextAccessor;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            ViewBag.Categories = _rmsDbContext.Categories.ToList();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(RecipeViewModel model)
        {
            if (ModelState.IsValid)
            {
                var newRecipe = new Recipe
                {
                    RecipeName = model.RecipeName,
                    Ingredient = model.Ingredients,
                    Description = model.Description,
                    Procedure = model.Procedure,
                    CategoryId = model.CategoryId,
                };
                                
                _rmsDbContext.Recipes.Add(newRecipe);
                await _rmsDbContext.SaveChangesAsync();

                _notyfService.Success("Recipe created successfully!");

                return RedirectToAction("Index");
            }
            ViewBag.Categories = _rmsDbContext.Categories.ToList();
            return View(model);
        }

    }
}
