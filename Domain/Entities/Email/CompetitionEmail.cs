namespace CalcAppAPI.Domain.Entities.Email
{
    public class CompetitionEmail
    {
        public string FromEmail { get; set; } = string.Empty;
        public string Subject { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string CountryCode { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string BusinessForm { get; set; } = string.Empty;
        public string Category { get; set; } = string.Empty;
        public string Kata { get; set; } = string.Empty;
        public string BusinessYear { get; set; } = string.Empty;
        public string ManPower { get; set; } = string.Empty;
        public string Revenue { get; set; } = string.Empty;
        public string? Message { get; set; }
    }
}
