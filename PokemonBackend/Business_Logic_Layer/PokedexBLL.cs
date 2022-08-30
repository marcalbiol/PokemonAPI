using Acceso_BD.Repository.Entity;
using Acceso_BD.Repository.GenericRepository;
using AutoMapper;
using Data_Acces_Layer.Repository;
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
        private MyDbContext db = new MyDbContext();

        // transferir la entidad de pokemon al modelo
        private Mapper _PokedexMapper;


        public PokedexBLL()
        {
            this.repository = new GenericRepository<Pokedex>();
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
            return pokedexModel;
        }

        public List<PokedexModel> GetAll()
        {
            List<Pokedex> pokemonFromDB = repository.GetAllData();
            List<PokedexModel> pokedexModel = _PokedexMapper.Map<List<Pokedex>, List<PokedexModel>>(pokemonFromDB);
            return pokedexModel;

        }

        
        public void PutImage(int id)
        {
            // hacer bucle e insertar url en el campo
            var image = "test";
            var loadedEntity = db.Set<Pokedex>().Find(id); 
            loadedEntity.Imagen = image;
            db.SaveChanges();

        }
        

    }

}
