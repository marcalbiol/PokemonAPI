using Acceso_BD.Repository.Entity;
using Acceso_BD.Repository.GenericRepository;
using AutoMapper;
using Data_Acces_Layer.Repository;

namespace Business_Logic_Layer.Models;

public class RegionBll
{
    private readonly Mapper _Mapper;
    private readonly MyDbContext db = new();
    private readonly IGenericRepository<Region> repository;

    public RegionBll()
    {
        repository = new GenericRepository<Region>();

        var configuration = new MapperConfiguration(cfg => { cfg.CreateMap<Region, RegionModel>(); });
        _Mapper = new Mapper(configuration);
    }

    public RegionBll(IGenericRepository<Region> repository)
    {
        this.repository = repository;
    }

    public List<RegionModel> GetAllRegions()
    {
        var regionEntity = repository.GetAllData();
        return _Mapper.Map<List<Region>, List<RegionModel>>(regionEntity);
    }
}