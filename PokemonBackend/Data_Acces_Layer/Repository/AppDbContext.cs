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
        public DbSet<Pokedex> Pokedex { get; set; }
        public DbSet<Pokemon> Pokemons { get; set; }
        public DbSet<Entrenador> Entrenadores { get; set; }
        public DbSet<Tipos_Pokemons> Tipo_Pokemons { get; set; }
        public DbSet<Tipo> Tipos { get; set; }
        public DbSet<TipoBonus> Bonuses { get; set; }
        public DbSet<ModificadorTipo> Modificadores { get; set; }
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

            /*

            modelbuilder.Entity<Pokedex>()
                .HasOne(s => s.Stat)
                .WithMany(p => p.Pokedex)
                .HasForeignKey(s=> s.StatId)
                .OnDelete(DeleteBehavior.Cascade);
           
            */

            // OneToOne Tipo Habilidades

            //TODO
           

            modelbuilder.Entity<Tipos_Habilidades>()
                .HasKey(th => new { th.TipoId, th.HabilidadId });

            modelbuilder.Entity<Tipos_Habilidades>()
                .HasOne(t => t.Tipo)
                .WithMany(h => h.Habilidades_tipos)
                .HasForeignKey(t => t.TipoId);

            modelbuilder.Entity<Tipos_Habilidades>()
                .HasOne(t => t.Habilidades)
                .WithMany(h => h.habilidades_tipos)
                .HasForeignKey(t => t.HabilidadId);
           
           
            // ManyToMany Pokemon Entrenador

            // ForeignKey
            modelbuilder.Entity<Entrenadores_Pokemon>()
                .HasKey(ep => new { ep.Id });

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
          

          
            // Pokemon Pokedex
            modelbuilder.Entity<Pokedex>()
                .HasMany(p => p.Pokemons)
                .WithOne(p => p.Pokedex);


            // ManyToMany Pokedex Tipos

            // ForeignKey
            modelbuilder.Entity<Tipos_Pokemons>()
                .HasKey(tp => new { tp.Id });

            // Pokemons
            modelbuilder.Entity<Tipos_Pokemons>()
                .HasOne(p => p.Pokedex)
                .WithMany(t => t.Tipos)
                .HasForeignKey(tp => tp.PokedexId);

            // Tipos
            modelbuilder.Entity<Tipos_Pokemons>()
                .HasOne(p => p.Tipo)
                .WithMany(t => t.Tipos)
                .HasForeignKey(tp => tp.TipoId);


            // Relacion Tipo y Bonus

        //   modelbuilder.Entity<Tipo>(e => e.HasIndex(t => t.Tipo_pokemon).IsUnique());
       
            modelbuilder.Entity<TipoBonus>().HasAlternateKey(x => new { x.EficazId, x.DebilidadId, x.IdTipo });
          

            modelbuilder.Entity<TipoBonus>()
            .HasOne(tp => tp.BonusDeb)
            .WithMany(tp => tp.Bonus)
            .HasForeignKey(tp => tp.DebilidadId)
            .OnDelete(DeleteBehavior.NoAction);

            modelbuilder.Entity<TipoBonus>()
            .HasOne(tp => tp.BonusEf)
            .WithMany(tp => tp.Bonuses)
            .HasForeignKey(tp => tp.EficazId)
            .OnDelete(DeleteBehavior.NoAction);

            modelbuilder.Entity<Tipo>()
             .HasMany(t => t.Debilidades)
             .WithOne(x => x.BonusDeb)
             .HasForeignKey(x => x.IdTipo);

            modelbuilder.Entity<Tipo>()
                .HasMany(t => t.Fortalezas)
                .WithOne(x => x.BonusEf)
                .HasForeignKey(x => x.IdTipo);
            

            // DATA-SEED //

            modelbuilder.Entity<Tipo>().HasData(
             new Tipo { Id = 1, Tipo_pokemon = "Fuego"},
             new Tipo { Id = 2, Tipo_pokemon = "Agua" },
             new Tipo { Id = 3, Tipo_pokemon = "Planta" },
             new Tipo { Id = 4, Tipo_pokemon = "Electrico" },
             new Tipo { Id = 5, Tipo_pokemon = "Roca" },
             new Tipo { Id = 6, Tipo_pokemon = "Acero" },
             new Tipo { Id = 7, Tipo_pokemon = "Volador" },
             new Tipo { Id = 8, Tipo_pokemon = "Hielo" },
             new Tipo { Id = 9, Tipo_pokemon = "Bicho" },
             new Tipo { Id = 10, Tipo_pokemon = "Normal" },
             new Tipo { Id = 11, Tipo_pokemon = "Tierra" },
             new Tipo { Id = 12, Tipo_pokemon = "Lucha" },
             new Tipo { Id = 13, Tipo_pokemon = "Hada" },
             new Tipo { Id = 14, Tipo_pokemon = "Psiquico" },
             new Tipo { Id = 16, Tipo_pokemon = "Dragón" },
             new Tipo { Id = 17, Tipo_pokemon = "Fantasma" },
             new Tipo { Id = 18, Tipo_pokemon = "Siniestro" },
             new Tipo { Id = 19, Tipo_pokemon = "Veneno" }
             );

            
            modelbuilder.Entity<TipoBonus>().HasData(
             new TipoBonus {Id = 1, IdTipo = 1, DebilidadId = 2, EficazId = 3},
             new TipoBonus {Id = 2, IdTipo = 2, DebilidadId = 4, EficazId = 1 },
             new TipoBonus {Id = 3, IdTipo = 2, DebilidadId = 8, EficazId = 11 }
             );
            
            modelbuilder.Entity<ModificadorTipo>().HasData(
            new ModificadorTipo { Id = 1, IdTipo = 1, Modificador = Modificador.Debilidad, TipoBonusId = 2 },
            new ModificadorTipo { Id = 2, IdTipo = 1, Modificador = Modificador.Fortaleza, TipoBonusId = 3 }
            );
            
           var url = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/";

            modelbuilder.Entity<Pokedex>().HasData(
              new Pokedex { ID = 1, Nombre = "Bulbasaur", Tier = 1, Basico = true},
              new Pokedex { ID = 2, Nombre = "Ivysaur", Tier = 2, Basico = false },
              new Pokedex { ID = 3, Nombre = "Venasaur", Tier = 3, Basico = false },
              new Pokedex { ID = 4, Nombre = "Charmander", Tier = 1, Basico = true },
              new Pokedex { ID = 5, Nombre = "Charmeleon", Tier = 2, Basico = false },
              new Pokedex { ID = 6, Nombre = "Charizard ", Tier = 3, Basico = false },
              new Pokedex { ID = 7, Nombre = "Squirtle", Tier = 1, Basico = true },
              new Pokedex { ID = 8, Nombre = "Wartotle" },
              new Pokedex { ID = 9, Nombre = "Blastoise" },
              new Pokedex { ID = 10, Nombre = "Caterpie" },
              new Pokedex { ID = 11, Nombre = "Metapod" },
              new Pokedex { ID = 12, Nombre = "Butterfree" },
              new Pokedex { ID = 13, Nombre = "Weedle" },
              new Pokedex { ID = 14, Nombre = "Kakuna" },
              new Pokedex { ID = 15, Nombre = "Beedril" },
              new Pokedex { ID = 16, Nombre = "Pidgey" },
              new Pokedex { ID = 17, Nombre = "Pidgeotto" },
              new Pokedex { ID = 18, Nombre = "Pidgeot" },
              new Pokedex { ID = 19, Nombre = "Rattata" },
              new Pokedex { ID = 20, Nombre = "Raticat" },
              new Pokedex { ID = 21, Nombre = "Spearow" },
              new Pokedex { ID = 22, Nombre = "Fearow" },
              new Pokedex { ID = 23, Nombre = "Ekans" },
              new Pokedex { ID = 24, Nombre = "Arbok" },
              new Pokedex { ID = 25, Nombre = "Pikachu" },
              new Pokedex { ID = 26, Nombre = "Raichu" },
              new Pokedex { ID = 27, Nombre = "Sandshrew" },
              new Pokedex { ID = 28, Nombre = "Sandslah" },
              new Pokedex { ID = 29, Nombre = "Nidoran ♀" },
              new Pokedex { ID = 30, Nombre = "Nidorina" },
              new Pokedex { ID = 31, Nombre = "Nidoqueen" },
              new Pokedex { ID = 32, Nombre = "Nidoran ♂" },
              new Pokedex { ID = 33, Nombre = "Nidorino" },
              new Pokedex { ID = 34, Nombre = "Nidoking" },
              new Pokedex { ID = 35, Nombre = "Clefairy" },
              new Pokedex { ID = 36, Nombre = "Clefable" },
              new Pokedex { ID = 37, Nombre = "Vulpix" },
              new Pokedex { ID = 38, Nombre = "Ninetales" },
              new Pokedex { ID = 39, Nombre = "Jigglypuff" },
              new Pokedex { ID = 40, Nombre = "Wigglytuff" },
              new Pokedex { ID = 41, Nombre = "Zubat" },
              new Pokedex { ID = 42, Nombre = "Golbat" },
              new Pokedex { ID = 43, Nombre = "Oddish" },
              new Pokedex { ID = 44, Nombre = "Gloom" },
              new Pokedex { ID = 45, Nombre = "Vileplume" },
              new Pokedex { ID = 46, Nombre = "Paras" },
              new Pokedex { ID = 47, Nombre = "Parasect" },
              new Pokedex { ID = 48, Nombre = "Venonat" },
              new Pokedex { ID = 49, Nombre = "Venomoth" },
              new Pokedex { ID = 50, Nombre = "Diglett" },
              new Pokedex { ID = 51, Nombre = "Dugtrio" },
              new Pokedex { ID = 52, Nombre = "Meowth" },
              new Pokedex { ID = 53, Nombre = "Persian" },
              new Pokedex { ID = 54, Nombre = "Psyduck" },
              new Pokedex { ID = 55, Nombre = "Golduck" },
              new Pokedex { ID = 56, Nombre = "Mankey" },
              new Pokedex { ID = 57, Nombre = "Primeape" },
              new Pokedex { ID = 58, Nombre = "Growlithe" },
              new Pokedex { ID = 59, Nombre = "Arcanine" },
              new Pokedex { ID = 60, Nombre = "Poliwag" },
              new Pokedex { ID = 61, Nombre = "Poliwhirl" },
              new Pokedex { ID = 62, Nombre = "Poliwrath" },
              new Pokedex { ID = 63, Nombre = "Abra" },
              new Pokedex { ID = 64, Nombre = "Kadabra" },
              new Pokedex { ID = 65, Nombre = "Alakazam" },
              new Pokedex { ID = 66, Nombre = "Machop" },
              new Pokedex { ID = 67, Nombre = "Machoke" },
              new Pokedex { ID = 68, Nombre = "Machamp" },
              new Pokedex { ID = 69, Nombre = "Bellsprout" },
              new Pokedex { ID = 70, Nombre = "Weepinbell" },
              new Pokedex { ID = 71, Nombre = "Victreebell" },
              new Pokedex { ID = 72, Nombre = "Tentacool" },
              new Pokedex { ID = 73, Nombre = "Tentacruel" },
              new Pokedex { ID = 74, Nombre = "Geodude" },
              new Pokedex { ID = 75, Nombre = "Graveler" },
              new Pokedex { ID = 76, Nombre = "Golem" },
              new Pokedex { ID = 77, Nombre = "Ponyta" },
              new Pokedex { ID = 78, Nombre = "Rapidash" },
              new Pokedex { ID = 79, Nombre = "Slowpoke" },
              new Pokedex { ID = 80, Nombre = "Slowbro" },
              new Pokedex { ID = 81, Nombre = "Magnemite" },
              new Pokedex { ID = 82, Nombre = "Magneton" },
              new Pokedex { ID = 83, Nombre = "Farfetch'd" },
              new Pokedex { ID = 84, Nombre = "Doduo" },
              new Pokedex { ID = 85, Nombre = "Dodrio" },
              new Pokedex { ID = 86, Nombre = "Seel" },
              new Pokedex { ID = 87, Nombre = "Dewgong" },
              new Pokedex { ID = 88, Nombre = "Grimer" },
              new Pokedex { ID = 89, Nombre = "Muk" },
              new Pokedex { ID = 90, Nombre = "Shellder" },
              new Pokedex { ID = 91, Nombre = "Cloyster" },
              new Pokedex { ID = 92, Nombre = "Gastly" },
              new Pokedex { ID = 93, Nombre = "Haunter" },
              new Pokedex { ID = 94, Nombre = "Gengar" },
              new Pokedex { ID = 95, Nombre = "Onix" },
              new Pokedex { ID = 96, Nombre = "Drowzee" },
              new Pokedex { ID = 97, Nombre = "Hypno" },
              new Pokedex { ID = 98, Nombre = "Krabby" },
              new Pokedex { ID = 99, Nombre = "Kingler" },
              new Pokedex { ID = 100, Nombre = "Voltorb" }
              );
           

            modelbuilder.Entity<Pokemon>().HasData(
                new Pokemon {  Id = 1, PokedexId = 1},
                new Pokemon {  Id = 2, PokedexId = 4 },
                new Pokemon {  Id = 3, PokedexId = 2 },
                new Pokemon {  Id = 4, PokedexId = 5 },
                new Pokemon {  Id = 5, PokedexId = 100 },
                new Pokemon {  Id = 6, PokedexId = 25 }
                );
           
           
            modelbuilder.Entity<Stat>().HasData(
               new Stat { Id = 1, Nivel = 20, Ataque = 15, Defensa = 10, Vida = 40 }
               );

            modelbuilder.Entity<Habilidades>().HasData(
                new Habilidades { HabilidadId = 1, Habilidad_1 = "Placaje", Habilidad_2 = "Ascuas", Habilidad_3 = "Llamarada", Habilidad_4 = "Gruñido" },
                new Habilidades { HabilidadId = 2, Habilidad_1 = "Placaje", Habilidad_2 = "Pistola Agua", Habilidad_3 = "Surf", Habilidad_4 = "Ataque arena" },
                new Habilidades { HabilidadId = 3, Habilidad_1 = "Placaje", Habilidad_2 = "Latigo cepa", Habilidad_3 = "Hoja afilada", Habilidad_4 = "Ataque arena" },
                new Habilidades { HabilidadId = 4, Habilidad_1 = "Placaje", Habilidad_2 = "Impactrueno", Habilidad_3 = "Rayo", Habilidad_4 = "Trueno" }
                );

            modelbuilder.Entity<Entrenador>().HasData(
                new Entrenador { Id = 1, Nombre = "Marc" },
                new Entrenador { Id = 2, Nombre = "Dani" },
                new Entrenador { Id = 3, Nombre = "Ernest" }
               );
            

            // ASIGNACION DE CADA ENTRENADOR CON SU POKEMONS
            // PokemonId está relacionado con el Id y no con el PokedexId
            modelbuilder.Entity<Entrenadores_Pokemon>().HasData(
                new Entrenadores_Pokemon {Id = 1,  EntrenadorId = 1, PokemonId = 5},
                new Entrenadores_Pokemon {Id = 2,  EntrenadorId = 2, PokemonId = 6},
                new Entrenadores_Pokemon {Id = 3,  EntrenadorId = 2, PokemonId = 6}
                );
            

            
            // ASGINACION DE CADA POKEMON de la pokedex A SU TIPO
            modelbuilder.Entity<Tipos_Pokemons>().HasData(
                new Tipos_Pokemons {Id = 1, PokedexId = 1, TipoId = 3 },
                new Tipos_Pokemons {Id = 2, PokedexId = 1, TipoId = 19 }
                );
            
            modelbuilder.Entity<Tipos_Habilidades>().HasData(
                new Tipos_Habilidades {Id = 1, HabilidadId = 1, TipoId = 1 },
                new Tipos_Habilidades {Id = 2, HabilidadId = 2, TipoId = 2 },
                new Tipos_Habilidades {Id = 3, HabilidadId = 3, TipoId = 3 },
                new Tipos_Habilidades {Id = 4, HabilidadId = 4, TipoId = 4 },
                new Tipos_Habilidades {Id = 5, HabilidadId = 3, TipoId = 4 }
                );
            
            base.OnModelCreating(modelbuilder);
        }

        // CONEXION A LA BASE DE DATOS, YA NO SE HACE EN EL PROGRAM.CS
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connect = @"Server=LOCALHOST;Database=db_pokemon_backend;Trusted_Connection=True";
            optionsBuilder.EnableSensitiveDataLogging();
          
           
        if (!optionsBuilder.IsConfigured)
       {
        optionsBuilder.UseSqlServer(connect, b => b.MigrationsAssembly("PokemonBackend"));
       }
            
        }

    }
    /* PARA ACTUALIZAR LA TABLA. ADD-MIGRATION  (FECHA QUE SE EJECUTA). DESPUES UPDATE-DATABASE */
}