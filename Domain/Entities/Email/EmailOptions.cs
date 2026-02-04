namespace CalcAppAPI.Domain.Entities.Email
{
    public class EmailOptions
    {
        public string FromEmailAddress { get; set; } = string.Empty;
        public string ToEmailAddress { get; set; } = string.Empty;
        public string ToEmailAddressTest { get; set; } = string.Empty;
        public string FromEmailPw { get; set; } = string.Empty;
        public string SmtpHost { get; set; } = string.Empty;
        public int SmtpPort { get; set; }
    }
}
