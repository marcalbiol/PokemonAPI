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

namespace Logica_Negocio
{
    public class EntrenadorBLL
    {
        private Acceso_BD.EntrenadorDAL _DAL;

        private Mapper _EntrenadorMapper;

        // constructor
        public EntrenadorBLL()
        {
            _DAL = new Acceso_BD.EntrenadorDAL();

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Entrenador, EntrenadorModel>()
                    .ForMember(t=> t.EntrenadoresPokemons, opt=>  opt.MapFrom(t=>t.Entrenador_Pokemons))
                   .ReverseMap();
            });
            _EntrenadorMapper = new Mapper(config);   
        }

        public List<EntrenadorModel> GetEntrenador()
        {

            List<Entrenador> entrenadorFromDB = _DAL.GetEntrenadores();
            List<EntrenadorModel> entrenadorModel= _EntrenadorMapper.Map<List<Entrenador>, List<EntrenadorModel>>(entrenadorFromDB);

            return entrenadorModel;
        }


        public EntrenadorModel GetEntrenadorById(int id)
        {
            var entrenadorEntity = _DAL.GetEntrenadorById(id);

            EntrenadorModel entrenadorModel= _EntrenadorMapper.Map<Entrenador, EntrenadorModel>(entrenadorEntity);

            // logica tambien puede estar en el controlador con el ActionResult
            /*
            if (pokemonEntity == null)
            {
                throw new Exception("ID de Pokemon no encontrado");
            }
            */
            return entrenadorModel;

        }

        public void PostEntrenador(EntrenadorModel entrenadorModel)
        {
            Entrenador entrenadorEntity = _EntrenadorMapper.Map<EntrenadorModel, Entrenador>(entrenadorModel);

            _DAL.PostEntrenador(entrenadorEntity);
        }

        public Entrenador DeleteEntrenadorById(int id)
        {
            var db = new MyDbContext();
            var data = _DAL.DeleteEntrenadorById(id);

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
