using PokemonBackend.Models;
using AutoMapper;
using Business_Logic_Layer.Models;
using Data_Acces_Layer.Repository;

namespace Business_Logic_Layer
{
    public class PokemonBLL
    {
        private Data_Acces_Layer.PokemonDAL _DAL;
        // transferir la entidad de pokemon al modelo?
        private Mapper _PokemonMapper;
        public PokemonBLL()
        {
            _DAL = new Data_Acces_Layer.PokemonDAL();
            var _configPokemon = new MapperConfiguration(config => config.CreateMap<Pokemon, PokemonModel>().ReverseMap());

            _PokemonMapper = new Mapper(_configPokemon);        
        }
        public List<PokemonModel> GetPokemons()
        {

          List<Pokemon> pokemonFromDB = _DAL.GetPokemons();  
            List<PokemonModel> pokemonModel = _PokemonMapper.Map<List<Pokemon>, List<PokemonModel>>(pokemonFromDB);

            return pokemonModel;
        }


        public PokemonModel GetPokemonById(int id)
        {
            var pokemonEntity = _DAL.GetPokemonById(id); 

            PokemonModel pokemonModel = _PokemonMapper.Map<Pokemon, PokemonModel>(pokemonEntity);   
            
            // logica tambien puede estar en el controlador con el ActionResult
            /*
            if (pokemonEntity == null)
            {
                throw new Exception("ID de Pokemon no encontrado");
            }
            */
            return pokemonModel;
               
        }

        public void PostPokemon(PokemonModel pokemonModel)
        {
            Pokemon pokemonEntity = _PokemonMapper.Map<PokemonModel, Pokemon>(pokemonModel);


            var value = new Random().Next(0, 100);

            if (value < 10)
            {
                pokemonEntity.Shiny = true;
            }
            else
            {
                pokemonEntity.Shiny = false;
            }

            _DAL.PostPokemon(pokemonEntity);
        }

        public Pokemon DeletePokemonById(int id)
        {
            var db = new MyDbContext();
            var data = _DAL.DeletePokemonById(id);

            if (data == null)
            {
                throw new Exception("ID de Pokemon no encontrado");
            }
            db.Remove(data);
            db.SaveChanges();
            return data;
        }





    }
}