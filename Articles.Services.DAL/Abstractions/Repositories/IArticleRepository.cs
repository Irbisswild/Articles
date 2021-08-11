using Articles.Services.DAL.DTO;
using System;
using System.Threading.Tasks;

namespace Articles.Services.DAL.Abstractions.Repositories
{
    public interface IArticleRepository
    {
        Task<Article> GetArticle(Guid id);

        Task<Article[]> GetAllArticles();

        Task CreateArticle(Article article);

        Task UpdateArticle(Article article);

        Task DeleteArticle(Guid id);
    }
}
