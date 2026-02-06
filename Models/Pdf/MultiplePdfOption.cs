namespace CalcAppAPI.Models.Pdf
{
    public class MultiplePdfOption : PdfOption
    {
        public IEnumerable<PdfItem> Options { get; init; } = Enumerable.Empty<PdfItem>();
    }
}
