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
    private readonly MyDbContext _db = new();
    public PokedexBLL Bll;

    public PokedexController()
    {
        Bll = new PokedexBLL();
    }

    [HttpGet]
    public List<PokedexModel> GetPokedex([FromQuery] Pagination pagination)
    {
        return Bll.GetPokedex(pagination);
    }

    [HttpGet("{id}")]
    public ActionResult<PokedexModel> GetPokedexById(int id)
    {
        var pokemon = Bll.GetPokedexById(id);
        if (pokemon == null) return StatusCode(404, "Pokemon no encontrado");
        return Ok(pokemon);
    }

    [HttpGet("FindByName")]
    public List<PokedexModel> GetByName([FromQuery] string name)
    {
        return Bll.GetByName(name);
    }

    [HttpGet("AllData")]
    public List<PokedexModel> GetPokemonTipos()
    {
        return Bll.GetAll();
    }

    [HttpGet("Habilidades")]
    public IQueryable<HabilidadesModel> GetHabilidadesTipo()
    {
        var Habilidades = from t in _db.Tipos
            join th in _db.TiposHabilidades
                on t.Id equals th.TipoId
            join h in _db.Habilidades
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

    [HttpPatch("EditTier")]
    public void PutZonaIntoPokemon(int tierid, int pokemonid)
    {
        Bll.EditPokedexTier(pokemonid, tierid);
    }

    [HttpPatch("{id}")]
    public void EditInfoPokemon(int id, EditPokedexModel model)
    {
        Bll.PokedexEdit(id, model);
    }

    [HttpGet("InsertImgURL")]
    public void SeedImage()
    {
        Bll.SeedImageUrl();
    }
}