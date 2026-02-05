using CalcAppAPI.Models.Pdf;

namespace CalcAppAPI.Application.Services.Pdf.Util
{
    public static class PdfDataFlattener
    {
        public static IEnumerable<(string Property, PdfItem Item)> Flatten(PdfData data)
        {
            foreach (var property in typeof(PdfData).GetProperties())
            {
                var value = property.GetValue(data);

                if (value is PdfItem item)
                    yield return (property.Name, item);

                if (value is IEnumerable<PdfItem> list)
                {
                    foreach (var i in list)
                        yield return (property.Name, i);
                }
            }
        }
    }
}
