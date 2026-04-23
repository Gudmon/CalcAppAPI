namespace CalcAppAPI.Domain.Entities.Email
{
    public class EmailData
    {
        public string PdfId { get; set; } = string.Empty;
        public string FromEmail { get; set; } = string.Empty;
        public string? TrailerName { get; set; }
        public string? CraneName { get; set; }
        public string Body { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string CountryCode { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string BlobName { get; set; } = string.Empty;
    }
}
