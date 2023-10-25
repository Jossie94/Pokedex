using Pokedex.Shared.Models;
using System.IO;
namespace Pokedex.Server.Models
{
    public class Pokemonservice
    {
        private readonly Pokemondb dbContext;

        public Pokemonservice(Pokemondb context)
        {
            dbContext = context;
        }

        public void SavePokemonWithImage(string PName, byte[] Pokepic)
        {
            var newPokemon = new Pokemon
            {
                pName = PName,
                pokepic = Pokepic
            };

            dbContext.Pokemons.Add(newPokemon);
            dbContext.SaveChanges();
        }
    }
}
