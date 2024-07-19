using System.ComponentModel.DataAnnotations;
using Project.Models.Enums;

namespace Project.Models
{
    public class Character
    {
        public int? CharacterId { get; set; }
        public string? Name { get; set; }
        public string? Backstory { get; set; }
        public List<Attributes>? Attributes { get; set; }
        public List<Race>? Race { get; set; }
 
    }
}
