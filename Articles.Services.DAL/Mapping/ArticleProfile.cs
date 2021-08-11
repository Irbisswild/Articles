using AutoMapper;

namespace Articles.Services.DAL.Mapping
{
    public class ArticleProfile : Profile
    {
        public ArticleProfile()
        {
            CreateMap<DTO.Article, Entities.Article>();
            CreateMap<Entities.Article, DTO.Article>();
        }
    }
}
