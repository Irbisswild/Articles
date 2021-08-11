using AutoMapper;
using DalDto = Articles.Services.DAL.DTO;

namespace Articles.Services.Mapping
{
    public class CommentProfile : Profile
    {
        public CommentProfile()
        {
            CreateMap<DTO.Comment, DalDto.Comment>();
            CreateMap<DalDto.Comment, DTO.Comment>();
        }
    }
}
