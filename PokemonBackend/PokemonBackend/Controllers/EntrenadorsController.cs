using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Data_Acces_Layer.Repository;
using PokemonBackend.Models;
using Logica_Negocio.Models;

namespace PokemonBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EntrenadorController : ControllerBase
    {
        private MyDbContext db = new MyDbContext();
        public Logica_Negocio.EntrenadorBLL _BLL;

        public EntrenadorController()
        {
            _BLL = new Logica_Negocio.EntrenadorBLL();
        }

        [HttpGet]
        public List<EntrenadorModel> GetEntrenadors()
        {
            return _BLL.GetEntrenador();

        }

        [HttpPost]
        public void postPokemon([FromBody] EntrenadorModel entrenadorModel)
        {
            // en el controlador llamamos a los metodos de la logica de negocio
            _BLL.PostEntrenador(entrenadorModel);
        }

        [HttpDelete("{id}")]
        public Entrenador DeleteEntrenadorById(int id)
        {
            return _BLL.DeleteEntrenadorById(id);

        }

        //pokemons asignables  SOLO LOS TIER 1
        [HttpGet("Pokemons/Tier 1")]
        public IQueryable<PokedexModel> GetPokemonByTier()
        {
            var Pokemon = from pkx in db.Pokedex
                          where pkx.Tier == 1
                          select new PokedexModel
                          {
                              ID = pkx.ID,
                              Nombre = pkx.Nombre
                          };
            return Pokemon;
        }


    }
}
