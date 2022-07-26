using Logica_Negocio.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PokemonBackend.Models;

namespace PokemonBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class EntrenadorController : ControllerBase
    {
        public Logica_Negocio.EntrenadorBLL _BLL { get; set; } 

        public EntrenadorController()
        {
            _BLL = new Logica_Negocio.EntrenadorBLL();
        }


        [HttpGet]
        public List<EntrenadorModel> GetEntrenador()
        {
            return _BLL.GetEntrenador();
        }

        [HttpGet("{id}")]
        public ActionResult<EntrenadorModel> GetEntrenadorById(int id)
        {
            var value = _BLL.GetEntrenadorById(id);

            if (value == null)
            {
                return NotFound("entrenador no encontrado");
            }
            return Ok(value);
        }

        [HttpPost]
        public void postPokemon([FromBody] EntrenadorModel entrenadorModel)
        {
            // en el controlador llamamos a los metodos de la logica de negocio

            _BLL.PostEntrenador(entrenadorModel);

        }

        [HttpDelete("{id}")]
        public Entrenador DeleteEntrenadorById(int id)
        {
            return _BLL.DeleteEntrenadorById(id);

        }


    }
}
