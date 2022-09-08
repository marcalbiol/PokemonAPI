using AutoMapper;
using Business_Logic_Layer;
using Business_Logic_Layer.Models;
using Data_Acces_Layer.Repository;
using Microsoft.AspNetCore.Mvc;
using PokemonBackend.Models;

namespace PokemonBackend.Controllers;

[Route("api/[controller]")]
[ApiController]
public class EntrenadoresPokemons : ControllerBase
{
    private readonly MyDbContext db = new();
    public EntrenadorPokemonBLL _BLL;
    private Mapper _EntrenadorPokemonMapper;

    public EntrenadoresPokemons()
    {
        _BLL = new EntrenadorPokemonBLL();

        var _confiEntrenadorPokemon = new MapperConfiguration(
            config => config.CreateMap
                <Entrenadores_Pokemon, PutEntrenadorPokemonModel>().ReverseMap());
        _EntrenadorPokemonMapper = new Mapper(_confiEntrenadorPokemon);
    }


    [HttpGet]
    public IQueryable<EntrenadorPokemonModel> GetEntrenador()
    {
        var Entrenador = from pk in db.Pokemons
            join ep in db.Entrenadores_Pokemons
                on pk.Id equals ep.PokemonId
            join et in db.Entrenadores
                on ep.EntrenadorId equals et.Id
            join pkx in db.Pokedex
                on pk.PokedexId equals pkx.ID
            select new EntrenadorPokemonModel
            {
                Pokemon = pkx.Nombre,
                Entrenador = et.Nombre,
                Shiny = ep.Shiny
            };

        return Entrenador;
    }

    [HttpGet("{id}")]
    public IQueryable<EntrenadorPokemonModel> GetEntrenadorById(int id)
    {
        var Entrenador = from pk in db.Pokemons
            join ep in db.Entrenadores_Pokemons
                on pk.Id equals ep.PokemonId
            join et in db.Entrenadores
                on ep.EntrenadorId equals et.Id
            join pkx in db.Pokedex
                on pk.PokedexId equals pkx.ID
            where ep.Id == id
            select new EntrenadorPokemonModel
            {
                Pokemon = pkx.Nombre,
                Entrenador = et.Nombre,
                Shiny = ep.Shiny
            };
        return Entrenador;
    }

    [HttpPost]
    public void postEntPok([FromBody] PutEntrenadorPokemonModel Model)
    {
        // en el controlador llamamos a los metodos de la logica de negocio
        _BLL.PostEntrenadorPokemon(Model);
    }

    [HttpPut]
    public void PutEntrenadorPokemon(int id, PutEntrenadorPokemonModel model)
    {
        _BLL.PutEntrenador(id, model);
    }
}