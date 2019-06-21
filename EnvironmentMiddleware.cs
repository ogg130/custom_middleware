using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Middleware
{
    public class EnvironmentMiddleware
    {
        private readonly RequestDelegate _next;

        public EnvironmentMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            var acceptLanguage = context.Request.Headers["Accept-Language"];
            if (!string.IsNullOrEmpty(acceptLanguage))
            {
                AppSettings.AcceptLanguage = acceptLanguage;
            }
            await _next(context);
        }
    }
}
