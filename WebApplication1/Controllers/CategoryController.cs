using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private static List<Category> categories = new List<Category>();

        [HttpGet("GetCategory")]
        public List<Category> GetCategory (string name)
        {
            return categories.Where(w => w.Name.Contains(name)).ToList();
        }
        [HttpPost]
        public void Add([FromBody] Category category)
        {
            categories.Add(category);
        }


    }
}
