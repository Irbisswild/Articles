using Articles.Services.DTO;
using System;
using System.Threading.Tasks;

namespace Articles.Services.Abstractions
{
    public interface ICommentService
    {
        Task<Comment> GetComment(Guid id);

        Task<Comment[]> GetAllArticleComments(Guid articleId);

        Task CreateComment(Comment comment);
    }
}
