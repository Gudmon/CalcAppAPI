using CalcAppAPI.Models.Email;

namespace CalcAppAPI.Services.Krpan
{
    public interface IKrpanEmailSender
    {
        Task SendEmailAsync(Email email);
        Task SendEmailAsync(IFormFile File);
    }
}
