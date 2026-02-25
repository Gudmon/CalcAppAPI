namespace CalcAppAPI.Models.Machine.Configurations.Common
{
    public abstract class MachineOption
    {
        public int Id { get; init; }
        public string Name { get; set; } = string.Empty;
        public string Code { get; set; } = string.Empty;
        public string Price { get; set; } = string.Empty;
        public string NamePrice => $"{Name} {Price}€";
        public string[]? ImageUrls { get; set; }
        public string[]? VideoUrls { get; set; }
    }
}
