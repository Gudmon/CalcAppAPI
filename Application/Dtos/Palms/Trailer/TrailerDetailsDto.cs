using CalcAppAPI.Application.Dtos.Palms.Crane;

namespace CalcAppAPI.Application.Dtos.Palms.Trailer
{
    public class TrailerDetailsDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Price { get; set; }
        public string BeamType { get; set; }
        public string LoadingAreaCross { get; set; }
        public string LoadingAreaLength { get; set; }
        public string Frame { get; set; }
        public string FrameExtensionLength { get; set; }
        public string GrossWeight { get; set; }
        public string CurbWeight { get; set; }
        public string TotalLength { get; set; }
        public string WidthWithStandardWheels { get; set; }
        public string StandardWheelSize { get; set; }
        public string MaxCraneSize { get; set; }
        public string DrawbarControlCylinders { get; set; }

        public IEnumerable<CraneNestedDto> Cranes { get; set; }
        public IEnumerable<TrailerOptionDto> Options { get; set; }
    }
}
