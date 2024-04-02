using QuestPDF.Fluent;

namespace CalcAppAPI.Services
{
    public static class Util
    {
        public static TextSpanDescriptor ApplyCommonTextStyle(this TextSpanDescriptor desc)
        {
            return desc.FontColor("#ffffff").Bold().FontSize(20);
        }
        public static string RandomId()
        {
            Random rand = new Random();
            return rand.Next(100000, 999999).ToString();
        }
    }
}
