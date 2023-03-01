using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;

namespace COREAPI
{
    public class ExceptionMiddleware : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            try
            {
                await next(context);
            }
            catch (Exception ex)
            {
                await HandleExceptionsAsync(context, ex);
            }
        }

        private async Task HandleExceptionsAsync(HttpContext context, Exception exception)
        {
            context.Response.StatusCode = 500;
            context.Response.ContentType = "application/json";
            string errorMessage;
            switch (exception)
            {
                case ArgumentNullException ex:
                    errorMessage = "One or more required arguments are missing.";
                    context.Response.StatusCode = 400;
                    break;
                case InvalidOperationException ex:
                    errorMessage = "The requested operation cannot be performed.";
                    context.Response.StatusCode = 401;
                    break;
                case KeyNotFoundException ex:
                    errorMessage = "The requested resource was not found.";
                    context.Response.StatusCode = 404;
                    break;
                default:
                    errorMessage = "An unexpected error occurred while processing the request.";
                    break;
            }
            var errorResponse = new { error = errorMessage, status = context.Response.StatusCode };
            var json = JsonConvert.SerializeObject(errorResponse);
            await context.Response.WriteAsync(json);
        }
    }
}
