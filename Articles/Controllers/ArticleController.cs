using Articles.Filters;
using Articles.Models;
using Articles.Services.Abstractions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using ServicesDto = Articles.Services.DTO;


namespace Articles.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    [TypeFilter(typeof(CustomExceptionFilter))]
    public class ArticleController : ControllerBase
    {
        private readonly IArticleService _articleService;
        public ArticleController(IArticleService articleService)
        {
            _articleService = articleService;
        }

        [HttpGet]
        public async Task<ActionResult<Article[]>> Get()
        {
            var articles = await _articleService.GetAllArticles();

            var res = Mapping.Mapper.Map<ServicesDto.Article[], Article[]>(articles);

            return Ok(res);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Article>> Get(Guid id)
        {
            var articles = await _articleService.GetArticle(id);

            var res = Mapping.Mapper.Map<ServicesDto.Article, Article>(articles);

            return Ok(res);
        }

        [HttpPost]
        public async void Post([FromBody] Article article)
        {
            var articleMapped = Mapping.Mapper.Map<Article, ServicesDto.Article>(article);

            await _articleService.CreateArticle(articleMapped);
        }

        [HttpPut()]
        public async void Put([FromBody] Article article)
        {
            var articleMapped = Mapping.Mapper.Map<Article, ServicesDto.Article>(article);

            await _articleService.UpdateArticle(articleMapped);
        }

        [HttpDelete("{id}")]
        public async void Delete(Guid id)
        {
            await _articleService.DeleteArticle(id);
        }
    }
}
