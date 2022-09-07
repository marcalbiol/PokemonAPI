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
    public ZonaBll _BLR;
    
    public ZonaController()
    {
        _BLR = new ZonaBll();
    }
    
    [HttpGet]
    public List<ZonaModel> GetZonas()
    {
        return _BLR.GetAllZonas();
    }
    
}