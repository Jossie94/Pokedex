using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using NuGet.Protocol;
using Pokedex.Server.Models;
using Pokedex.Shared.Models;

namespace Pokedex.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PokemonsController : ControllerBase
    {
        private readonly Pokemondb _context;

        private readonly Pokemonservice pokemonservice;
        
        private readonly ILogger<PokemonsController> _logger;

        public PokemonsController(Pokemonservice service)
        {
            pokemonservice = service;

        }
        [HttpPost]
        public IActionResult CreatePokemonWithImage([FromBody] Pokemon model)
        {
            // Validate and process the input model
            // ...

            // Convert the uploaded image to bytes (e.g., model.ImageData)
            // ...

            pokemonservice.SavePokemonWithImage(model.pName, model.pokepic);

            return Ok("Pokemon with image saved.");
        }
        public PokemonsController(Pokemondb context, ILogger<PokemonsController> logger)
        {
            _context = context;
            _logger = logger;
        }

        

        // GET: api/Pokemons
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Pokemon>>> GetPokemons()
        {


            var k = await _context.Pokemons.ToListAsync(); 
            foreach (var pokemon in k)
            {
                _logger.LogWarning(pokemon.ToString());

            }

            if (_context.Pokemons == null)
          {
              return NotFound();
            }
       
          
         
            return Ok(k);

        }

        // GET: api/Pokemons/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Pokemon>> GetPokemon(int id)
        {
          if (_context.Pokemons == null)
          {
              return NotFound();
          }
            var pokemon = await _context.Pokemons.FindAsync(id);

            if (pokemon == null)
            {
                return NotFound();
            }

            return pokemon;
        }

        // PUT: api/Pokemons/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPokemon(int id, Pokemon pokemon)
        {
            if (id != pokemon.pId)
            {
                return BadRequest();
            }

            _context.Entry(pokemon).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PokemonExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Pokemons
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Pokemon>> PostPokemon(Pokemon pokemon)
        {
          if (_context.Pokemons == null)
          {
              return Problem("Entity set 'Pokemondb.Pokemons'  is null.");
          }
            _context.Pokemons.Add(pokemon);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPokemon", new { id = pokemon.pId }, pokemon);
        }

        // DELETE: api/Pokemons/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePokemon(int id)
        {
            if (_context.Pokemons == null)
            {
                return NotFound();
            }
            var pokemon = await _context.Pokemons.FindAsync(id);
            if (pokemon == null)
            {
                return NotFound();
            }

            _context.Pokemons.Remove(pokemon);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PokemonExists(int id)
        {
            return (_context.Pokemons?.Any(e => e.pId == id)).GetValueOrDefault();
        }
    }
}
