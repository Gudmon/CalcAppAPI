namespace CalcAppAPI.Models.Email
{
    public class EmailOptions
    {
        public string FromEmailAddress { get; set; }
        public string ToEmailAddress { get; set; }
        public string ToEmailAddressTest { get; set; }
        public string FromEmailPw { get; set; }
        public string SmtpHost { get; set; }
        public int SmtpPort { get; set; }
    }
}
