﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PokemonBackend.Models;
using Business_Logic_Layer.Models;
using Data_Acces_Layer.Repository;
using Logica_Negocio.Models;

namespace PokemonBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class PokedexController : ControllerBase
    {

        public Logica_Negocio.PokedexBLL _BLL;
        public PokedexController()
        {
            _BLL = new Logica_Negocio.PokedexBLL();
        }   

        [HttpGet]
        public List<PokedexModel> GetPokedex()
        {
            return _BLL.GetPokedex();
        }

        [HttpGet("{id}")]
        public ActionResult<PokedexModel> GetPokedexById(int id)
        {
            var pokemon = _BLL.GetPokedexById(id);

            if (pokemon == null)
            {
                return NotFound("Pokemon no encontrado");
            }
            return Ok(pokemon);
        }
    }
}