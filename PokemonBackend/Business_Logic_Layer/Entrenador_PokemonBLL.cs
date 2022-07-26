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
    public class Entrenador_PokemonBLL
    {
        private Acceso_BD.Entrenador_PokemonDAL _DAL;
        private Mapper _EntrenadorPokemonMapper;


        public Entrenador_PokemonBLL()
        {
            _DAL = new Acceso_BD.Entrenador_PokemonDAL();
            var _confiEntrenadorPokemon = new MapperConfiguration(
                config => config.CreateMap
                <Entrenadores_Pokemon, Entrenador_PokemonModel>().ReverseMap());
            _EntrenadorPokemonMapper = new Mapper(_confiEntrenadorPokemon);
        }

        public void PostEntrenadorPokemon(Entrenador_PokemonModel entrenador_PokemonModel)
        {

            Entrenadores_Pokemon entrenadores_PokemonEntity = _EntrenadorPokemonMapper
                .Map<Entrenador_PokemonModel, Entrenadores_Pokemon>(entrenador_PokemonModel);

            var value = new Random().Next(0, 100);

            if (value < 10)
            {
                entrenadores_PokemonEntity.Pokemon.Shiny = true;
            }
            else
            {
                entrenadores_PokemonEntity.Pokemon.Shiny = false;
            }

            _DAL.PostEntrenadorPokemon(entrenadores_PokemonEntity);

        }

    }
}
