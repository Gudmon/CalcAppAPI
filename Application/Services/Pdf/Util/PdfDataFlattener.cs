using CalcAppAPI.Models.Pdf;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace CalcAppAPI.Application.Services.Pdf.Util
{
    public static class PdfDataFlattener
    {
        public static string GetDisplayName(this OptionGroup group)
        {
            var field = group.GetType().GetField(group.ToString());
            var attribute = field?
                .GetCustomAttribute<DisplayAttribute>();

            return attribute?.Name ?? group.ToString();
        }
    }
}
