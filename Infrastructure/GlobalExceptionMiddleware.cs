using CalcAppAPI.Domain.Entities.Errors;
using CalcAppAPI.Domain.Entities.Exceptions;
using System.Data.Common;

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
            catch (DbException ex)
            {
                _logger.LogError(ex, "Database error");

                context.Response.StatusCode = StatusCodes.Status503ServiceUnavailable;

                await context.Response.WriteAsJsonAsync(new
                {
                    code = "DATABASE_UNAVAILABLE",
                    message = "Az adatbázis átmenetileg nem elérhető."
                });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Unhandled exception");

                context.Response.StatusCode = StatusCodes.Status500InternalServerError;

                await context.Response.WriteAsJsonAsync(new
                {
                    code = "UNEXPECTED_ERROR",
                    message = "Váratlan hiba."
                });
            }
        }

        private static int MapStatusCode(ErrorType type) =>
            type switch
            {
                ErrorType.NotFound => 404,
                ErrorType.Validation => 400,
                ErrorType.Business => 400,
                ErrorType.Unauthorized => 401,
                ErrorType.Infrastructure => 503,
                _ => 500
            };
    }

}
