﻿using Acceso_BD.Repository.Entity;
using Microsoft.EntityFrameworkCore;
using PokemonBackend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Data_Acces_Layer.Repository
{
    // aqui indicamos cuales son los modelos que queremos en nuestra BD, en este caso
    // Pokemon y entrenador
    public class MyDbContext : DbContext
    {
        public MyDbContext()
        {
        }

        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {

        }

        //constructor
        public DbSet<Pokemon> Pokemons { get; set; }
        public DbSet<Entrenador> Entrenadores { get; set; }
        public DbSet<Tipos_Pokemons> Tipo_Pokemons { get; set; }
        public DbSet<Tipo> Tipos { get; set; }
        public DbSet<Entrenadores_Pokemon> Entrenadores_Pokemons { get; set; }
        public DbSet<Stat> Stats { get; set; }
        public DbSet<Habilidades> Habilidades { get; set; }
        



        // configuracion de relaciones con FluentAPI
        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {

            // OneToMany Stats Pokemons

            // Stats
            modelbuilder.Entity<Pokemon>()
                .HasOne(s => s.Stat)
                .WithMany(p => p.Pokemons)
                .HasForeignKey(s => s.StatId)
                .OnDelete(DeleteBehavior.Cascade);

            // OneToOne Tipo Habilidades

            //TODO
            // revisar y comprobar añadiendo DATA


            modelbuilder.Entity<Tipos_Habilidades>()
                .HasKey(th => new { th.TipoId, th.HabilidadId });

            modelbuilder.Entity<Tipos_Habilidades>()
                .HasOne(t => t.Tipo)
                .WithMany(h => h.habilidades_tipos)
                .HasForeignKey(t => t.TipoId);

            modelbuilder.Entity<Tipos_Habilidades>()
            .HasOne(t => t.Habilidades)
            .WithMany(h => h.habilidades_tipos)
            .HasForeignKey(t => t.HabilidadId);





            // ManyToMany Pokemon Entrenador

            // ForeignKey
            modelbuilder.Entity<Entrenadores_Pokemon>()
                .HasKey(ep => new { ep.EntrenadorId, ep.PokemonId });

            // Entrenador
            modelbuilder.Entity<Entrenadores_Pokemon>()
                .HasOne(e => e.Entrenador)
                .WithMany(p => p.Entrenador_Pokemons)
                .HasForeignKey(e => e.EntrenadorId);

            // Pokemons
            modelbuilder.Entity<Entrenadores_Pokemon>()
              .HasOne(p => p.Pokemon)
              .WithMany(p => p.Entrenador_Pokemons)
              .HasForeignKey(e => e.PokemonId);


            // ManyToMany Pokemon Tipos

            // ForeignKey
            modelbuilder.Entity<Tipos_Pokemons>()
                .HasKey(tp => new { tp.TipoId, tp.PokemonId });

            // Pokemons
            modelbuilder.Entity<Tipos_Pokemons>()
                .HasOne(p => p.Pokemon)
                .WithMany(t => t.Tipos)
                .HasForeignKey(tp => tp.PokemonId);

            // Tipos
            modelbuilder.Entity<Tipos_Pokemons>()
                .HasOne(p => p.Tipo)
                .WithMany(t => t.Tipos)
                .HasForeignKey(tp => tp.TipoId);


            // DATA-SEED

            modelbuilder.Entity<Stat>().HasData(
               new Stat { Id = 1, Nivel = 20, Ataque = 15, Defensa = 10, Vida = 40 }
               );

            modelbuilder.Entity<Tipo>().HasData(
                new Tipo { Id = 1, Tipo_pokemon = "Fuego", Eficaz = "Planta", Debil = "Agua" },
                new Tipo { Id = 2, Tipo_pokemon = "Agua", Eficaz = "Fuego", Debil = "Planta" },
                new Tipo { Id = 3, Tipo_pokemon = "Planta", Eficaz = "Agua", Debil = "Fuego" },
                new Tipo { Id = 4, Tipo_pokemon = "Electrico", Eficaz = "Agua", Debil = "Dragon" },
                new Tipo { Id = 5, Tipo_pokemon = "Roca", Eficaz = "Fuego", Debil = "Acero" }
                );


            modelbuilder.Entity<Habilidades>().HasData(
                new Habilidades { HabilidadId = 1, Habilidad_1 = "Placaje", Habilidad_2 = "Ascuas", Habilidad_3 = "Llamarada", Habilidad_4 = "Gruñido"},
                new Habilidades { HabilidadId = 2, Habilidad_1 = "Placaje", Habilidad_2 = "Pistola Agua", Habilidad_3 = "Surf", Habilidad_4 = "Ataque arena"},
                new Habilidades { HabilidadId = 3, Habilidad_1 = "Placaje", Habilidad_2 = "Latigo cepa", Habilidad_3 = "Hoja afilada", Habilidad_4 = "Ataque arena"},
                new Habilidades { HabilidadId = 4, Habilidad_1 = "Placaje", Habilidad_2 = "Impactrueno", Habilidad_3 = "Rayo", Habilidad_4 = "Trueno"}
                );


            modelbuilder.Entity<Pokemon>().HasData(
                new Pokemon { Id = 1, Nombre = "Charmander", StatId = 1 },
                new Pokemon { Id = 2, Nombre = "Squirtle" },
                new Pokemon { Id = 3, Nombre = "Bulbasaur" },
                new Pokemon { Id = 4, Nombre = "Pikachu" },
                new Pokemon { Id = 5, Nombre = "Onix" }
                );

            modelbuilder.Entity<Entrenador>().HasData(
                new Entrenador { Id = 1, Nombre = "Marc" },
                new Entrenador { Id = 2, Nombre = "Dani" },
                new Entrenador { Id = 3, Nombre = "Ernest" }
               );


            // ASGINACION DE CADA POKEMON A SU TIPO
            modelbuilder.Entity<Tipos_Pokemons>().HasData(
                new Tipos_Pokemons { PokemonId = 1, TipoId = 1 },
                new Tipos_Pokemons { PokemonId = 2, TipoId = 2 },
                new Tipos_Pokemons { PokemonId = 3, TipoId = 3 },
                new Tipos_Pokemons { PokemonId = 4, TipoId = 4 },
                new Tipos_Pokemons { PokemonId = 5, TipoId = 5 }
                );


            // ASIGNACION DE CADA ENTRENADOR CON SU POKEMONS
            modelbuilder.Entity<Entrenadores_Pokemon>().HasData(
                new Entrenadores_Pokemon { EntrenadorId = 2, PokemonId = 4 },
                new Entrenadores_Pokemon { EntrenadorId = 1, PokemonId = 4 },
                new Entrenadores_Pokemon { EntrenadorId = 3, PokemonId = 5 }
                );

            modelbuilder.Entity<Tipos_Habilidades>().HasData(
                new Tipos_Habilidades { HabilidadId = 1, TipoId = 1 },
                new Tipos_Habilidades { HabilidadId = 2, TipoId = 2 },
                new Tipos_Habilidades { HabilidadId = 3, TipoId = 3 },
                new Tipos_Habilidades { HabilidadId = 4, TipoId = 4 }
                );




            base.OnModelCreating(modelbuilder);

        }

        // CONEXION A LA BASE DE DATOS, YA NO SE HACE EN EL PROGRAM.CS
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        var connect = @"Server=LOCALHOST;Database=db_pokemon_backend;Trusted_Connection=True";
        if (!optionsBuilder.IsConfigured)
       {
        optionsBuilder.UseSqlServer(connect, b => b.MigrationsAssembly("PokemonBackend"));
       }
}

    }
    /* PARA ACTUALIZAR LA TABLA. ADD-MIGRATION  (FECHA QUE SE EJECUTA). DESPUES UPDATE-DATABASE */
}