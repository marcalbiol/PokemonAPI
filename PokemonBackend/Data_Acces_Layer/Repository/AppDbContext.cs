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
        public DbSet<Tipos_Habilidades> Tipos_Habilidades{ get; set; }
        public DbSet<Tipo> Tipos { get; set; }
        public DbSet<TipoBonus> Bonuses { get; set; }
        public DbSet<ModificadorTipo> Modificadores { get; set; }
        public DbSet<Entrenadores_Pokemon> Entrenadores_Pokemons { get; set; }
        public DbSet<Stat> Stats { get; set; }
        public DbSet<Habilidades> Habilidades { get; set; }
        public DbSet<Region> Regiones { get; set; }
        public DbSet<Zona> Zonas { get; set; }




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

            modelbuilder.Entity<Pokedex>()
                 .HasOne(r => r.Region)
                 .WithMany(r => r.Pokedex)
                 .HasForeignKey(r => r.RegionId);

            modelbuilder.Entity<Pokedex>()
                .HasOne(r => r.Zona)
                .WithMany(r => r.PokeZona)
                .HasForeignKey(r => r.ZonaId);

            // Pokemon Pokedex
            modelbuilder.Entity<Pokedex>()
                .HasMany(p => p.Pokemons)
                .WithOne(p => p.Pokedex);

            // OneToOne Tipo Habilidades
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

            modelbuilder.Entity<Zona>().HasData(
                new Zona {Id = 1, NombreZona = "Inicio"},
                new Zona {Id = 2, NombreZona = "Inicio2"}
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

            // Regiones
            modelbuilder.Entity<Region>().HasData(
                new Region { Id = 1, Nombre = "Kanto" },
                new Region { Id = 2, Nombre = "Johto" },
                new Region { Id = 3, Nombre = "Hoenn" }
                );
    
            var url = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/";

            modelbuilder.Entity<Pokedex>().HasData(
              new Pokedex { ID = 1, Nombre = "Bulbasaur", Tier = 1, Basico = true, RegionId = 1},
              new Pokedex { ID = 2, Nombre = "Ivysaur", Tier = 2, Basico = false, RegionId = 1 },
              new Pokedex { ID = 3, Nombre = "Venasaur", Tier = 3, Basico = false, RegionId = 2 },
              new Pokedex { ID = 4, Nombre = "Charmander", Tier = 1, Basico = true },
              new Pokedex { ID = 5, Nombre = "Charmeleon", Tier = 2, Basico = false },
              new Pokedex { ID = 6, Nombre = "Charizard ", Tier = 3, Basico = false },
              new Pokedex { ID = 7, Nombre = "Squirtle", Tier = 1, Basico = true },
              new Pokedex { ID = 8, Nombre = "Wartotle" },
              new Pokedex { ID = 9, Nombre = "Blastoise" },
              new Pokedex { ID = 10, Nombre = "Caterpie", ZonaId = 1},
              new Pokedex { ID = 11, Nombre = "Metapod" },
              new Pokedex { ID = 12, Nombre = "Butterfree" },
              new Pokedex { ID = 13, Nombre = "Weedle", ZonaId = 2},
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
              new Pokedex { ID = 100, Nombre = "Voltorb" },
              new Pokedex { ID = 101, Nombre = "Electrode" },
              new Pokedex { ID = 102, Nombre = "Exeggcute" },
              new Pokedex { ID = 103, Nombre = "Exeggutor" },
              new Pokedex { ID = 104, Nombre = "Cubone" },
              new Pokedex { ID = 105, Nombre = "Marowak" },
              new Pokedex { ID = 106, Nombre = "Hitmonlee" },
              new Pokedex { ID = 107, Nombre = "Hitmonchan" },
              new Pokedex { ID = 108, Nombre = "Lickitung" },
              new Pokedex { ID = 109, Nombre = "Koffing" },
              new Pokedex { ID = 110, Nombre = "Weezing" },
              new Pokedex { ID = 111, Nombre = "Rhyhorn" },
              new Pokedex { ID = 112, Nombre = "Rhydon" },
              new Pokedex { ID = 113, Nombre = "Chansey" },
              new Pokedex { ID = 114, Nombre = "Tangela" },
              new Pokedex { ID = 115, Nombre = "Kangskhan" },
              new Pokedex { ID = 116, Nombre = "Horsea" },
              new Pokedex { ID = 117, Nombre = "Seadra" },
              new Pokedex { ID = 118, Nombre = "Goldeen" },
              new Pokedex { ID = 119, Nombre = "Seaking" },
              new Pokedex { ID = 120, Nombre = "Staryu" },
              new Pokedex { ID = 121, Nombre = "Starmie" },
              new Pokedex { ID = 122, Nombre = "Mr.Mime" },
              new Pokedex { ID = 123, Nombre = "Scyher" },
              new Pokedex { ID = 124, Nombre = "Jynx" },
              new Pokedex { ID = 125, Nombre = "Electabuzz" },
              new Pokedex { ID = 126, Nombre = "Magmar" },
              new Pokedex { ID = 127, Nombre = "Pinsir" },
              new Pokedex { ID = 128, Nombre = "Tauros" },
              new Pokedex { ID = 129, Nombre = "Magikarp" },
              new Pokedex { ID = 130, Nombre = "Gyarados" },
              new Pokedex { ID = 131, Nombre = "Lapras" },
              new Pokedex { ID = 132, Nombre = "Ditto" },
              new Pokedex { ID = 133, Nombre = "Eevee" },
              new Pokedex { ID = 134, Nombre = "Vaporeon" },
              new Pokedex { ID = 135, Nombre = "Jolteon" },
              new Pokedex { ID = 136, Nombre = "Flareon" },
              new Pokedex { ID = 137, Nombre = "Porygon" },
              new Pokedex { ID = 138, Nombre = "Omanyte" },
              new Pokedex { ID = 139, Nombre = "Omastar" },
              new Pokedex { ID = 140, Nombre = "Kabuto" },
              new Pokedex { ID = 141, Nombre = "Kabutops" },
              new Pokedex { ID = 142, Nombre = "Aerodactyl" },
              new Pokedex { ID = 143, Nombre = "Snorlax" },
              new Pokedex { ID = 144, Nombre = "Articuno" },
              new Pokedex { ID = 145, Nombre = "Zapdos" },
              new Pokedex { ID = 146, Nombre = "Moltres" },
              new Pokedex { ID = 147, Nombre = "Dratini" },
              new Pokedex { ID = 148, Nombre = "Dragonair" },
              new Pokedex { ID = 149, Nombre = "Dragonite" },
              new Pokedex { ID = 150, Nombre = "Mewtwo" },
              new Pokedex { ID = 151, Nombre = "Mew" }
            
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
                new Entrenador { Id = 3, Nombre = "Ernest" },
                new Entrenador { Id = 4, Nombre = "Nicol" },
                new Entrenador { Id = 5, Nombre = "Jose" }
               );
            

            // ASIGNACION DE CADA ENTRENADOR CON SU POKEMONS

            // ****************PokemonId está relacionado con el Id y no con el PokedexId******** //
            modelbuilder.Entity<Entrenadores_Pokemon>().HasData(
                new Entrenadores_Pokemon {Id = 1,  EntrenadorId = 1, PokemonId = 5},
                new Entrenadores_Pokemon {Id = 2,  EntrenadorId = 2, PokemonId = 6},
                new Entrenadores_Pokemon {Id = 3,  EntrenadorId = 2, PokemonId = 6}
                );
            
            // ASGINACION DE CADA POKEMON de la pokedex A SU TIPO
            modelbuilder.Entity<Tipos_Pokemons>().HasData(
                new Tipos_Pokemons {Id = 1, PokedexId = 1, TipoId = 3 },
                new Tipos_Pokemons {Id = 2, PokedexId = 1, TipoId = 19},
                new Tipos_Pokemons {Id = 3, PokedexId = 2, TipoId = 3},
                new Tipos_Pokemons {Id = 4, PokedexId = 2, TipoId = 19},
                new Tipos_Pokemons {Id = 5, PokedexId = 3, TipoId = 3},
                new Tipos_Pokemons {Id = 6, PokedexId = 3, TipoId = 19},
                new Tipos_Pokemons {Id = 7, PokedexId = 4, TipoId = 1},
                new Tipos_Pokemons {Id = 8, PokedexId = 5, TipoId = 1},
                new Tipos_Pokemons {Id = 9, PokedexId = 6, TipoId = 1},
                new Tipos_Pokemons {Id = 10, PokedexId = 6, TipoId = 7},
                new Tipos_Pokemons {Id = 11, PokedexId = 7, TipoId = 2},
                new Tipos_Pokemons {Id = 12, PokedexId = 8, TipoId = 2},
                new Tipos_Pokemons {Id = 13, PokedexId = 9, TipoId = 2},
                new Tipos_Pokemons {Id = 14, PokedexId = 10, TipoId = 9},
                new Tipos_Pokemons {Id = 15, PokedexId = 11, TipoId = 9},
                new Tipos_Pokemons {Id = 16, PokedexId = 12, TipoId = 9},
                new Tipos_Pokemons {Id = 17, PokedexId = 12, TipoId = 7},
                new Tipos_Pokemons {Id = 18, PokedexId = 13, TipoId = 7},
                new Tipos_Pokemons {Id = 19, PokedexId = 13, TipoId = 19},
                new Tipos_Pokemons {Id = 20, PokedexId = 14, TipoId = 7},
                new Tipos_Pokemons {Id = 21, PokedexId = 14, TipoId = 19},
                new Tipos_Pokemons {Id = 22, PokedexId = 15, TipoId = 7},
                new Tipos_Pokemons {Id = 23, PokedexId = 15, TipoId = 19},
                new Tipos_Pokemons {Id = 24, PokedexId = 16, TipoId = 7},
                new Tipos_Pokemons {Id = 25, PokedexId = 16, TipoId = 10},
                new Tipos_Pokemons {Id = 26, PokedexId = 17, TipoId = 7},
                new Tipos_Pokemons {Id = 27, PokedexId = 17, TipoId = 10},
                new Tipos_Pokemons {Id = 28, PokedexId = 18, TipoId = 7},
                new Tipos_Pokemons {Id = 29, PokedexId = 18, TipoId = 10},
                new Tipos_Pokemons {Id = 30, PokedexId = 19, TipoId = 10},
                new Tipos_Pokemons {Id = 31, PokedexId = 20, TipoId = 10},
                new Tipos_Pokemons {Id = 32, PokedexId = 21, TipoId = 10},
                new Tipos_Pokemons {Id = 33, PokedexId = 21, TipoId = 7},
                new Tipos_Pokemons {Id = 34, PokedexId = 22, TipoId = 7},
                new Tipos_Pokemons {Id = 35, PokedexId = 22, TipoId = 10},
                new Tipos_Pokemons {Id = 36, PokedexId = 23, TipoId = 19},
                new Tipos_Pokemons {Id = 37, PokedexId = 24, TipoId = 19},
                new Tipos_Pokemons {Id = 38, PokedexId = 25, TipoId = 4},
                new Tipos_Pokemons {Id = 39, PokedexId = 26, TipoId = 4},
                new Tipos_Pokemons {Id = 40, PokedexId = 27, TipoId = 11},
                new Tipos_Pokemons {Id = 41, PokedexId = 28, TipoId = 11},
                new Tipos_Pokemons {Id = 42, PokedexId = 29, TipoId = 19},
                new Tipos_Pokemons {Id = 43, PokedexId = 30, TipoId = 19},
                new Tipos_Pokemons {Id = 44, PokedexId = 31, TipoId = 19},
                new Tipos_Pokemons {Id = 45, PokedexId = 31, TipoId = 11},
                new Tipos_Pokemons {Id = 46, PokedexId = 32, TipoId = 19},
                new Tipos_Pokemons {Id = 47, PokedexId = 33, TipoId = 19},
                new Tipos_Pokemons {Id = 48, PokedexId = 34, TipoId = 19},
                new Tipos_Pokemons {Id = 49, PokedexId = 34, TipoId = 11},
                new Tipos_Pokemons {Id = 50, PokedexId = 35, TipoId = 13},
                new Tipos_Pokemons {Id = 51, PokedexId = 36, TipoId = 13},
                new Tipos_Pokemons {Id = 52, PokedexId = 37, TipoId = 1},
                new Tipos_Pokemons {Id = 53, PokedexId = 38, TipoId = 1}
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
            var connect = @"Server=LOCALHOST;Database=db_poke_backend;Trusted_Connection=True";
            optionsBuilder
                .EnableSensitiveDataLogging()
                .UseLazyLoadingProxies();
            if (!optionsBuilder.IsConfigured)
       {
        optionsBuilder.UseSqlServer(connect, b => b.MigrationsAssembly("Acceso_BD"));
       }
            
        }
    }
    /* PARA ACTUALIZAR LA TABLA. ADD-MIGRATION  (FECHA QUE SE EJECUTA). DESPUES UPDATE-DATABASE */
}