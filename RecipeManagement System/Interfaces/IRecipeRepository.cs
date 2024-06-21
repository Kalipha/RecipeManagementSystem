using RecipeManagement_System.Data;

namespace RecipeManagement_System.Interfaces
{
    public interface IRecipeRepository
    {


        Recipe Create(Recipe recipe);
        Recipe GetById(int id);
        List<Recipe> GetAll();
        Recipe Update(int id);
        bool Delete(int id);
        bool RecipeExist(int id);
        bool RecipeExist(string name);

    }
}
