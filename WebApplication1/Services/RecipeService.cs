using System.Collections.Generic;
using System.Linq;
using WebApplication1.interfaces;
using WebApplication1.Models;

namespace WebApplication1.Services
{
    public class RecipeService : IRecipeService
    {
        private readonly DataContext _context;

        public RecipeService(DataContext context)
        {
            _context = context;
        }

        public List<Recipe> GetAllRecipes()
        {
            return _context.Recipes;
        }

        public Recipe GetRecipeById(int id)
        {
            return _context.Recipes.FirstOrDefault(r => r.Id == id);
        }

        public void AddRecipe(Recipe recipe)
        {
            _context.Recipes.Add(recipe);
        }
    }
}