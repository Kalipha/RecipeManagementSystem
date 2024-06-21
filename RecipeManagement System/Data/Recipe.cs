
namespace RecipeManagement_System.Data
{
 
    public class Recipe : BaseEntity
    {
        public int Id { get; set; }
        public string RecipeName { get; set; }
        public string Description { get; set; }
        public string Ingredient { get; set; }
        public string Procedure { get; set; }
        public int CategoryId { get; set; }
        public List<Category> Category { get; set; } = default;
    }
    
}
