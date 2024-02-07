using System.ComponentModel.DataAnnotations;

namespace CalcAppAPI.Models
{
    public class Crane
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
        public IEnumerable<Machine> Machine { get; set; }
    }
}
