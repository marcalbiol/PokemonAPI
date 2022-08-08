using Data_Acces_Layer.Repository;
using PokemonBackend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Acceso_BD.Repository.Entity;
namespace Acceso_BD
{
   public class EntrenadorDAL
    {
       

        public List<Entrenador> GetEntrenadores()
        {
            var db = new MyDbContext();
            return db.Entrenadores.ToList();
        }


        public Entrenador GetEntrenadorById(int id)
        {
            var db = new MyDbContext();
            Entrenador entrenador = new Entrenador();

            entrenador = db.Entrenadores.FirstOrDefault(x => x.Id == id);

            return entrenador;
        }

        public void PostEntrenador(Entrenador entrenador)
        {
            var db = new MyDbContext();
            db.Add(entrenador);
            db.SaveChanges();

           // AddNuevos();
            

        }

        public void AddNuevos(int value)
        {
            Entrenadores_Pokemon ep = new Entrenadores_Pokemon();
            if (value != ep.EntrenadorId)
            {
                ep.EntrenadorId = value;
            }
        }

        public Entrenador DeleteEntrenadorById(int id)
        {
            var db = new MyDbContext();
            Entrenador entrenador = new Entrenador();

            // comprobamos si el id es el mismo
            entrenador = db.Entrenadores.FirstOrDefault(x => x.Id == id);

            return entrenador;
        }
    }
}
