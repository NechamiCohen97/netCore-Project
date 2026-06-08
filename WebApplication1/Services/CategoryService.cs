using WebApplication1.interfaces;
using WebApplication1.Models;

namespace WebApplication1.Services
{
    public class CategoryService: ICategoryService
    {
        private readonly DataContext _context;
        public CategoryService(DataContext context)
        {
            _context = context;
        }

        public List<Category> GetCategoriesByName(string name)
        {
            return _context.Categories.Where(w => w.Name.Contains(name)).ToList();
        }
        public List<Category> GetAllCategories()
        {
            return _context.Categories;
        }

        public void AddCategory(Category category)
        {
            _context.Categories.Add(category);
        }

    }
}
