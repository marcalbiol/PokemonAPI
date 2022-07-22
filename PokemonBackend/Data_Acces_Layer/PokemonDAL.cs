using Data_Acces_Layer.Repository;
using PokemonBackend.Models;


namespace Data_Acces_Layer
{
    public class PokemonDAL
    {
        public List<Pokemon> GetPokemons()
        {
            var db = new MyDbContext();
            return db.Pokemons.ToList(); 
        }

        public Pokemon GetPokemonById(int id)
        {
            var db = new MyDbContext();
            Pokemon pokemon = new Pokemon();

            pokemon = db.Pokemons.FirstOrDefault(x => x.Id == id);
        
            return pokemon;
        }
    }
}