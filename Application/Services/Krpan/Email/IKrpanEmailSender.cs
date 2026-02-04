using CalcAppAPI.Domain.Entities.Email;

namespace CalcAppAPI.Application.Services.Krpan.Email
{
    public interface IKrpanEmailSender
    {
        Task SendEmailAsync(EmailData email);
        Task SendEmailAsync(IFormFile File);
    }
}
