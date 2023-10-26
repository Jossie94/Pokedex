using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Pokedex.Shared.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;

namespace Pokedex.Server.Models
{
    public class Pokemondb : DbContext
    {
       

        public Pokemondb(DbContextOptions<Pokemondb> options) :base(options)
        {

        }
        public virtual DbSet<Pokemon> Pokemons { get; set; }
        public virtual DbSet<Pokemontrainer> PokemonTrainers { get; set; }
        private byte[] GetFileBytes(string path)
        {
            FileStream fileOnDisk = new FileStream(path, FileMode.Open);
            byte[] fileBytes;
            using (BinaryReader br = new BinaryReader(fileOnDisk))
            {
                fileBytes = br.ReadBytes((int)fileOnDisk.Length);
            }
            return fileBytes;
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Pokemon>()
                .HasData(
            new Pokemon
                {
                    pId = 1,
                    pName = "Bulbasaur",
                    type1 = "Grass",
                    type2 = "Poison",
                    abilities = "Overgrow",
                    pokepic = GetFileBytes("C:\\Users\\josef\\source\\repos\\Pokedex\\Pokedex\\Server\\Pics\\bulbasaur.png")
                },
                    new Pokemon
                    {
                        pId = 2,
                        pName = "Ivysaur",
                        type1 = "Grass",
                        type2 = "Poison",
                        abilities = "Overgrow",
                        pokepic = GetFileBytes("C:\\Users\\josef\\source\\repos\\Pokedex\\Pokedex\\Server\\Pics\\Ivysaur.png")
                    },
                    new Pokemon
                    {
                        pId = 3,
                        pName = "Venusaur",
                        type1 = "Grass",
                        type2 = "Poison",
                        abilities = "Overgrow",
                        pokepic = GetFileBytes("C:\\Users\\josef\\source\\repos\\Pokedex\\Pokedex\\Server\\Pics\\Venusaur.png")
                    },
                    new Pokemon
                    {
                        pId = 4,
                        pName = "Charmander",
                        type1 = "Fire",
                        type2 = " ",
                        abilities = "Blaze",
                        pokepic = GetFileBytes("C:\\Users\\josef\\source\\repos\\Pokedex\\Pokedex\\Server\\Pics\\Charmander.png")
                    },
                    new Pokemon
                    {
                        pId = 5,
                        pName = "Charmeleon",
                        type1 = "Fire",
                        type2 = " ",
                        abilities = "Blaze",
                        pokepic = GetFileBytes("C:\\Users\\josef\\source\\repos\\Pokedex\\Pokedex\\Server\\Pics\\Charmeleon.png")
                    },
                    new Pokemon
                    {
                        pId = 6,
                        pName = "Charizard",
                        type1 = "Fire",
                        type2 = "Flying",
                        abilities = "Blaze",
                        pokepic = GetFileBytes("C:\\Users\\josef\\source\\repos\\Pokedex\\Pokedex\\Server\\Pics\\Charizard.png")
                    },
                    new Pokemon
                    {
                        pId = 7,
                        pName = "Squirtle",
                        type1 = "Water",
                        type2 = " ",
                        abilities = "Torrent",
                        pokepic = GetFileBytes("C:\\Users\\josef\\source\\repos\\Pokedex\\Pokedex\\Server\\Pics\\Squirtle.png")
                    },
                    new Pokemon
                    {
                        pId = 8,
                        pName = "Wartortle",
                        type1 = "Water",
                        type2 = " ",
                        abilities = "Torrent",
                        pokepic = GetFileBytes("C:\\Users\\josef\\source\\repos\\Pokedex\\Pokedex\\Server\\Pics\\Wartortle.png")
                    },
                    new Pokemon
                    {
                        pId = 9,
                        pName = "Blastoise",
                        type1 = "Water",
                        type2 = " ",
                        abilities = "Torrent",
                        pokepic = GetFileBytes("C:\\Users\\josef\\source\\repos\\Pokedex\\Pokedex\\Server\\Pics\\Blastoise.png")
                    }); // Adjust the maximum length as needed
        }


        

    }
    
}
