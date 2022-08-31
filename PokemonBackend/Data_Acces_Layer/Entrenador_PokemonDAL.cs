using Data_Acces_Layer.Repository;
using PokemonBackend.Models;

namespace Acceso_BD
{
    public class Entrenador_PokemonDAL
    {
        Entrenadores_Pokemon ep = new Entrenadores_Pokemon();

        public List<Entrenadores_Pokemon> GetAll()
        {
            var db = new MyDbContext();
            return db.Entrenadores_Pokemons.ToList();
        }

        public void PostEntrenadorPokemon(Entrenadores_Pokemon entrenador_pokemons)
        {
            var db = new MyDbContext();
            db.Add(entrenador_pokemons);
            db.SaveChanges();
        }


        public void PutEntrenadorPokemon(Entrenadores_Pokemon entrenador_pokemons)
        {
            var db = new MyDbContext();
            db.Update(entrenador_pokemons);
            db.SaveChanges();
        }


        public Entrenadores_Pokemon GetEntById(int id)
        {
            var db = new MyDbContext();
            ep = db.Entrenadores_Pokemons.FirstOrDefault(x => x.Id == id);

            return ep;
        }


    }
}
