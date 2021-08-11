using Articles.Services.DAL.DTO;
using System;
using System.Threading.Tasks;

namespace Articles.Services.DAL.Abstractions.Repositories
{
    public interface ICommentRepository
    {
        Task<Comment> GetComment(Guid id);

        Task<Comment[]> GetAllArticleComments(Guid articleId);

        Task CreateComment(Comment comment);
    }
}
