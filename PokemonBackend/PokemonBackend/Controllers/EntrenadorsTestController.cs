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
    public class EntrenadorsTestController : ControllerBase
    {
        private readonly MyDbContext _context;

        public EntrenadorsTestController(MyDbContext context)
        {
            _context = context;
        }

        // GET: api/EntrenadorsTest
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Entrenador>>> GetEntrenadores()
        {
          if (_context.Entrenadores == null)
          {
              return NotFound();
          }
            return await _context.Entrenadores.ToListAsync();
        }

        // GET: api/EntrenadorsTest/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Entrenador>> GetEntrenador(int? id)
        {
          if (_context.Entrenadores == null)
          {
              return NotFound();
          }
            var entrenador = await _context.Entrenadores.FindAsync(id);

            if (entrenador == null)
            {
                return NotFound();
            }

            return entrenador;
        }

        // PUT: api/EntrenadorsTest/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEntrenador(int? id, Entrenador entrenador)
        {
            if (id != entrenador.Id)
            {
                return BadRequest();
            }

            _context.Entry(entrenador).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EntrenadorExists(id))
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

        // POST: api/EntrenadorsTest
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Entrenador>> PostEntrenador(Entrenador entrenador)
        {
          if (_context.Entrenadores == null)
          {
              return Problem("Entity set 'MyDbContext.Entrenadores'  is null.");
          }
            _context.Entrenadores.Add(entrenador);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEntrenador", new { id = entrenador.Id }, entrenador);
        }

        // DELETE: api/EntrenadorsTest/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEntrenador(int? id)
        {
            if (_context.Entrenadores == null)
            {
                return NotFound();
            }
            var entrenador = await _context.Entrenadores.FindAsync(id);
            if (entrenador == null)
            {
                return NotFound();
            }

            _context.Entrenadores.Remove(entrenador);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool EntrenadorExists(int? id)
        {
            return (_context.Entrenadores?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
