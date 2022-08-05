using Business_Logic_Layer.Models;
using Data_Acces_Layer.Repository;
using Logica_Negocio.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PokemonBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PokemonsTiposController : ControllerBase
    {
        private MyDbContext db = new MyDbContext();

        public PokemonsTiposController()
        {
        }
        [HttpGet]
        public IQueryable<PokemonModel> GetPokemonTipos()
        {
            var Pokemon = from pkx in db.Pokedex
                          join tpk in db.Tipo_Pokemons
                          on pkx.ID equals tpk.PokedexId
                          join t in db.Tipos
                          on tpk.TipoId equals t.Id
                          select new PokemonModel
                          {
                              Id = t.Id, // id del tipo, cambiar
                              Nombre = pkx.Nombre,
                              Tipo = t.Tipo_pokemon
                          };
            return Pokemon;
        }
    }
}
