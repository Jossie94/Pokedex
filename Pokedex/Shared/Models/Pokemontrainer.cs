using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace Pokedex.Shared.Models
{
    public class Pokemontrainer
    {
        [Key]
        public int Tid { get; set; }
        [Required]
        public string Tname { get; set; }
        public virtual ICollection<Pokemon> Pokemons { get; set; } = new List<Pokemon>();
    }
}
