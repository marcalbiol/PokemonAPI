using Acceso_BD.Repository.Entity;
using Acceso_BD.Repository.GenericRepository;
using AutoMapper;
using Business_Logic_Layer.Models;
using Data_Acces_Layer.Repository;

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

        var configuration = new MapperConfiguration(cfg =>
        {
            cfg.CreateMap<Pokedex, PokedexModel>()
                .ForMember(dest => dest.Tipos, opt
                    => opt.MapFrom(src => src.Tipos))
                .ForMember(dest => dest.Region, opt
                    => opt.MapFrom(src => src.Region))
                .ForMember(dest => dest.Tier, opt 
                    => opt.MapFrom(src => src.Tier))
                .ForMember(dest => dest.Zonas, opt
                    => opt.MapFrom(src => src.Zona));
            cfg.CreateMap<Region, RegionModel>();
            cfg.CreateMap<Tier, TierModel>();
            cfg.CreateMap<Tipo, TipoModel>();
            cfg.CreateMap<Zona, ZonaModel>();
            cfg.CreateMap<PokedexZonaModel, Pokedex>()
                .ForPath(dest => dest.Zona.Id, opt => opt.MapFrom(src => src.ZonaId)).ReverseMap();
        });
        _PokedexMapper = new Mapper(configuration);
    }

    public PokedexBLL(IGenericRepository<Pokedex> repository)
    {
        this.repository = repository;
    }

    public List<PokedexModel> GetPokedex(Pagination pagination)
    {
        var pokemonFromDB = repository.GetByPag(pagination);
        var pokedexModel = _PokedexMapper.Map<List<Pokedex>, List<PokedexModel>>(pokemonFromDB);

        return pokedexModel
            .OrderBy(on => on.ID)
            .Skip((pagination.Pagina - 1) * pagination.TamañoPagina)
            .Take(pagination.TamañoPagina)
            .ToList();
    }

    public void PutPokedexZona(int id, PokedexZonaModel model)
    {
        if (model.Id == id)
        {
            var pokEntity = _PokedexMapper.Map<PokedexZonaModel, Pokedex>(model);
            repository.Update(pokEntity);
        }
    }
    public List<PokedexModel> GetByName(string name)
    {
        var pokedexDB = repository.GetAllData();
        var pokedexModel = _PokedexMapper.Map<List<Pokedex>, List<PokedexModel>>(pokedexDB);

        var pokFind = pokedexModel
            .Where(t => t.Nombre == name)
            .ToList();
        //TODO control de error si el pokemon no existe
        return pokFind; 
    }
    
    public List<PokedexModel> GetTierByName(string tierName)
    {
        var pokedexDB = repository.GetAllData();
        var pokedexModel = _PokedexMapper.Map<List<Pokedex>, List<PokedexModel>>(pokedexDB);
        
        var pokFind = pokedexModel
            .OrderBy(i => i.ID)
            .Where(t => t.Tier.Descripcion == tierName)
            .ToList();
        //TODO control de error si el pokemon no existe
        return pokFind; 
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

    public void SeedImageURL()
    {
        //TODO coger la longitud de la pokedex 
        for (var id = 1; id <= 151; id++)
        {
            var url = $"https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/{id}.png";
            var PokedexEntityDB = db.Set<Pokedex>().Find(id);
            PokedexEntityDB.Imagen = url;
        }
        db.SaveChanges();
    }
}