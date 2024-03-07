namespace CalcAppAPI.Models.Machine.Configurations.Trailers
{
    public class FrameExtension
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Price { get; set; }
        public IEnumerable<Trailer> Trailer { get; set; }
    }
}
