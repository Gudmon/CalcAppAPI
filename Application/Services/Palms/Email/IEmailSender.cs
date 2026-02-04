using CalcAppAPI.Domain.Entities.Email;

namespace CalcAppAPI.Application.Services.Palms.Email
{
    public interface IEmailSender
    {
        Task SendEmailAsync(EmailData email);
        Task SendEmailAsync(Domain.Entities.Email.CompetitionEmail email);
        Task SendEmailAsync(IFormFile File);
    }
}
