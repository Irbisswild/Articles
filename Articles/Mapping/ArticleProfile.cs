using AutoMapper;
using ServicesDto = Articles.Services.DTO;

namespace Articles.Mapping
{
    public class ArticleProfile : Profile
    {
        public ArticleProfile()
        {
            CreateMap<Models.Article, ServicesDto.Article>();
            CreateMap<ServicesDto.Article, Models.Article>();
        }
    }
}
