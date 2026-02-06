using CalcAppAPI.Domain.Entities.Errors;

namespace CalcAppAPI.Domain.Entities.Exceptions
{
    public class NotFoundException : AppException
    {
        public NotFoundException(string code, string message)
            : base(code, message, ErrorType.NotFound)
        {
        }
    }
}
