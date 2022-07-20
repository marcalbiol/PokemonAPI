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
      
         
        // configuracion de relaciones con FluentAPI
        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {

            // Relacion OneToMany
            modelbuilder.Entity<Entrenador>()
                 .HasMany(p => p.Pokemons)
                 .WithOne(e => e.Entrenador)
                 .IsRequired();


            // ManyToMany
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

            base.OnModelCreating(modelbuilder);

        }

    }
    /* PARA ACTUALIZAR LA TABLA. ADD-MIGRATION  (FECHA QUE SE EJECUTA). DESPUES UPDATE-DATABASE */
}