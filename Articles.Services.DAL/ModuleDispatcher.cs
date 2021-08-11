using Articles.Services.DAL.Abstractions.Repositories;
using Articles.Services.DAL.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Articles.Services.DAL
{
    public static class ModuleDispatcher
    {
        public static void AddDataAccess(this IServiceCollection services)
        {
            services.AddScoped<IArticleRepository, ArticleRepository>();
            services.AddScoped<ICommentRepository, CommentRepository>();
        }
    }
}
