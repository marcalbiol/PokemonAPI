using PokemonBackend.Models;

namespace Business_Logic_Layer
{
    public class PokemonBLL
    {
        private Data_Acces_Layer.PokemonDAL _DAL;
        public PokemonBLL()
        {
            _DAL = new Data_Acces_Layer.PokemonDAL();
        }
        public List<Pokemon> GetPokemons()
        {
          return _DAL.GetPokemons();  
        }


        public Pokemon GetPokemonById(int id)
        {
            var data = _DAL.GetPokemonById(id); 
            
            // logica
            if (data == null)
            {
                throw new Exception("ID de Pokemon no encontrado");
            }
            return data;
               
        }

    }
}