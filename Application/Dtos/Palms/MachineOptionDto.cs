namespace CalcAppAPI.Application.Dtos.Palms
{
    public class MachineOptionDto
    {
        public int Id { get; init; }
        public string Name { get; set; } = string.Empty;
        public string Code { get; set; } = string.Empty;
        public string Price { get; set; } = string.Empty;
        public string[]? ImageUrls { get; set; }
    }
}
