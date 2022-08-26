using AutoMapper;
using PokemonBackend.Models;
using Logica_Negocio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using Data_Acces_Layer.Repository;
using Acceso_BD.Repository.GenericRepository;

namespace Logica_Negocio
{
    public class EntrenadorPokemonBLL
    {
        private IGenericRepository<Entrenadores_Pokemon> repository = null;
        private Acceso_BD.Entrenador_PokemonDAL _DAL;
        private Mapper _EntrenadorPokemonMapper;


        public EntrenadorPokemonBLL()
        {
            this.repository = new GenericRepository<Entrenadores_Pokemon>();
            _DAL = new Acceso_BD.Entrenador_PokemonDAL();

            var _confiEntrenadorPokemon = new MapperConfiguration(
                config => config.CreateMap
                <Entrenadores_Pokemon, PutEntrenadorPokemonModel>().ReverseMap());
            _EntrenadorPokemonMapper = new Mapper(_confiEntrenadorPokemon);
        }

        public EntrenadorPokemonBLL(IGenericRepository<Entrenadores_Pokemon> repository)
        {
            this.repository = repository;
        }


        public void PostEntrenadorPokemon(PutEntrenadorPokemonModel model)
        {
            Entrenadores_Pokemon entrenadorEntity = _EntrenadorPokemonMapper.Map<PutEntrenadorPokemonModel, Entrenadores_Pokemon>(model);

            var value = new Random().Next(0, 100);
            entrenadorEntity.Shiny = EsShiny(value);

            // CONTROL DE ERRORES, CONTROLAR SI NO EXISTE EL ID Y INTRODUCIR VARIOS POKEMONS CON EL MISMO ID
            _DAL.PostEntrenadorPokemon(entrenadorEntity);
        }

        public void PutEntrenador(int id, PutEntrenadorPokemonModel model)
        {
            if (model.Id == id && id == model.EntrenadorId)
            {
                Entrenadores_Pokemon entrenadorEntity = _EntrenadorPokemonMapper.Map<PutEntrenadorPokemonModel, Entrenadores_Pokemon>(model);
                repository.Update(entrenadorEntity);
            } // manejo de errores si el id no coincide

        }

        public static Boolean EsShiny (int value)
        {
            if (value < 50)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
