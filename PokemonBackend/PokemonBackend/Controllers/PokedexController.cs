using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PokemonBackend.Models;
using Business_Logic_Layer.Models;
using Data_Acces_Layer.Repository;
using Logica_Negocio.Models;
using Acceso_BD.Repository.Entity;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Collections;

namespace PokemonBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class PokedexController : ControllerBase
    {

        public Logica_Negocio.PokedexBLL _BLL;

        private MyDbContext db = new MyDbContext();
        public PokedexController()
        {
            _BLL = new Logica_Negocio.PokedexBLL();
        }

        [HttpGet]
        public List<PokedexModel> GetPokedex([FromQuery] Pagination pagination)
        {
            // mostrar region, usando linq?
            return _BLL.GetPokedex(pagination);
        }

        [HttpGet("{id}")]
        public ActionResult<PokedexModel> GetPokedexById(int id)
        {

            var pokemon = _BLL.GetPokedexById(id);

            if (pokemon == null)
            {
                return StatusCode(404, "Pokemon no encontrado");
            }

            return Ok(pokemon);



        }

        [HttpGet("Tier/{id}")]
        public IQueryable<PokedexModel> GetPokemonByTier(int id)
        {
            var Pokemon = from pkx in db.Pokedex
                          where pkx.Tier == id
                          select new PokedexModel
                          {
                              ID = pkx.ID,
                              Nombre = pkx.Nombre
                          };
            return Pokemon;
        }

        [HttpGet("Region/{id}")]
        public IQueryable<PokedexModel> GetPokemonByRegion(int id)
        {
            var Pokemon = from pkx in db.Pokedex
                          join r in db.Regiones
                          on pkx.RegionId equals r.Id
                          where pkx.RegionId == id
                          select new PokedexModel
                          {
                              ID = pkx.ID,
                              Nombre = pkx.Nombre,
                              Region = r.Nombre

                          };
            return Pokemon;
        }
        [HttpGet("Zona/{id}")]
        public IQueryable<PokedexModel> GetPokemonByZona(int id)
        {
            var Pokemon = from pkx in db.Pokedex
                          join r in db.Zonas
                          on pkx.ZonaId equals r.Id
                          where pkx.ZonaId == id
                          select new PokedexModel
                          {
                              ID = pkx.ID,
                              Nombre = pkx.Nombre
                          };
            return Pokemon;
        }

        [HttpGet("PokemonsAsignables")]
        public IQueryable<PokemonModel> GetPokemonAv()
        {
            var Pokemon = from p in db.Pokemons
                          join pkx in db.Pokedex
                          on p.PokedexId equals pkx.ID
                          select new PokemonModel
                          {
                              Id = pkx.ID,
                              Nombre = pkx.Nombre
                          };
            return Pokemon;
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
                              Id = pkx.ID,
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

        [HttpPut("{id}")]
        public void PutMethod(int id, PokedexModel model)
        {
            _BLL.PokedexEdit(id, model);    
        }

        [HttpPut("{id}/InsertImgURL")]
        public void PutImage(int id)
        {
          _BLL.PutImage(id);    
        }

    }
}
