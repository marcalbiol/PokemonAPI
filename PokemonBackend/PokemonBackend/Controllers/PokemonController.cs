﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PokemonBackend.Models;

namespace PokemonBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PokemonController : ControllerBase
    {
        private readonly MyDbContext _context;

        public PokemonController(MyDbContext context)
        {
            _context = context;
        }

        // GET: api/Pokemon
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Pokemon>>> GetPokemons()
        {
          if (_context.Pokemons == null)
          {
              return NotFound();
          }
            return await _context.Pokemons.ToListAsync();
        }

        // GET: api/Pokemon/5
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

        // PUT: api/Pokemon/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPokemon(int id, Pokemon pokemon)
        {
            if (id != pokemon.Id)
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

        // POST: api/Pokemon
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Pokemon>> PostPokemon(Pokemon pokemon)
        {
          if (_context.Pokemons == null)
          {
              return Problem("Entity set 'MyDbContext.Pokemons'  is null.");
          }
            _context.Pokemons.Add(pokemon);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPokemon", new { id = pokemon.Id }, pokemon);
        }

        // DELETE: api/Pokemon/5
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
            return (_context.Pokemons?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
