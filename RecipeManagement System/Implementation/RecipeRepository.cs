using RecipeManagement_System.Context;
using RecipeManagement_System.Data;

namespace RecipeManagement_System.Implementation
{
    public class RecipeRepository
    {
        private readonly RMSDbContext _context;
        public RecipeRepository(RMSDbContext context)
        {
            _context = context;
        }

        public bool RecipeExist(int id)
        {
            return _context.Recipes.Any(rms => rms.Id == id);
        }

        public bool RecipetExist(string name)
        {
            return _context.Recipes.Any(rms => rms.RecipeName == name);
        }
        public Recipe Create(Recipe recipe)
        {
            _context.Recipes.Add(recipe);
            _context.SaveChanges();
            return recipe;
        }
        public bool Delete(int Id)
        {
            var recipe = GetById(Id);
            _context.Recipes.Remove(recipe);
            _context.SaveChanges();
            return true;

        }

        private Recipe GetById(int id)
        {
            var Recipe = _context.Recipes.FirstOrDefault(rms => rms.Id == id);
            return Recipe;
        }
        public List<Recipe> GetAll()
        {
            var recipes = _context.Recipes.Select(rms => new Recipe
            {
                Id = rms.Id,
                RecipeName = rms.RecipeName,
                Description = rms.Description
            }).ToList();
            return recipes;
        }
        public Recipe Update(int id)
        {
            var recipe = GetById(id);
            _context.Recipes.Update(recipe);
            _context.SaveChanges();
            return recipe;
        }
    }
}
