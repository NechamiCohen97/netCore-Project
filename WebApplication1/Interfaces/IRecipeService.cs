using System.Collections.Generic;
using WebApplication1.Models;

namespace WebApplication1.interfaces
{
    public interface IRecipeService
    {
        List<Recipe> GetAllRecipes();
        Recipe GetRecipeById(int id);
        void AddRecipe(Recipe recipe);
    }
}