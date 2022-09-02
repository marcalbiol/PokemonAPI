using Business_Logic_Layer.Models;
using Data_Acces_Layer.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PokemonBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class RegionController : ControllerBase
    {
        public RegionBll _BLLR;
        private readonly MyDbContext db = new();


        public RegionController()
        {
            _BLLR = new RegionBll();
        }


        [HttpGet("Regiones")]
        public List<RegionModel> GetRegiones()
        {
            return _BLLR.GetAllRegions();
        }


    }
}
