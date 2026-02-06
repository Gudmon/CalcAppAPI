using CalcAppAPI.Domain.Entities.Errors;
using CalcAppAPI.Domain.Entities.Exceptions;

namespace CalcAppAPI.Infrastructure
{
    public class GlobalExceptionMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<GlobalExceptionMiddleware> _logger;

        public GlobalExceptionMiddleware(
            RequestDelegate next,
            ILogger<GlobalExceptionMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (AppException ex)
            {
                _logger.LogWarning(ex, "Application error");

                context.Response.StatusCode = MapStatusCode(ex.Type);
                context.Response.ContentType = "application/json";

                await context.Response.WriteAsJsonAsync(new
                {
                    code = ex.Code,
                    message = ex.Message,
                    type = ex.Type.ToString()
                });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Unhandled error");

                context.Response.StatusCode = 500;

                await context.Response.WriteAsJsonAsync(new
                {
                    code = "UNKNOWN_ERROR",
                    message = "Unexpected server error",
                    type = "Unknown"
                });
            }
        }

        private static int MapStatusCode(ErrorType type) =>
            type switch
            {
                ErrorType.NotFound => 404,
                ErrorType.Validation => 400,
                ErrorType.Business => 400,
                ErrorType.Infrastructure => 503,
                ErrorType.Unauthorized => 401,
                _ => 500
            };
    }

}
