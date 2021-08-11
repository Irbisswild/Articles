using Articles.Services.Abstractions;
using Articles.Services.DAL.Abstractions.Repositories;
using Articles.Services.DTO;
using System;
using System.Threading.Tasks;
using DalDto = Articles.Services.DAL.DTO;

namespace Articles.Services
{
    public class ArticleService : IArticleService
    {
        private readonly IArticleRepository _articleRepository;

        public ArticleService(IArticleRepository articleRepository)
        {
            _articleRepository = articleRepository;
        }

        public Task CreateArticle(Article article)
        {
            var commentMapped = Mapping.Mapper.Map<Article, DalDto.Article>(article);

            return _articleRepository.CreateArticle(commentMapped);
        }

        public Task DeleteArticle(Guid id)
        {
            return _articleRepository.DeleteArticle(id);
        }

        public async Task<Article[]> GetAllArticles()
        {
            var articles = await _articleRepository.GetAllArticles().ConfigureAwait(false);

            var articlesMapped = Mapping.Mapper.Map<DalDto.Article[], Article[]>(articles);

            return articlesMapped;
        }

        public async Task<Article> GetArticle(Guid id)
        {
            var article = await _articleRepository.GetArticle(id).ConfigureAwait(false);

            var articleMapped = Mapping.Mapper.Map<DalDto.Article, Article>(article);

            return articleMapped;
        }

        public Task UpdateArticle(Article article)
        {
            var articleMapped = Mapping.Mapper.Map<Article, DalDto.Article>(article);

            return _articleRepository.UpdateArticle(articleMapped);
        }
    }
}
