using Data_Acces_Layer.Repository;
using Logica_Negocio.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PokemonBackend.Models;

namespace PokemonBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class EntrenadorPokemonsController : ControllerBase
    {
        public Logica_Negocio.EntrenadorBLL _BLL { get; set; }
        private MyDbContext db = new MyDbContext();

        public EntrenadorPokemonsController()
        {
            _BLL = new Logica_Negocio.EntrenadorBLL();
        }

    
        /*

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

      */
    }
}
