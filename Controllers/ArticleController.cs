using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ReactRestfulWebsite.Repository;

namespace ReactRestfulWebsite.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticleController : ControllerBase
    {
        private readonly IArticleRepository _articleRepository;

        public ArticleController(IArticleRepository articleRepository)
        {
            _articleRepository = articleRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllArticles()
        {
            var articles=await _articleRepository.GetAllArticles();
            return Ok(articles);
        }

        [HttpGet("getArticleByCategory/{CategoryName}")]
        public async Task<IActionResult> GetArticleByCategory(string categoryName)
        {
            var articles = await _articleRepository.GetAllArticles();
            return Ok(articles);
        }
    }
}
