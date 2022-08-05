using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data_Acces_Layer.Repository;
using PokemonBackend.Models;

namespace Acceso_BD
{
    public class Entrenador_PokemonDAL
    {
       

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
    }
}
