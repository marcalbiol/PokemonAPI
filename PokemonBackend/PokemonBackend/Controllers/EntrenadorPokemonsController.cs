using Data_Acces_Layer.Repository;
using Logica_Negocio.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PokemonBackend.Models;

namespace PokemonBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class EntrenadorPokemonsController : ControllerBase
    {
        public Logica_Negocio.EntrenadorBLL _BLL { get; set; }
        private MyDbContext db = new MyDbContext();

        public EntrenadorPokemonsController()
        {
            _BLL = new Logica_Negocio.EntrenadorBLL();
        }

        [HttpGet]
        public IQueryable<EntrenadorModel> GetEntrenador()
        {
            var Entrenador = from pk in db.Pokemons
                             join ep in db.Entrenadores_Pokemons
                             on pk.Id equals ep.PokemonId
                             join et in db.Entrenadores
                             on ep.EntrenadorId equals et.Id
                             join pkx in db.Pokedex
                             on pk.PokedexId equals pkx.ID
                             select new EntrenadorModel
                             {
                                 Id = pk.Id,
                                 Pokemon = pkx.Nombre,
                                 Entrenador = et.Nombre
                             };

            return Entrenador;
        }

        [HttpGet("{id}")]
        public IQueryable<EntrenadorModel> GetEntrenadorById(int id)
        {
            var Entrenador = from pk in db.Pokemons
                             join ep in db.Entrenadores_Pokemons
                             on pk.Id equals ep.PokemonId
                             join et in db.Entrenadores
                             on ep.EntrenadorId equals et.Id
                             join pkx in db.Pokedex
                             on pk.PokedexId equals pkx.ID
                             where et.Id == id
                             select new EntrenadorModel
                             {
                                 Id = pk.Id,
                                 Pokemon = pkx.Nombre,
                                 Entrenador = et.Nombre
                             };
            return Entrenador;


        }
        /*

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

      */
    }
}
