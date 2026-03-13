using CalcAppAPI.Domain.Entities.Email;

namespace CalcAppAPI.Application.Services.Palms.Email
{
    public interface IEmailSender
    {
        Task SendDealerEmailAsync(EmailData email, CancellationToken cancellationToken);
        Task SendUserEmailAsync(EmailData email, CancellationToken cancellationToken);
    }
}
