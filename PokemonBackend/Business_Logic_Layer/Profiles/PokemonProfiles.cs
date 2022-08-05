using Acceso_BD.Repository.Entity;
using AutoMapper;
using Business_Logic_Layer.Models;
using Logica_Negocio.Models;
using PokemonBackend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica_Negocio.Profiles
{
    public class PokemonProfile : Profile
    {
        public PokemonProfile()
        {
            CreateMap<Pokemon, PokemonModel>();
            CreateMap<Entrenador, EntrenadorModel>();
            CreateMap<Pokedex, PokedexModel>();
            CreateMap<Entrenadores_Pokemon, EntrenadorPokemonModel>();
        }

    }
}
