using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IngredientController : ControllerBase
    {
        private static List<Ingredient> ingredients = new List<Ingredient>();

        [HttpPost]
        public void Add([FromBody]Ingredient ingredient)
        {
            ingredients.Add(ingredient);
        }
    }
}
