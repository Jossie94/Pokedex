//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Web;
//using Pokedex.Shared.Models;
//using Microsoft.EntityFrameworkCore;
//using System.IO;
//using Pokedex.Server.Models;


//namespace Pokedex.Server.Models
//{
//    public class PokemonSharingInitializer 
//    {
//        private byte[] GetFileBytes(string path)
//        {
//            FileStream fileOnDisk = new FileStream(path, FileMode.Open);
//            byte[] fileBytes;
//            using (BinaryReader br = new BinaryReader(fileOnDisk))
//            {
//                fileBytes = br.ReadBytes((int)fileOnDisk.Length);
//            }
//            return fileBytes;
//        }

//        public void InitializeDatabase()
//        {
//            using (var context = new Pokemondb())
//            {
//                // Delete and recreate the database
//                context.Database.EnsureDeleted();
//                context.Database.EnsureCreated();

//                var pokemon = new List<Pokemon>
//                {
//                    new Pokemon
//                    {
//                        pName = "Bulbasaur",
//                        type1 = "Grass",
//                        type2 = "Poison",
//                        abilities = "Overgrow",
//                        pokepic = GetFileBytes("C:\\Users\\josef\\source\\repos\\Pokedex\\Pokedex\\Server\\Pics\\bulbasaur.png")
//                    },
//                    new Pokemon
//                    {
//                        pName = "Ivysaur",
//                        type1 = "Grass",
//                        type2 = "Poison",
//                        abilities = "Overgrow",
//                        pokepic = GetFileBytes("C:\\Users\\josef\\source\\repos\\Pokedex\\Pokedex\\Server\\Pics\\Ivysaur.png")
//                    },
//                    new Pokemon
//                    {
//                        pName = "Venusaur",
//                        type1 = "Grass",
//                        type2 = "Poison",
//                        abilities = "Overgrow",
//                        pokepic = GetFileBytes("C:\\Users\\josef\\source\\repos\\Pokedex\\Pokedex\\Server\\Pics\\Venusaur.png")
//                    },
//                    new Pokemon
//                    {
//                        pName = "Charmander",
//                        type1 = "Fire",
//                        type2 = " ",
//                        abilities = "Blaze",
//                        pokepic = GetFileBytes("C:\\Users\\josef\\source\\repos\\Pokedex\\Pokedex\\Server\\Pics\\Charmander.png")
//                    },
//                    new Pokemon
//                    {
//                        pName = "Charmeleon",
//                        type1 = "Fire",
//                        type2 = " ",
//                        abilities = "Blaze",
//                        pokepic = GetFileBytes("C:\\Users\\josef\\source\\repos\\Pokedex\\Pokedex\\Server\\Pics\\Charmeleon.png")
//                    },
//                    new Pokemon
//                    {
//                        pName = "Charizard",
//                        type1 = "Fire",
//                        type2 = "Flying",
//                        abilities = "Blaze",
//                        pokepic = GetFileBytes("C:\\Users\\josef\\source\\repos\\Pokedex\\Pokedex\\Server\\Pics\\Charizard.png")
//                    },
//                    new Pokemon
//                    {
//                        pName = "Squirtle",
//                        type1 = "Water",
//                        type2 = " ",
//                        abilities = "Torrent",
//                        pokepic = GetFileBytes("C:\\Users\\josef\\source\\repos\\Pokedex\\Pokedex\\Server\\Pics\\Squirtle.png")
//                    },
//                    new Pokemon
//                    {
//                        pName = "Wartortle",
//                        type1 = "Water",
//                        type2 = " ",
//                        abilities = "Torrent",
//                        pokepic = GetFileBytes("C:\\Users\\josef\\source\\repos\\Pokedex\\Pokedex\\Server\\Pics\\Wartortle.png")
//                    },
//                    new Pokemon
//                    {
//                        pName = "Blastoise",
//                        type1 = "Water",
//                        type2 = " ",
//                        abilities = "Torrent",
//                        pokepic = GetFileBytes("C:\\Users\\josef\\source\\repos\\Pokedex\\Pokedex\\Server\\Pics\\Blastoise.png")
//                    },

//                };

//                context.Pokemons.AddRange(pokemon);
//                context.SaveChanges();
//            }
//        }

//    }
//}

