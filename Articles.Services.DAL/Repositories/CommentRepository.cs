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
    public class CommentRepository : ICommentRepository
    {
        public Task CreateComment(Comment comment)
        {
            throw new NotImplementedException();
        }

        public Task<Comment[]> GetAllArticleComments(Guid articleId)
        {
            throw new NotImplementedException();
        }

        public Task<Comment> GetComment(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
