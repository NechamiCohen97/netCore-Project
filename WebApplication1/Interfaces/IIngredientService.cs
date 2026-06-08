using WebApplication1.Models;

namespace WebApplication1.interfaces
{
    public interface IIngredientService
    {
        void AddIngredient(Ingredient ingredient);
        void DeleteIngredient(Ingredient ingredient);
    }
}
