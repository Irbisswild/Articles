using Articles.Services.DTO;
using System;
using System.Threading.Tasks;

namespace Articles.Services.Abstractions
{
    public interface IArticleService
    {
        Task<Article> GetArticle(Guid id);

        Task<Article[]> GetAllArticles();

        Task CreateArticle(Article article);

        Task UpdateArticle(Article article);

        Task DeleteArticle(Guid id);
    }
}
