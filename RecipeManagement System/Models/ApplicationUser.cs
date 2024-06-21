
namespace RecipeManagement_System.Models
{
    public class ApplicationUser
    {
        public string UserName { get; internal set; }

        public string Email { get; internal set; }

        public static explicit operator ApplicationUser(string v)
        {
            throw new NotImplementedException();
        }
    }
}
