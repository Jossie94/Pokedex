using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Pokedex.Shared.Models;
using System;
using System.Collections.Generic;

namespace Pokedex.Server.Models
{
    public class Pokemondb : DbContext
    {
        public Pokemondb(DbContextOptions<Pokemondb> options) :base(options)
        {

        }
        public virtual DbSet<Pokemon> Pokemons { get; set; }
        public virtual DbSet<Pokemontrainer> PokemonTrainers { get; set;} 

    }
    
}
