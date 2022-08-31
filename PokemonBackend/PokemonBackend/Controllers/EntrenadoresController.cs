using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Data_Acces_Layer.Repository;
using PokemonBackend.Models;
using Logica_Negocio.Models;
using Acceso_BD.Repository.GenericRepository;
using Acceso_BD.Repository.Entity;

namespace PokemonBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EntrenadorController : ControllerBase
    {
        private MyDbContext db = new MyDbContext();
        public Logica_Negocio.EntrenadorBLL _BLL;


        public EntrenadorController()
        {
            _BLL = new Logica_Negocio.EntrenadorBLL();
        }

        [HttpGet]
        public List<EntrenadorModel> GetEntrenadors([FromQuery] Pagination pagination)
        {
            return _BLL.GetEntrenador(pagination);

        }

        [HttpPost]
        public void PostEntrenador([FromBody] EntrenadorModel entrenadorModel)
        {
            // en el controlador llamamos a los metodos de la logica de negocio
            _BLL.PostEntrenador(entrenadorModel);
        }

        [HttpPut]
        public void PutEntrenador(int id, EntrenadorModel entrenadorModel)
        {
            _BLL.PutEntrenador(id, entrenadorModel);
        }

        [HttpDelete("{id}")]
        public Entrenador DeleteEntrenadorById(int id)
        {
            return _BLL.DeleteEntrenadorById(id);

        }
    }
}
