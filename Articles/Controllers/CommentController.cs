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
    public class CommentController : ControllerBase
    {
        private readonly ICommentService _commentService;

        public CommentController(ICommentService commentService)
        {
            _commentService = commentService;
        }

        [HttpGet("{articleId}")]
        public async Task<ActionResult<Comment[]>> Get(Guid articleId)
        {
            var articles = await _commentService.GetAllArticleComments(articleId);

            var res = Mapping.Mapper.Map<ServicesDto.Comment[], Comment[]>(articles);

            return Ok(res);
        }

        [HttpPost]
        public async void Post([FromBody] Comment comment)
        {
            var articleMapped = Mapping.Mapper.Map<Comment, ServicesDto.Comment>(comment);

            await _commentService.CreateComment(articleMapped);
        }
    }
}
