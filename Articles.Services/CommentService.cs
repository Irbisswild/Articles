using Articles.Services.Abstractions;
using Articles.Services.DAL.Abstractions.Repositories;
using Articles.Services.DTO;
using System;
using System.Threading.Tasks;
using DalDto = Articles.Services.DAL.DTO;

namespace Articles.Services
{
    public class CommentService : ICommentService
    {
        private readonly ICommentRepository _commentRepository;

        public CommentService(ICommentRepository commentRepository)
        {
            _commentRepository = commentRepository;
        }

        public Task CreateComment(Comment comment)
        {
            var commentMapped = Mapping.Mapper.Map<Comment, DalDto.Comment>(comment);

            return _commentRepository.CreateComment(commentMapped);
        }

        public async Task<Comment[]> GetAllArticleComments(Guid articleId)
        {
            var comments = await _commentRepository.GetAllArticleComments(articleId).ConfigureAwait(false);

            var commentsMapped = Mapping.Mapper.Map<DalDto.Comment[], Comment[]>(comments);

            return commentsMapped;
        }

        public Task<Comment> GetComment(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
