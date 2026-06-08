using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.interfaces;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IngredientController : ControllerBase
    {
        private readonly IIngredientService _ingredientService;
        public IngredientController(IIngredientService ingredientService)
        {
            _ingredientService = ingredientService;
        }

        [HttpPost]
        public void Add([FromBody]Ingredient ingredient)
        {
            if (ingredient == null) 
                return;
            _ingredientService.AddIngredient(ingredient);
        }
        [HttpDelete]
        public void Delete([FromBody] Ingredient ingredient)
        {
            if (ingredient == null)
                return;
            _ingredientService.DeleteIngredient(ingredient);
        }
    }
}
