using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebApplication1.interfaces;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecipeController : ControllerBase
    {
        private readonly IRecipeService _recipeService;

        public RecipeController(IRecipeService recipeService)
        {
            _recipeService = recipeService;
        }

        [HttpGet]
        public List<Recipe> Get()
        {
            return _recipeService.GetAllRecipes();
        }

        [HttpGet("GetRecipe")]
        public ActionResult<Recipe> GetRecipe(int id)
        {
            if (id < 0) 
                return BadRequest("מזהה לא תקין");

            var recipe = _recipeService.GetRecipeById(id);
            if (recipe == null) 
                return NotFound("המתכון לא נמצא");

            return Ok(recipe);
        }

        [HttpPost]
        public void Add([FromBody] Recipe recipe)
        {
            if (recipe == null) 
                return;

            _recipeService.AddRecipe(recipe);
        }
    }
}