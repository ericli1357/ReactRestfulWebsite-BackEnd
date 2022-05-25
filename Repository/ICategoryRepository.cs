using ReactRestfulWebsite.Models;

namespace ReactRestfulWebsite.Repository
{
    public interface ICategoryRepository
    {
        Task<List<CategoryModel>> GetAllCategoriesAsync();
    }
}
