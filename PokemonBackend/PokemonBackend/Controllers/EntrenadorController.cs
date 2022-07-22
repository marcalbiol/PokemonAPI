using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Data_Acces_Layer.Repository;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PokemonBackend.Models;

namespace PokemonBackend.Controllers
{

    // https://localhost:7280/api/Entrenador
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
   // [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class EntrenadorController : ControllerBase
    {
        private readonly MyDbContext _context;

        public EntrenadorController(MyDbContext context)
        {
            _context = context;
        }

        // GET: api/Entrenador
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Entrenador>>> GetEntrenadores()
        {
          if (_context.Entrenadores == null)
          {
              return NotFound();
          }
            return await _context.Entrenadores.ToListAsync();
        }

        // GET: api/Entrenador/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Entrenador>> GetEntrenador(int id)
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

        // PUT: api/Entrenador/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEntrenador(int id, Entrenador entrenador)
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

        // POST: api/Entrenador
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

        // DELETE: api/Entrenador/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEntrenador(int id)
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

        private bool EntrenadorExists(int id)
        {
            return (_context.Entrenadores?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
