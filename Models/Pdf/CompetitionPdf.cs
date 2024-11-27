namespace CalcAppAPI.Models.Pdf
{
    public class CompetitionPdf
    {
        public string FromEmail { get; set; }
        public string Name { get; set; }
        public string CountryCode { get; set; }
        public string PhoneNumber { get; set; }
        public string BusinessForm { get; set; }
        public string Category { get; set; }
        public string Kata { get; set; }
        public string BusinessYear { get; set; }
        public string ManPower { get; set; }
        public string Revenue { get; set; }
        public string? Message { get; set; }
    }
}
