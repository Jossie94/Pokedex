using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Pokedex.Server.Models;
using Pokedex.Shared.Models;

namespace Pokedex.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PokemontrainersController : ControllerBase
    {
        private readonly Pokemondb _context;

        public PokemontrainersController(Pokemondb context)
        {
            _context = context;
        }

        // GET: api/Pokemontrainers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Pokemontrainer>>> GetPokemonTrainers()
        {
          if (_context.PokemonTrainers == null)
          {
              return NotFound();
          }
            return await _context.PokemonTrainers.ToListAsync();
        }

        // GET: api/Pokemontrainers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Pokemontrainer>> GetPokemontrainer(int id)
        {
          if (_context.PokemonTrainers == null)
          {
              return NotFound();
          }
            var pokemontrainer = await _context.PokemonTrainers.FindAsync(id);

            if (pokemontrainer == null)
            {
                return NotFound();
            }

            return pokemontrainer;
        }

        // PUT: api/Pokemontrainers/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPokemontrainer(int id, Pokemontrainer pokemontrainer)
        {
            if (id != pokemontrainer.Tid)
            {
                return BadRequest();
            }

            _context.Entry(pokemontrainer).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PokemontrainerExists(id))
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

        // POST: api/Pokemontrainers
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Pokemontrainer>> PostPokemontrainer(Pokemontrainer pokemontrainer)
        {
          if (_context.PokemonTrainers == null)
          {
              return Problem("Entity set 'Pokemondb.PokemonTrainers'  is null.");
          }
            _context.PokemonTrainers.Add(pokemontrainer);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPokemontrainer", new { id = pokemontrainer.Tid }, pokemontrainer);
        }

        // DELETE: api/Pokemontrainers/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePokemontrainer(int id)
        {
            if (_context.PokemonTrainers == null)
            {
                return NotFound();
            }
            var pokemontrainer = await _context.PokemonTrainers.FindAsync(id);
            if (pokemontrainer == null)
            {
                return NotFound();
            }

            _context.PokemonTrainers.Remove(pokemontrainer);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PokemontrainerExists(int id)
        {
            return (_context.PokemonTrainers?.Any(e => e.Tid == id)).GetValueOrDefault();
        }
    }
}
