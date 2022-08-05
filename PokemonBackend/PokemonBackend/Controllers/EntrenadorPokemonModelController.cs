using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PokemonBackend.Models;
using Logica_Negocio.Models;
using Data_Acces_Layer.Repository;

namespace PokemonBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EntrenadorPokemonModelController : ControllerBase
    {
        public Logica_Negocio.EntrenadorPokemonBLL _BLL;
        private MyDbContext db = new MyDbContext();
        public EntrenadorPokemonModelController()
        {
            _BLL = new Logica_Negocio.EntrenadorPokemonBLL();
        }

      /*
        [HttpGet]
        public IQueryable<EntrenadorPokemonModel> GetAll()
        {
        }
      */
       
    
    }
}
