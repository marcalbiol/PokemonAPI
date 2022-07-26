using Acceso_BD.Repository.Entity;
using AutoMapper;
using Logica_Negocio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica_Negocio
{
    public class PokedexBLL
    {
        private Acceso_BD.PokedexDAL _DAL;
        // transferir la entidad de pokemon al modelo
        private Mapper _PokedexMapper;


        public PokedexBLL()
        {
            _DAL = new Acceso_BD.PokedexDAL();
            var _configPokemon = new MapperConfiguration(config => config.CreateMap<Pokedex, PokedexModel>().ReverseMap());

            _PokedexMapper = new Mapper(_configPokemon);

        }

        public List<PokedexModel> GetPokedex()
        {

            List<Pokedex> pokemonFromDB = _DAL.GetPokedex();
            List<PokedexModel> pokedexModel = _PokedexMapper.Map<List<Pokedex>, List<PokedexModel>>(pokemonFromDB);

            return pokedexModel;
        }


        public PokedexModel GetPokedexById(int id)
        {
            var pokemonEntity = _DAL.GetPokemonById(id);

            PokedexModel pokedexModel = _PokedexMapper.Map<Pokedex, PokedexModel>(pokemonEntity);

            // logica tambien puede estar en el controlador con el ActionResult
            /*
            if (pokemonEntity == null)
            {
                throw new Exception("ID de Pokemon no encontrado");
            }
            */
            return pokedexModel;

        }



    }

}
