using Acceso_BD.Repository.Entity;
using Acceso_BD.Repository.GenericRepository;
using AutoMapper;
using Business_Logic_Layer.Models;
using Data_Acces_Layer.Repository;

namespace Business_Logic_Layer;

public class ZonaBll
{
    private readonly MyDbContext _db = new();
    private readonly Mapper _mapper;
    private readonly IGenericRepository<Zona> _repository;

    public ZonaBll()
    {
        _repository = new GenericRepository<Zona>();

        var configuration = new MapperConfiguration(
            cfg =>
            {
                cfg.CreateMap<Zona, ZonaModel>()
                    .ForMember(dest => dest.Pokemon, opt
                        => opt.MapFrom(src => src.Pokedex)
                    ).ReverseMap();
                cfg.CreateMap<Zona, PutZonaModel>().ReverseMap();
                cfg.CreateMap<Pokedex, PokeZonaModel>().ReverseMap();
            });
        _mapper = new Mapper(configuration);
    }

    public List<ZonaModel> GetAllZonas()
    {
        var zonaEntity = _repository.GetAllData();
        return _mapper.Map<List<Zona>, List<ZonaModel>>(zonaEntity);
    }

    public ZonaModel GetZonaById(int id)
    {
        var zonaEntity = _repository.GetById(id);
        return _mapper.Map<Zona, ZonaModel>(zonaEntity);
    }

    public void PostZona(PutZonaModel model)
    {
        var zonaEntity = _mapper.Map<PutZonaModel, Zona>(model);
        _repository.Insert(zonaEntity);
    }

    public void PutZona(int id, PutZonaModel model)
    {
        if (model.Id == id)
        {
            var zonaEntity = _mapper.Map<PutZonaModel, Zona>(model);
            _repository.Update(zonaEntity);
        }
    }

    public void DeletePokemonFromZona(int id)
    {
        var entityDb = PokedexBLL.FindPokemonInDb(id);
        entityDb.ZonaId = null;
        _db.SaveChanges();
        //TODO fix
    }

    public Zona DeleteZonaById(int id)
    {
        var data = _repository.GetById(id);
        if (data == null) throw new Exception("Not Found");
        _db.Remove(data);
        _db.SaveChanges();
        return data;
    }
}