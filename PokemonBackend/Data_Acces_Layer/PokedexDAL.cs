using Acceso_BD.Repository.Entity;
using Data_Acces_Layer.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acceso_BD
{
    public class PokedexDAL
    {
        Pokedex pokedex = new Pokedex();

        public List<Pokedex> GetPokedex()
        {
            var db = new MyDbContext();
            return db.Pokedex.ToList();
        }
        public Pokedex GetPokemonById(int id)
        {
            var db = new MyDbContext();
         

           pokedex = db.Pokedex.FirstOrDefault(x => x.ID == id);

            return pokedex;
        }
    }
}
