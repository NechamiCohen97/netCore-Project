using WebApplication1.Models;

namespace WebApplication1.interfaces
{
    public interface ICategoryService
    {
        List<Category> GetCategoriesByName(string name);
        void AddCategory(Category category);
        List<Category> GetAllCategories();
    }
}
