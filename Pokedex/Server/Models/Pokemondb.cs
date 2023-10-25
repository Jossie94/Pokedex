using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Pokedex.Shared.Models;
using System;
using System.Collections.Generic;
using System.IO;

namespace Pokedex.Server.Models
{
    public class Pokemondb : DbContext
    {
        public Pokemondb(DbContextOptions<Pokemondb> options) :base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pokemon>()
                .Property(p => p.pokepic)
                .IsRequired()
                .HasMaxLength(1048576); // Adjust the maximum length as needed
        }


        public virtual DbSet<Pokemon> Pokemons { get; set; }
        public virtual DbSet<Pokemontrainer> PokemonTrainers { get; set;} 

    }
    
}
