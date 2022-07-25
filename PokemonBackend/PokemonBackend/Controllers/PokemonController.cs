using Business_Logic_Layer.Models;
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

        public Business_Logic_Layer.PokemonBLL _BLL;
        public PokemonController()
        {
            _BLL = new Business_Logic_Layer.PokemonBLL();
        }



        [HttpGet]
        public List<PokemonModel> GetPokemons()
        {
            return _BLL.GetPokemons();
        }

        [HttpGet("{id}")]
        public ActionResult<PokemonModel> GetPokemonById(int id)
        {
            var pokemon = _BLL.GetPokemonById(id);

            if (pokemon == null)
            {
                return NotFound("Pokemon no encontrado");
            }
            return Ok(pokemon);
        }

        [HttpPost]
        public void postPokemon([FromBody] PokemonModel pokemonModel)
        {
            // en el controlador llamamos a los metodos de la logica de negocio

            _BLL.PostPokemon(pokemonModel);

        }

        [HttpDelete("{id}")]
        public Pokemon DeletePokemonById(int id)
        {
            return _BLL.DeletePokemonById(id);


        }


    }
}
