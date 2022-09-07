using Acceso_BD.Repository.Entity;
using Business_Logic_Layer;
using Business_Logic_Layer.Models;
using Data_Acces_Layer.Repository;
using Microsoft.AspNetCore.Mvc;

namespace PokemonBackend.Controllers;

[Route("api/[controller]")]
[ApiController]
[Produces("application/json")]
public class PokedexController : ControllerBase
{
    private readonly MyDbContext db = new();
    public PokedexBLL _BLL;

    public PokedexController()
    {
        _BLL = new PokedexBLL();
    }

    [HttpGet]
    public List<PokedexModel> GetPokedex([FromQuery] Pagination pagination)
    {
        return _BLL.GetPokedex(pagination);
    }

    [HttpGet("{id}")]
    public ActionResult<PokedexModel> GetPokedexById(int id)
    {
        var pokemon = _BLL.GetPokedexById(id);
        if (pokemon == null) return StatusCode(404, "Pokemon no encontrado");
        return Ok(pokemon);
    }


    //TODO ENDPOINT PARA FILTRAR POR TIPO Y TIER

    [HttpGet("Tier/")]
    public List<PokedexModel> GetTierByName(string descripcion)
    {
        return _BLL.GetTierByName(descripcion);
    }


    [HttpGet("FindByName")]
    public List<PokedexModel> GetByName([FromQuery] string name)
    {
        return _BLL.GetByName(name);
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


    [HttpGet("AllData")]
    public List<PokedexModel> GetPokemonTipos()
    {
        return _BLL.GetAll();
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
                Habilidad_4 = h.Habilidad_4
            };
        return Habilidades;
    }

    [HttpPut("{id}")]
    public void PutMethod(int id, PokedexModel model)
    {
        _BLL.PokedexEdit(id, model);
    }

    [HttpGet("InsertImgURL")]
    public void SeedImage()
    {
        _BLL.SeedImageURL();
    }
}