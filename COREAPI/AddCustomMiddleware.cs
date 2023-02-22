using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace COREAPI
{
    public class AddCustomMiddleware : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            await context.Response.WriteAsync("This is custom  middleware");
        }
    }
}
