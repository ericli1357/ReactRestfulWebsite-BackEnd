using Microsoft.EntityFrameworkCore;
using ReactRestfulWebsite.Data;
using ReactRestfulWebsite.Models;

namespace ReactRestfulWebsite.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ReactRestfulWebsiteContext _context;

        public CategoryRepository(ReactRestfulWebsiteContext context)
        {
            _context = context;
        }

        public async Task<List<CategoryModel>> GetAllCategoriesAsync()
        {
            var records=await _context.Category.Select(x=>new CategoryModel()
            {
                 CategoryId = x.CategoryId,
                 CategoryName = x.CategoryName
            }).ToListAsync();
            return records;
        }
    }
}
