using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Data_Acces_Layer.Repository;
using PokemonBackend.Models;

namespace PokemonBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Entrenadores_PokemonController : ControllerBase
    {
        private readonly MyDbContext _context;

        public Entrenadores_PokemonController(MyDbContext context)
        {
            _context = context;
        }

        // GET: api/Entrenadores_Pokemon
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Entrenadores_Pokemon>>> GetEntrenadores_Pokemons()
        {
          if (_context.Entrenadores_Pokemons == null)
          {
              return NotFound();
          }
            return await _context.Entrenadores_Pokemons.ToListAsync();
        }

        // GET: api/Entrenadores_Pokemon/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Entrenadores_Pokemon>> GetEntrenadores_Pokemon(int id)
        {
          if (_context.Entrenadores_Pokemons == null)
          {
              return NotFound();
          }
            var entrenadores_Pokemon = await _context.Entrenadores_Pokemons.FindAsync(id);

            if (entrenadores_Pokemon == null)
            {
                return NotFound();
            }

            return entrenadores_Pokemon;
        }

        // PUT: api/Entrenadores_Pokemon/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEntrenadores_Pokemon(int id, Entrenadores_Pokemon entrenadores_Pokemon)
        {
            if (id != entrenadores_Pokemon.Id)
            {
                return BadRequest();
            }

            _context.Entry(entrenadores_Pokemon).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Entrenadores_PokemonExists(id))
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

        // POST: api/Entrenadores_Pokemon
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Entrenadores_Pokemon>> PostEntrenadores_Pokemon(Entrenadores_Pokemon entrenadores_Pokemon)
        {
          if (_context.Entrenadores_Pokemons == null)
          {
              return Problem("Entity set 'MyDbContext.Entrenadores_Pokemons'  is null.");
          }
            _context.Entrenadores_Pokemons.Add(entrenadores_Pokemon);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEntrenadores_Pokemon", new { id = entrenadores_Pokemon.Id }, entrenadores_Pokemon);
        }

        // DELETE: api/Entrenadores_Pokemon/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEntrenadores_Pokemon(int id)
        {
            if (_context.Entrenadores_Pokemons == null)
            {
                return NotFound();
            }
            var entrenadores_Pokemon = await _context.Entrenadores_Pokemons.FindAsync(id);
            if (entrenadores_Pokemon == null)
            {
                return NotFound();
            }

            _context.Entrenadores_Pokemons.Remove(entrenadores_Pokemon);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool Entrenadores_PokemonExists(int id)
        {
            return (_context.Entrenadores_Pokemons?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
