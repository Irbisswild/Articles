using Articles.Extentions;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Articles.Filters
{
    public class CustomExceptionFilter : IExceptionFilter
    {
        private readonly ILogger<CustomExceptionFilter> _logger;
        private readonly IWebHostEnvironment _hostingEnvironment;

        public CustomExceptionFilter(
            ILogger<CustomExceptionFilter> logger,
            IWebHostEnvironment hostingEnvironment)
        {
            _logger = logger;
            _hostingEnvironment = hostingEnvironment;
        }

        public void OnException(ExceptionContext context)
        {
            var message = $"В методе {context.ActionDescriptor.DisplayName} возникло исключение: \n {context.Exception.Message} \n {context.Exception.StackTrace}";

            _logger.LogError(message);

            context.ExceptionHandled = true;

            if (!_hostingEnvironment.IsDevelopmentEnv())
            {
                return;
            }

            context.Result = new ContentResult
            {
                Content = message
            };
        }
    }
}
