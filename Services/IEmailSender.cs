using CalcAppAPI.Models.Email;

namespace CalcAppAPI.Services
{
    public interface IEmailSender
    {
        Task SendEmailAsync(Email email);
        Task SendEmailAsync(IFormFile File);
    }
}
