using Data_Acces_Layer.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PokemonBackend.Models;

namespace PokemonBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PokemonController : ControllerBase
    {

        private Business_Logic_Layer.PokemonBLL _BLL;
        public PokemonController()
        {
            _BLL = new Business_Logic_Layer.PokemonBLL();   
        }



        [HttpGet]
        public List<Pokemon> GetPokemons()
        {
            return _BLL.GetPokemons();  
        }

        [HttpGet("{id}")]
        public Pokemon GetPokemonById(int id)
        {
          return _BLL.GetPokemonById(id);
        }

        [HttpPost]
        public void postPokemon([FromBody] Pokemon p)
        {
            var db = new MyDbContext();
            db.Add(p);
            db.SaveChanges();
        }


    }
}
