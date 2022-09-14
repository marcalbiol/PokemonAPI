using Acceso_BD.Repository.Entity;
using Acceso_BD.Repository.GenericRepository;
using AutoMapper;
using Business_Logic_Layer.Models;
using Data_Acces_Layer.Repository;
using PokemonBackend.Models;

namespace Business_Logic_Layer;

public class EntrenadorBLL
{
    private readonly Mapper _EntrenadorMapper;
    private readonly IGenericRepository<Entrenador> repository;

    // constructor
    public EntrenadorBLL()
    {
        repository = new GenericRepository<Entrenador>();

        var config = new MapperConfiguration(cfg =>
        {
            cfg.CreateMap<Entrenador, EntrenadorModel>()
                .ReverseMap();
        });
        _EntrenadorMapper = new Mapper(config);
    }

    public List<EntrenadorModel> GetEntrenador(Pagination pagination)
    {
        var entrenadorFromDB = repository.GetByPag(pagination);
        var entrenadorModel = _EntrenadorMapper.Map<List<Entrenador>, List<EntrenadorModel>>(entrenadorFromDB);

        return entrenadorModel
            .OrderBy(on => on.Id)
            .Skip((pagination.Pagina - 1) * pagination.TamañoPagina)
            .Take(pagination.TamañoPagina)
            .ToList();
    }


    public EntrenadorModel GetEntrenadorById(int id)
    {
        var entrenadorEntity = repository.GetById(id);

        var entrenadorModel = _EntrenadorMapper.Map<Entrenador, EntrenadorModel>(entrenadorEntity);

        return entrenadorModel;
    }

    public void PostEntrenador(EntrenadorModel entrenadorModel)
    {
        var entrenadorEntity = _EntrenadorMapper.Map<EntrenadorModel, Entrenador>(entrenadorModel);
        repository.Insert(entrenadorEntity);
    }

    public void PutEntrenador(int id, EntrenadorModel entrenadorModel)
    {
        if (entrenadorModel.Id == id)
        {
            var entrenadorEntity = _EntrenadorMapper.Map<EntrenadorModel, Entrenador>(entrenadorModel);
            repository.Update(entrenadorEntity);
        } // manejo de errores si el id no coincide
    }

    public Entrenador DeleteEntrenadorById(int id)
    {
        var db = new MyDbContext();
        var data = repository.GetById(id);

        if (data == null) throw new Exception("ID de Entrenador no encontrado");
        db.Remove(data);
        db.SaveChanges();
        return data;
    }
}