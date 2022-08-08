﻿using AutoMapper;
using PokemonBackend.Models;
using Logica_Negocio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica_Negocio
{
    public class EntrenadorPokemonBLL
    {
        private Acceso_BD.Entrenador_PokemonDAL _DAL;
        private Mapper _EntrenadorPokemonMapper;

        public EntrenadorPokemonBLL()
        {
            _DAL = new Acceso_BD.Entrenador_PokemonDAL();

            var _confiEntrenadorPokemon = new MapperConfiguration(
                config => config.CreateMap
                <Entrenadores_Pokemon, PutEntrenadorPokemonModel>().ReverseMap());
            _EntrenadorPokemonMapper = new Mapper(_confiEntrenadorPokemon);
        }

        public void PostEntrenadorPokemon(PutEntrenadorPokemonModel model)
        {

            Entrenadores_Pokemon entrenadorEntity = _EntrenadorPokemonMapper.Map<PutEntrenadorPokemonModel, Entrenadores_Pokemon>(model);

            model.EntrenadorId = entrenadorEntity.EntrenadorId;
            model.PokemonId = entrenadorEntity.PokemonId;
            var value = new Random().Next(0, 100);
            if (value < 10)
            {
               entrenadorEntity.Shiny = true;
            }
            else
            {
                entrenadorEntity.Shiny = true;
            }

            // CONTROL DE ERRORES, CONTROLAR SI NO EXISTE EL ID Y INTRODUCIR VARIOS POKEMONS CON EL MISMO ID

            _DAL.PostEntrenadorPokemon(entrenadorEntity);

        }

      

    }
}