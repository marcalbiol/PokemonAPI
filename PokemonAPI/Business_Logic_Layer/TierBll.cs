using Acceso_BD.Repository.Entity;
using Acceso_BD.Repository.GenericRepository;
using AutoMapper;
using Business_Logic_Layer.Models;
using Data_Acces_Layer.Repository;

namespace Business_Logic_Layer;

public class TierBll
{
    private readonly Mapper _Mapper;
    private readonly MyDbContext db = new();
    private readonly IGenericRepository<Tier> repository;


    public TierBll()
    {
        repository = new GenericRepository<Tier>();
        var configuration = new MapperConfiguration(
            cfg => { cfg.CreateMap<Tier, TierModel>(); });
        _Mapper = new Mapper(configuration);
    }

    public TierBll(IGenericRepository<Tier> repository)
    {
        this.repository = repository;
    }

    public List<TierModel> GetAllTiers()
    {
        var tierEntity = repository.GetAllData();
        return _Mapper.Map<List<Tier>, List<TierModel>>(tierEntity);
    }
}