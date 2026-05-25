using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecipeController : ControllerBase
    {
        private static List<Recipe> recipes = new List<Recipe>();
        [HttpGet]
        public List<Recipe> Get()
        {
            return recipes;
        }

        [HttpGet("GetRecipe")]
        public Recipe GetRecipe(int id) 
        {
            return recipes[id];
        }
        [HttpPost]
        public void Add([FromBody] Recipe recipe)
        {
            recipes.Add(recipe);
        }

    }
}
