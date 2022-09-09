using Acceso_BD.Repository.Entity;
using Business_Logic_Layer;
using Business_Logic_Layer.Models;
using Data_Acces_Layer.Repository;
using Microsoft.AspNetCore.Mvc;

namespace PokemonBackend.Controllers;

[Route("api/[controller]")]
[ApiController]
[Produces("application/json")]
public class ZonaController : ControllerBase
{
    private readonly MyDbContext db = new();
    public ZonaBll _BLL;
    public PokedexBLL _PBLL;
    public ZonaController()
    {
        _BLL = new ZonaBll();
        _PBLL = new PokedexBLL();
    }
    
    [HttpGet]
    public List<ZonaModel> GetZonas()
    {
        return _BLL.GetAllZonas();
    }
    
   
    [HttpGet("{id}")]
    public ActionResult<ZonaModel> GetZonaById(int id)
    {
        var zona = _BLL.GetZonaById(id);
        if (zona == null) return StatusCode(404, "Pokemon no encontrado");
        return Ok(zona);
    }

    [HttpPost]
    public void PostZona([FromBody] ZonaModel model)
    {
        _BLL.PostZona(model);
    }

    [HttpPut]
    public void PutZona(int id, ZonaModel model)
    {
        _BLL.PutZona(id, model);
    }
    
    [HttpDelete("{id}")]
    public Zona DeleteZona(int id)
    {
        return _BLL.DeleteZonaById(id);
    }

    [HttpPut("/insertPokemon")]
    public void PutZonaIntoPokemon(int id, PokedexZonaModel model)
    {
        _PBLL.PutPokedexZona(id, model);
    }

}