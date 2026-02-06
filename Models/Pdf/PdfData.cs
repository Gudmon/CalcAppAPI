namespace CalcAppAPI.Models.Pdf
{
    public class PdfData
    {
        public string TotalPrice { get; set; } = string.Empty;
        public string? TrailerName { get; set; }
        public string? CraneName { get; set; }
        public IEnumerable<SinglePdfOption> SingleOptions { get; set; } = Enumerable.Empty<SinglePdfOption>();
        public IEnumerable<MultiplePdfOption> MultipleOptions { get; set; } = Enumerable.Empty<MultiplePdfOption>();
    }
}
