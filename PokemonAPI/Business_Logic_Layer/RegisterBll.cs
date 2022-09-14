using Acceso_BD.Repository.Entity;
using Acceso_BD.Repository.GenericRepository;
using AutoMapper;
using Business_Logic_Layer.Models;
using PokemonBackend.Models;

namespace Business_Logic_Layer;

public class RegisterBll
{
    private readonly Mapper _mapper;
    private readonly IGenericRepository<Register> repository;

    public RegisterBll()
    {
        repository = new GenericRepository<Register>();

        var config = new MapperConfiguration(cfg =>
        {
            cfg.CreateMap<Register, RegisterModel>()
                .ReverseMap();
        });
        _mapper = new Mapper(config);
    }
    
    
    public void NewUser(RegisterModel model)
    {
        var entity = _mapper.Map<RegisterModel, Register>(model);
        // logica
        repository.Insert(entity);
    }
    
}