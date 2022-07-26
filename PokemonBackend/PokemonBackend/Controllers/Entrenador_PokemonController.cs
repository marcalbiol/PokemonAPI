using Logica_Negocio.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PokemonBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class Entrenador_PokemonController : ControllerBase
    {

        public Logica_Negocio.Entrenador_PokemonBLL _BLL  { get; set; }

        public Entrenador_PokemonController()
        {
            _BLL = new Logica_Negocio.Entrenador_PokemonBLL();
        }

        // metodo para asignar un pokemon al entrenador

        [HttpPost]
        public void postPokemon([FromBody] Entrenador_PokemonModel entrenadorModel)
        {
            // en el controlador llamamos a los metodos de la logica de negocio


            _BLL.PostEntrenadorPokemon(entrenadorModel);

        }


    }
}
