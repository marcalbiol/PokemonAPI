using Business_Logic_Layer;
using Business_Logic_Layer.Models;
using Data_Acces_Layer.Repository;
using Microsoft.AspNetCore.Mvc;

namespace PokemonBackend.Controllers;

[Route("api/[controller]")]
[ApiController]
[Produces("application/json")]
public class TierController : ControllerBase
{
    private readonly MyDbContext db = new();
    public TierBll _BLR;


    public TierController()
    {
        // inyección
        _BLR = new TierBll();
    }

    [HttpGet]
    public List<TierModel> GetTier()
    {
        return _BLR.GetAllTiers();
    }

    //TODO metodo put
}