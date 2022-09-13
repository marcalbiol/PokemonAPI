using Acceso_BD.Repository.Entity;
using Acceso_BD.Repository.GenericRepository;
using AutoMapper;
using Data_Acces_Layer.Repository;

namespace Business_Logic_Layer.Models;

public class ZonaBll
{
    private readonly Mapper _Mapper;
    private readonly MyDbContext db = new();
    private readonly IGenericRepository<Zona> repository;
    
    public ZonaBll()
    {
        repository = new GenericRepository<Zona>();

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
        _Mapper = new Mapper(configuration);
    }
    
    public ZonaBll(IGenericRepository<Zona> repository)
    {
        this.repository = repository;
    }
    
    public List<ZonaModel> GetAllZonas()
    {
        var zonaEntity = repository.GetAllData();
        return _Mapper.Map<List<Zona>, List<ZonaModel>>(zonaEntity);
    }
    
    public ZonaModel GetZonaById(int id)
    {
        var zonaEntity = repository.GetById(id);
        return _Mapper.Map<Zona, ZonaModel>(zonaEntity);
    }

    public void PostZona(PutZonaModel model)
    {
        var zonaEntity = _Mapper.Map<PutZonaModel, Zona>(model);
        repository.Insert(zonaEntity);
    }

    public void PutZona(int id, PutZonaModel model)
    {
        if (model.Id == id)
        {
            var zonaEntity = _Mapper.Map<PutZonaModel, Zona>(model);
            repository.Update(zonaEntity);
        }
    }

    public void DeletePokemonFromZona(int id)
    {
        var db = new MyDbContext();
        var EntityDB = db.Set<Pokedex>().Find(id);
        EntityDB.ZonaId = null;
        db.SaveChanges();
    }
    
    public Zona DeleteZonaById(int id)
    {
        var db = new MyDbContext();
        var data = repository.GetById(id);
        if (data == null) throw new Exception("Not Found");
        db.Remove(data);
        db.SaveChanges();
        return data;
    }
    
}