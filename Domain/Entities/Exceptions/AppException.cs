using CalcAppAPI.Domain.Entities.Errors;

namespace CalcAppAPI.Domain.Entities.Exceptions
{
    public abstract class AppException : Exception
    {
        public string Code { get; }
        public ErrorType Type { get; }

        protected AppException(string code, string message, ErrorType type)
            : base(message)
        {
            Code = code;
            Type = type;
        }
    }
}
