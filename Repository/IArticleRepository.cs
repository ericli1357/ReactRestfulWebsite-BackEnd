using ReactRestfulWebsite.Data;

namespace ReactRestfulWebsite.Repository
{
    public interface IArticleRepository
    {
        Task<List<Article>> GetAllArticles();
        Task<List<Article>> GetArticleByName(string categoryName);
    }
}
