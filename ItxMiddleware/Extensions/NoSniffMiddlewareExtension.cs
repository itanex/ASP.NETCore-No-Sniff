using Microsoft.AspNetCore.Builder;
using ItxMiddleware.Middleware;

namespace ItxMiddleware.Extensions
{
    public static class NoSniffMiddlewareExtension
    {
        public static IApplicationBuilder UseNoSniffMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<NoSniffMiddleware>();
        }
    }
}
