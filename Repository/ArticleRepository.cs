using Microsoft.EntityFrameworkCore;
using ReactRestfulWebsite.Data;

namespace ReactRestfulWebsite.Repository
{
    public class ArticleRepository : IArticleRepository
    {
        private readonly ReactRestfulWebsiteContext _context;

        public ArticleRepository(ReactRestfulWebsiteContext context)
        {
            _context = context;
        }

        public async Task<List<Article>> GetAllArticles() {
            var records = await _context.Article.Select(x => new Article
            {
                ArticleId = x.ArticleId,
                Title = x.Title,
                Body = x.Body,
                DatePublished = x.DatePublished,
            }).ToListAsync();
            return records;
        }
        public async Task<List<Article>> GetArticleByName(string categoryName)
        {
            var records = await _context.Article.Where(x=>x.Title==categoryName).Select(x => new Article
            {
                ArticleId = x.ArticleId,
                Title = x.Title,
                Body = x.Body,
                DatePublished = x.DatePublished,
            }).ToListAsync();
            return records;
        }
    }
}
