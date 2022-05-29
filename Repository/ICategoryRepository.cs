using ReactRestfulWebsite.Data;

namespace ReactRestfulWebsite.Repository
{
    public interface ICategoryRepository
    {
        Task<List<Category>> GetAllCategoriesAsync();
    }
}
