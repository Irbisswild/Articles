using Articles.Services.DAL.Abstractions.Repositories;
using Articles.Services.DAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities = Articles.Services.DAL.Entities;

namespace Articles.Services.DAL.Repositories
{
    public class ArticleRepository : IArticleRepository
    {
        private readonly Entities.Article[] _articles = new Entities.Article[]
        {
            new Entities.Article
            {
                Id = Guid.NewGuid(),
                Title = "Title 1",
                Content = "Content 1",
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            },
            new Entities.Article
            {
                Id = Guid.NewGuid(),
                Title = "Title 2",
                Content = "Content 3",
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            },
            new Entities.Article
            {
                Id = Guid.NewGuid(),
                Title = "Title 3",
                Content = "Content 3",
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            }
        };


        public Task CreateArticle(Article article)
        {
            throw new NotImplementedException();
        }

        public Task DeleteArticle(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<Article[]> GetAllArticles()
        {
            var articlesMapped = Mapping.Mapper.Map<Entities.Article[], Article[]>(_articles);

            var task = new TaskCompletionSource<Article[]>();

            task.SetResult(articlesMapped);

            return task.Task;
        }

        public Task<Article> GetArticle(Guid id)
        {
            var article = _articles.SingleOrDefault(a => a.Id == id);

            var articleMapped = Mapping.Mapper.Map<Entities.Article, Article>(article);

            var task = new TaskCompletionSource<Article>();

            task.SetResult(articleMapped);

            return task.Task;
        }

        public Task UpdateArticle(Article article)
        {
            throw new NotImplementedException();
        }
    }
}
