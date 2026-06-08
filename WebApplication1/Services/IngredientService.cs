using WebApplication1.interfaces;
using WebApplication1.Models;

namespace WebApplication1.Services
{
    public class IngredientService : IIngredientService
    {
        private readonly DataContext _context;

        public IngredientService(DataContext context)
        {
            _context = context;
        }

        public void AddIngredient(Ingredient ingredient)
        {
            _context.Ingredients.Add(ingredient);
        }
        public void DeleteIngredient (Ingredient ingredient)
        {
            _context.Ingredients.Remove(ingredient);
        }
    }
}
