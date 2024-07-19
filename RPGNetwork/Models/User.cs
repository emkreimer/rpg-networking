using System.ComponentModel.DataAnnotations;
using Project.Models.Enums;

namespace Project.Models
{
    public class User
    {
        public Guid? Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public List<Character>? Characters;

    }
}
