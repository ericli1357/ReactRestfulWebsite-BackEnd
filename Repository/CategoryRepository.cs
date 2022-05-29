using Microsoft.EntityFrameworkCore;
using ReactRestfulWebsite.Data;

namespace ReactRestfulWebsite.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ReactRestfulWebsiteContext _context;

        public CategoryRepository(ReactRestfulWebsiteContext context)
        {
            _context = context;
        }

        public async Task<List<Category>> GetAllCategoriesAsync()
        {
            var records=await _context.Category.Select(x=>new Category()
            {
                 CategoryId = x.CategoryId,
                 CategoryName = x.CategoryName
            }).ToListAsync();
            return records;
        }
    }
}
