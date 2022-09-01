using Acceso_BD.Repository.Entity;
using Acceso_BD.Repository.GenericRepository;
using AutoMapper;
using Data_Acces_Layer.Repository;
using Logica_Negocio.Models;

namespace Logica_Negocio
{
    public class PokedexBLL
    {
        private IGenericRepository<Pokedex> repository = null;
        private IGenericReadOnlyRepository<Pokedex> repositoryRO = null;
        private MyDbContext db = new MyDbContext();

        // transferir la entidad de pokemon al modelo
        private Mapper _PokedexMapper;


        public PokedexBLL()
        {
            this.repository = new GenericRepository<Pokedex>();
            var _configPokemon = new MapperConfiguration(config => config.CreateMap<Pokedex, PokedexModel>().ReverseMap());

            _PokedexMapper = new Mapper(_configPokemon);

        }

        public PokedexBLL(IGenericRepository<Pokedex> repository)
        {
            this.repository = repository;
        }

        public List<PokedexModel> GetPokedex(Pagination pagination)
        {
            List<Pokedex> pokemonFromDB = repository.GetAll(pagination);
            List<PokedexModel> pokedexModel = _PokedexMapper.Map<List<Pokedex>, List<PokedexModel>>(pokemonFromDB);

            return pokedexModel
                .OrderBy(on => on.ID)
                .Skip((pagination.Pagina - 1) * pagination.TamañoPagina)
                .Take(pagination.TamañoPagina)
                .ToList();
        }

        public PokedexModel GetPokedexById(int id)
        {
            var pokemonEntity = repository.GetById(id);
            PokedexModel pokedexModel = _PokedexMapper.Map<Pokedex, PokedexModel>(pokemonEntity);
            return pokedexModel;
        }

        public List<PokedexModel> GetAll()
        {
            List<Pokedex> pokemonFromDB = repository.GetAllData();
            List<PokedexModel> pokedexModel = _PokedexMapper.Map<List<Pokedex>, List<PokedexModel>>(pokemonFromDB);
            return pokedexModel;

        }

        public void PokedexEdit(int id, PokedexModel model)
        {
            if (model.ID == id)
            {
                Pokedex entrenadorEntity = _PokedexMapper.Map<PokedexModel, Pokedex>(model);
                repository.Update(entrenadorEntity);
            }
        }

        public void PutImage()
        {
            // TODO que no sea metodo put SINO get y solo ejecute el metodo
            for (var id = 1; id <=151; id++)
            {
                var url = $"https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/{id}.png";
                var PokedexEntityDB = db.Set<Pokedex>().Find(id);
                PokedexEntityDB.Imagen = url;
            }
            db.SaveChanges();
        }
    }
}
