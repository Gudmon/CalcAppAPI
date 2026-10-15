using CalcAppAPI.Application.Dtos.Krpan.Crane;

namespace CalcAppAPI.Application.Dtos.Krpan.Trailer
{
    public class KrpanTrailerDetailsDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Price { get; set; }
        public string LoadCapacity { get; set; }
        public string CentralBeams { get; set; }
        public string LoadingLength { get; set; }
        public string LoadingLengthWithExtension { get; set; }
        public string TotalLength { get; set; }
        public string TotalLengthWithExtension { get; set; }
        public string TotalWidth { get; set; }
        public string Weight { get; set; }
        public IEnumerable<KrpanCraneCardOverviewDto> Cranes { get; set; }
        public string[] ImageUrls { get; set; } = Array.Empty<string>();
        public string[] VideoUrls { get; set; } = Array.Empty<string>();
    }
}
