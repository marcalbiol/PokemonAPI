using Data_Acces_Layer.Repository;
using PokemonBackend.Models;


namespace Data_Acces_Layer
{
    public class PokemonDAL
    {

        Pokemon pokemons = new Pokemon();

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

        public void PostPokemon(Pokemon pokemon)
        {
            var db = new MyDbContext();
            db.Add(pokemon);
            db.SaveChanges();
        }

        public Pokemon DeletePokemonById(int id)
        {
            var db = new MyDbContext();
            Pokemon pokemon = new Pokemon();

            // comprobamos si el id es el mismo
            pokemon = db.Pokemons.FirstOrDefault(x => x.Id == id);

            return pokemon;
        }
    }
}