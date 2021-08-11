using AutoMapper;
using ServicesDto = Articles.Services.DTO;

namespace Articles.Mapping
{
    public class CommentProfile : Profile
    {
        public CommentProfile()
        {
            CreateMap<Models.Comment, ServicesDto.Comment>();
            CreateMap<ServicesDto.Comment, Models.Comment>();
        }
    }
}
