using Acceso_BD;
using Acceso_BD.Repository.GenericRepository;
using AutoMapper;
using Business_Logic_Layer.Models;
using PokemonBackend.Models;

namespace Business_Logic_Layer;

public class EntrenadorPokemonBLL
{
    private readonly Entrenador_PokemonDAL _DAL;
    private readonly Mapper _EntrenadorPokemonMapper;
    private readonly IGenericRepository<Entrenadores_Pokemon> repository;


    public EntrenadorPokemonBLL()
    {
        repository = new GenericRepository<Entrenadores_Pokemon>();
        _DAL = new Entrenador_PokemonDAL();

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
        var entrenadorEntity = _EntrenadorPokemonMapper.Map<PutEntrenadorPokemonModel, Entrenadores_Pokemon>(model);

        var value = new Random().Next(0, 100);
        entrenadorEntity.Shiny = EsShiny(value);

        // CONTROL DE ERRORES, CONTROLAR SI NO EXISTE EL ID Y INTRODUCIR VARIOS POKEMONS CON EL MISMO ID
        _DAL.PostEntrenadorPokemon(entrenadorEntity);
    }

    public void PutEntrenador(int id, PutEntrenadorPokemonModel model)
    {
        if (model.Id == id && id == model.EntrenadorId)
        {
            var entrenadorEntity = _EntrenadorPokemonMapper.Map<PutEntrenadorPokemonModel, Entrenadores_Pokemon>(model);
            repository.Update(entrenadorEntity);
        } // manejo de errores si el id no coincide
    }

    public static bool EsShiny(int value)
    {
        if (value < 50)
            return true;
        return false;
    }
}