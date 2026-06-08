namespace WebApplication1.Models
{
    public class DataContext
    {
        public List<Category> Categories { get; set; } = new List<Category>();
        public List<Ingredient> Ingredients { get; set; } = new List<Ingredient>();
        public List<Recipe> Recipes { get; set; } = new List<Recipe>();
    }
}
