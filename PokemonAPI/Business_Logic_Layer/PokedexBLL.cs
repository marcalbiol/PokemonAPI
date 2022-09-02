using Acceso_BD.Repository.Entity;
using Acceso_BD.Repository.GenericRepository;
using AutoMapper;
using Business_Logic_Layer.Models;
using Data_Acces_Layer.Repository;
using PokemonBackend.Models;

namespace Business_Logic_Layer;

public class PokedexBLL
{
    // transferir la entidad de pokemon al modelo
    private readonly Mapper _PokedexMapper;
    private readonly MyDbContext db = new();
    private readonly IGenericRepository<Pokedex> repository;


    public PokedexBLL()
    {
        repository = new GenericRepository<Pokedex>();
        
        var configuration = new MapperConfiguration(cfg => {
            cfg.CreateMap<Pokedex, PokedexModel>()
                //.Include<Tipo, TipoModel>()
                .ForMember(dest => dest.Tipos, opt => opt.MapFrom(src => src.Tipos))
                .ForMember(dest => dest.Region, opt => opt.MapFrom(src => src.Region));
            cfg.CreateMap<Region, RegionModel>();
            cfg.CreateMap<Tipo, TipoModel>();
        });
        _PokedexMapper = new Mapper(configuration);
    }

    public PokedexBLL(IGenericRepository<Pokedex> repository)
    {
        this.repository = repository;
    }

    public List<PokedexModel> GetPokedex(Pagination pagination)
    {
        var pokemonFromDB = repository.GetAllPag(pagination);
        var pokedexModel = _PokedexMapper.Map<List<Pokedex>, List<PokedexModel>>(pokemonFromDB);

        return pokedexModel
            .OrderBy(on => on.ID)
            .Skip((pagination.Pagina - 1) * pagination.TamañoPagina)
            .Take(pagination.TamañoPagina)
            .ToList();
    }

    public PokedexModel GetPokedexById(int id)
    {
        var pokemonEntity = repository.GetById(id);
        return _PokedexMapper.Map<Pokedex, PokedexModel>(pokemonEntity);
    }

    public List<PokedexModel> GetAll()
    {
        var pokemonEntity = repository.GetAllData();
        return _PokedexMapper.Map<List<Pokedex>, List<PokedexModel>>(pokemonEntity);
    }

    public void PokedexEdit(int id, PokedexModel model)
    {
        if (model.ID == id)
        {
            var entrenadorEntity = _PokedexMapper.Map<PokedexModel, Pokedex>(model);
            repository.Update(entrenadorEntity);
        }
    }

    public void PutImage()
    {
        // TODO que no sea metodo put SINO get y solo ejecute el metodo
        for (var id = 1; id <= 151; id++)
        {
            var url = $"https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/{id}.png";
            var PokedexEntityDB = db.Set<Pokedex>().Find(id);
            PokedexEntityDB.Imagen = url;
        }

        db.SaveChanges();
    }
}