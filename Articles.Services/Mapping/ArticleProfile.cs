using AutoMapper;
using DalDto = Articles.Services.DAL.DTO;

namespace Articles.Services.Mapping
{
    public class ArticleProfile : Profile
    {
        public ArticleProfile()
        {
            CreateMap<DTO.Article, DalDto.Article>();
            CreateMap<DalDto.Article, DTO.Article>();
        }
    }
}
