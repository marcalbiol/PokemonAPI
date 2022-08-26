using AutoMapper;
using Business_Logic_Layer.Models;
using Data_Acces_Layer.Repository;
using Logica_Negocio.Models;
using PokemonBackend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Acceso_BD.Repository.GenericRepository;

namespace Logica_Negocio
{
    public class EntrenadorBLL
    {
        private IGenericRepository<Entrenador> repository = null;
        private IGenericReadOnlyRepository<Entrenador> repositoryRO = null;
        private Acceso_BD.EntrenadorDAL _DAL;
        private Mapper _EntrenadorMapper;

        // constructor
        public EntrenadorBLL()
        {
            this.repository = new GenericRepository<Entrenador>();

            _DAL = new Acceso_BD.EntrenadorDAL();
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Entrenador, EntrenadorModel>()
                   .ReverseMap();
            });
            _EntrenadorMapper = new Mapper(config);   
        }

        public EntrenadorBLL(IGenericRepository<Entrenador> repository,
            IGenericReadOnlyRepository<Entrenador> repositoryRO)
        {
            this.repository = repository;
            this.repositoryRO = repositoryRO;
        }

        public List<EntrenadorModel> GetEntrenador()
        {
            List<Entrenador> entrenadorFromDB = repositoryRO.GetAll();
            List<EntrenadorModel> entrenadorModel= _EntrenadorMapper.Map<List<Entrenador>, List<EntrenadorModel>>(entrenadorFromDB);

            return entrenadorModel;
        }


        public EntrenadorModel GetEntrenadorById(int id)
        {
            var entrenadorEntity = repositoryRO.GetById(id);

            EntrenadorModel entrenadorModel= _EntrenadorMapper.Map<Entrenador, EntrenadorModel>(entrenadorEntity);

            return entrenadorModel;

        }

        public void PostEntrenador(EntrenadorModel entrenadorModel)
        {
            Entrenador entrenadorEntity = _EntrenadorMapper.Map<EntrenadorModel, Entrenador>(entrenadorModel);
            repository.Insert(entrenadorEntity);
        }
        
        public void PutEntrenador(int id, EntrenadorModel entrenadorModel)
        {
            if(entrenadorModel.Id == id)
            {
                Entrenador entrenadorEntity = _EntrenadorMapper.Map<EntrenadorModel, Entrenador>(entrenadorModel);
                repository.Update(entrenadorEntity);
            } // manejo de errores si el id no coincide
              
        }

        public Entrenador DeleteEntrenadorById(int id)
        {
            var db = new MyDbContext();
            var data = repositoryRO.GetById(id);

            if (data == null)
            {
                throw new Exception("ID de Entrenador no encontrado");
            }
            db.Remove(data);
            db.SaveChanges();
            return data;
        }



    }
}
