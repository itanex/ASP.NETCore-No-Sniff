using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace ItxMiddleware.Middleware
{
    public class NoSniffMiddleware
    {
        private readonly RequestDelegate next;

        public NoSniffMiddleware(RequestDelegate next)
        {
            this.next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            context.Response.Headers.Add("X-Content-Type-Options", "nosniff");

            await next(context);
        }
    }
}
