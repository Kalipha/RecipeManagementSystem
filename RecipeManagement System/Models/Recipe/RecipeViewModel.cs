using RecipeManagement_System.Data;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;



namespace RecipeManagement_System.Models.Recipe
{
    public class RecipeViewModel:BaseEntity
    {
        [Display(Name = "Recipe Name")]
        [Required]
        public string RecipeName { get; set; }

        [Display(Name = "Recipe Description")]
        [Required]
        public string Description { get; set; }

        [Display(Name = "Ingredients")]
        [Required]
        public string Ingredients { get; set; } = default!;

        [Display(Name = "Procedure")]
        [Required]
        public String Procedure { get; set; }

        [Required]
        public Category Category { get; set; }
    }
}
