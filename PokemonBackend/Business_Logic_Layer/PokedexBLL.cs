using Acceso_BD.Repository.Entity;
using Acceso_BD.Repository.GenericRepository;
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
        private IGenericRepository<Pokedex> repository = null;
        private IGenericReadOnlyRepository<Pokedex> repositoryRO = null;


        private Acceso_BD.PokedexDAL _DAL;
        // transferir la entidad de pokemon al modelo
        private Mapper _PokedexMapper;


        public PokedexBLL()
        {
            this.repository = new GenericRepository<Pokedex>();
            _DAL = new Acceso_BD.PokedexDAL();
            var _configPokemon = new MapperConfiguration(config => config.CreateMap<Pokedex, PokedexModel>().ReverseMap());

            _PokedexMapper = new Mapper(_configPokemon);

        }

        public PokedexBLL(IGenericRepository<Pokedex> repository)
        {
            this.repository = repository;
        }

        public List<PokedexModel> GetPokedex(Pagination pagination)
        {
            List<Pokedex> pokemonFromDB = repository.GetAll(pagination);
            List<PokedexModel> pokedexModel = _PokedexMapper.Map<List<Pokedex>, List<PokedexModel>>(pokemonFromDB);

            return pokedexModel
                .OrderBy(on => on.ID)
                .Skip((pagination.PageNumber - 1) * pagination.PageSize)
                .Take(pagination.PageSize)
                .ToList();
        }


        public PokedexModel GetPokedexById(int id)
        {
            var pokemonEntity = repository.GetById(id);

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
