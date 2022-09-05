using Business_Logic_Layer.Models;
using Data_Acces_Layer.Repository;
using Microsoft.AspNetCore.Mvc;

namespace PokemonBackend.Controllers;

[Route("api/[controller]")]
[ApiController]
[Produces("application/json")]
public class RegionController : ControllerBase
{
    private readonly MyDbContext db = new();
    public RegionBll _BLLR;


    public RegionController()
    {
        _BLLR = new RegionBll();
    }


    [HttpGet]
    public List<RegionModel> GetRegiones()
    {
        return _BLLR.GetAllRegions();
    }
}