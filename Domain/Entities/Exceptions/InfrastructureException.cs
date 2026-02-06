using CalcAppAPI.Domain.Entities.Errors;

namespace CalcAppAPI.Domain.Entities.Exceptions
{
    public class InfrastructureException : AppException
    {
        public InfrastructureException(string code, string message)
            : base(code, message, ErrorType.Infrastructure)
        {
        }
    }

}
