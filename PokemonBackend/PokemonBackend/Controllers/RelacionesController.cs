using Business_Logic_Layer.Models;
using Data_Acces_Layer.Repository;
using Logica_Negocio.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PokemonBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RelacionesController : ControllerBase
    {
        private MyDbContext db = new MyDbContext();

        public RelacionesController()
        {
        }
        [HttpGet("PokemonsTipos")]
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

        [HttpGet("Habilidades")]
        public IQueryable<HabilidadesModel> GetHabilidadesTipo()
        {
            var Habilidades = from t in db.Tipos
                              join th in db.Tipos_Habilidades
                              on t.Id equals th.TipoId
                              join h in db.Habilidades
                              on th.HabilidadId equals h.HabilidadId
                              select new HabilidadesModel
                              {
                                  Tipo = t.Tipo_pokemon,
                                  Habilidad_1 = h.Habilidad_1,
                                  Habilidad_2 = h.Habilidad_2,
                                  Habilidad_3 = h.Habilidad_3,
                                  Habilidad_4 = h.Habilidad_4,
                              };
                              return Habilidades;
        }
        [HttpGet("EntrenadorPokemons")]
        public IQueryable<EntrenadorPokemonModel> GetEntrenador()
        {
            var Entrenador = from pk in db.Pokemons
                             join ep in db.Entrenadores_Pokemons
                             on pk.Id equals ep.PokemonId
                             join et in db.Entrenadores
                             on ep.EntrenadorId equals et.Id
                             join pkx in db.Pokedex
                             on pk.PokedexId equals pkx.ID
                             select new EntrenadorPokemonModel
                             {
                                 Id = pk.Id,
                                 Pokemon = pkx.Nombre,
                                 Entrenador = et.Nombre
                             };

            return Entrenador;
        }

        [HttpGet("EntrenadorPokemons/{id}")]
        public IQueryable<EntrenadorPokemonModel> GetEntrenadorById(int id)
        {
            var Entrenador = from pk in db.Pokemons
                             join ep in db.Entrenadores_Pokemons
                             on pk.Id equals ep.PokemonId
                             join et in db.Entrenadores
                             on ep.EntrenadorId equals et.Id
                             join pkx in db.Pokedex
                             on pk.PokedexId equals pkx.ID
                             where et.Id == id
                             select new EntrenadorPokemonModel
                             {
                                 Id = pk.Id,
                                 Pokemon = pkx.Nombre,
                                 Entrenador = et.Nombre
                             };
            return Entrenador;
        }

    }
}
