using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace Pokedex.Shared.Models
{
    public class Pokemon
    {
        [Key]
        public int pId { get; set; }
        [Required]
        public string pName { get; set; }
        public string type1 { get; set; } = null!;
        public string type2 { get; set; }
        public string abilities { get; set; }

    }
}
