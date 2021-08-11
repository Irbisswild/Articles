using Articles.Services.Abstractions;
using Articles.Services.DAL;
using Microsoft.Extensions.DependencyInjection;

namespace Articles.Services
{
    public static class ModuleDispatcher
    {
        public static void AddServices(this IServiceCollection services)
        {
            services.AddDataAccess();

            services.AddScoped<IArticleService, ArticleService>();
            services.AddScoped<ICommentService, CommentService>();
        }
    }
}
