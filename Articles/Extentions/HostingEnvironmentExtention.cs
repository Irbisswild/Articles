using Articles.Common.Consts;
using Microsoft.AspNetCore.Hosting;

namespace Articles.Extentions
{
    public static class HostingEnvironmentExtention
    {
        public static bool IsDevelopmentEnv(this IWebHostEnvironment hostEnvironment)
        {
            return AppSettings.EnvironmentNames.Dev == System.Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");
        }
    }
}
