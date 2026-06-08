using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.interfaces;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;
        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        [HttpGet("GetCategory")]
        public List<Category> GetCategory (string name)
        {
            if (string.IsNullOrEmpty(name)) 
                return new List<Category>();
            return _categoryService.GetCategoriesByName(name);
        }
        [HttpGet]
        public List<Category> Get()
        {
            return _categoryService.GetAllCategories();
        }
        [HttpPost]
        public void Add([FromBody] Category category)
        {
            _categoryService.AddCategory(category);
        }


    }
}
