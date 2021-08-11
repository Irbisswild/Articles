using AutoMapper;

namespace Articles.Services.DAL.Mapping
{
    public class CommentProfile : Profile
    {
        public CommentProfile()
        {
            CreateMap<DTO.Comment, Entities.Comment>();
            CreateMap<Entities.Comment, DTO.Comment>();
        }
    }
}
