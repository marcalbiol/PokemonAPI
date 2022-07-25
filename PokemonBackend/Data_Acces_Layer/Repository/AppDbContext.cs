using Acceso_BD.Repository.Entity;
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

           
            modelbuilder.Entity<Pokemon>().HasData(
                    
               new Pokemon { Id = 1, Nombre = "Bulbasaur", PokemonID = "#001"},
               new Pokemon { Id = 2, Nombre = "Ivysaur", PokemonID = "#002"},
               new Pokemon { Id = 3, Nombre = "Venasaur", PokemonID = "#003"},
               new Pokemon { Id = 4, Nombre = "Charmander", PokemonID = "#004"},
               new Pokemon { Id = 5, Nombre = "Charmeleon", PokemonID = "#005"},
               new Pokemon { Id = 6, Nombre = "Charizard", PokemonID = "#006"},
               new Pokemon { Id = 7, Nombre = "Squirtle", PokemonID = "#007"},
               new Pokemon { Id = 8, Nombre = "Wartotle", PokemonID = "#008"},
               new Pokemon { Id = 9, Nombre = "Blastoise", PokemonID = "#009"},
               new Pokemon { Id = 10, Nombre = "Caterpie", PokemonID = "#010"},
               new Pokemon { Id = 11, Nombre = "Metapod", PokemonID = "#011"},
               new Pokemon { Id = 12, Nombre = "Butterfree", PokemonID = "#012"},
               new Pokemon { Id = 13, Nombre = "Weedle", PokemonID = "#013"},
               new Pokemon { Id = 14, Nombre = "Kakuna", PokemonID = "#014"},
               new Pokemon { Id = 15, Nombre = "Beedrill", PokemonID = "#015"},
               new Pokemon { Id = 16, Nombre = "Pidgey", PokemonID = "#016"},
               new Pokemon { Id = 17, Nombre = "Rattata", PokemonID = "#017"},
               new Pokemon { Id = 18, Nombre = "Raticate", PokemonID = "#018"},
               new Pokemon { Id = 19, Nombre = "Spearow", PokemonID = "#019"},
               new Pokemon { Id = 20, Nombre = "Fearow", PokemonID = "#020"},
               new Pokemon { Id = 21, Nombre = "Ekans", PokemonID = "#021"},
               new Pokemon { Id = 22, Nombre = "Pikachu", PokemonID = "#022"},
               new Pokemon { Id = 23, Nombre = "Raichu", PokemonID = "#023"},
               new Pokemon { Id = 24, Nombre = "Sandshrew", PokemonID = "#024"},
               new Pokemon { Id = 25, Nombre = "Sandslash", PokemonID = "#025"},
               new Pokemon { Id = 26, Nombre = "Nidoran ♀", PokemonID = "#026"},
               new Pokemon { Id = 27, Nombre = "Nidorina", PokemonID = "#027"},
               new Pokemon { Id = 28, Nombre = "Nidoqueen", PokemonID = "#028"},
               new Pokemon { Id = 29, Nombre = "Nidoran ♂", PokemonID = "#029"},
               new Pokemon { Id = 30, Nombre = "Nidorino", PokemonID = "#030"},
               new Pokemon { Id = 31, Nombre = "Nidoking", PokemonID = "#031"},
               new Pokemon { Id = 32, Nombre = "Clefairy", PokemonID = "#032"},
               new Pokemon { Id = 33, Nombre = "Clefable", PokemonID = "#033"},
               new Pokemon { Id = 34, Nombre = "Vulpix", PokemonID = "#034"},
               new Pokemon { Id = 35, Nombre = "Ninetales", PokemonID = "#035"},
               new Pokemon { Id = 36, Nombre = "Jigglypuff", PokemonID = "#036"},
               new Pokemon { Id = 37, Nombre = "Wigglytuff", PokemonID = "#037"}
               );
            

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