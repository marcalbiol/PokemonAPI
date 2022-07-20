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
    public class MyDbContext : DbContext
    {

        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {

        }
       
        //constructor
        public DbSet<Pokemon> Pokemons { get; set; }
        public DbSet<Entrenador> Entrenadores { get; set; }
        public DbSet<Tipo_Pokemons> Tipo_Pokemons { get; set; }
        public DbSet<Tipo> Tipos { get; set; }
        public DbSet<Entrenador_Pokemon> Entrenadores_Pokemons { get; set; }
         


        // configuracion de relaciones con FluentAPI
        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {

            // ManyToMany Pokemon Entrenador

            // ForeignKey
            modelbuilder.Entity<Entrenador_Pokemon>()
                .HasKey(ep => new { ep.EntrenadorId, ep.PokemonId });

            //Entrenador
            modelbuilder.Entity<Entrenador_Pokemon>()
                .HasOne(e => e.Entrenador)
                .WithMany(p => p.Entrenador_Pokemons)
                .HasForeignKey(e => e.EntrenadorId);

            // Pokemons
            modelbuilder.Entity<Entrenador_Pokemon>()
              .HasOne(p => p.Pokemon)
              .WithMany(p => p.Entrenador_Pokemons)
              .HasForeignKey(e => e.PokemonId);

            // ManyToMany Pokemon Tipos

            // ForeignKey
            modelbuilder.Entity<Tipo_Pokemons>()
                .HasKey(tp => new { tp.TipoId, tp.PokemonId });

            modelbuilder.Entity<Tipo_Pokemons>()
                .HasOne(p => p.Pokemon)
                .WithMany(t => t.Tipos)
                .HasForeignKey(tp => tp.PokemonId);

            modelbuilder.Entity<Tipo_Pokemons>()
                .HasOne(p => p.Tipo)
                .WithMany(t => t.Tipos)
                .HasForeignKey(tp => tp.TipoId);


            // DATA-SEED

            modelbuilder.Entity<Tipo>().HasData(
                new Tipo { Id = 1, Tipo_pokemon = "Fuego", Ventaja = "Planta", Desventaja = "Agua" },
                new Tipo { Id = 2, Tipo_pokemon = "Agua", Ventaja = "Fuego", Desventaja = "Planta" },
                new Tipo { Id = 3, Tipo_pokemon = "Planta", Ventaja = "Agua", Desventaja = "Fuego" }
                );

            modelbuilder.Entity<Pokemon>().HasData(
                new Pokemon { Id = 1, Nombre = "Charmander"},
                new Pokemon { Id = 2, Nombre = "Squirtle" },
                new Pokemon { Id = 3, Nombre = "Bulbasaur" }
                );

            modelbuilder.Entity<Tipo_Pokemons>().HasData (
                new Tipo_Pokemons { PokemonId = 1, TipoId = 1 },
                new Tipo_Pokemons { PokemonId = 2, TipoId = 2 },
                new Tipo_Pokemons { PokemonId = 3, TipoId = 3 }
                );
           

            base.OnModelCreating(modelbuilder);

        }

    }
    /* PARA ACTUALIZAR LA TABLA. ADD-MIGRATION  (FECHA QUE SE EJECUTA). DESPUES UPDATE-DATABASE */
}