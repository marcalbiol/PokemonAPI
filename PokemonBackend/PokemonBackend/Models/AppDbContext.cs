using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace PokemonBackend.Models
{
    // aqui indicamos cuales son los modelos que queremos en nuestra BD, en este caso
    // Pokemon y entrenador
    public class MyDbContext : IdentityDbContext<ApplicationUser>
    {

        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {

        }
        //data-seed. informacion predefinidas en la bd
       
      
        //constructor
        public DbSet<Pokemon> Pokemons { get; set; }
        public DbSet<Entrenador> Entrenadores { get; set; }


   
        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {

            // variables 
            var pokemon1 = new Pokemon() { Id = 1, Nombre = "Pikachu", Tipo = "Electrico", Nivel = 25, Ataque = 14, Defensa = 10, Vida = 30 };
            var pokemon2 = new Pokemon() { Id = 2, Nombre = "Charmander", Tipo = "Fuego", Nivel = 25, Ataque = 14, Defensa = 10, Vida = 30 };

            var entrenador1 = new Entrenador() { Id = 1, Nombre = "Marc", PokemonId = 1, Victorias = 2, Derrotas = 3 };
            var entrenador2 = new Entrenador() { Id = 2, Nombre = "Jose", PokemonId = 2, Victorias = 2, Derrotas = 3 };

            // añadimos las variables creados a la tabla
            modelbuilder.Entity<Entrenador>().HasData(new Entrenador[] { entrenador1, entrenador2 });
            modelbuilder.Entity<Pokemon>().HasData(new Pokemon[] { pokemon1, pokemon2 });

            base.OnModelCreating(modelbuilder);
        }


    }
    /* PARA ACTUALIZAR LA TABLA. ADD-MIGRATION  (FECHA QUE SE EJECUTA). DESPUES UPDATE-DATABASE */
}