﻿// <auto-generated />
using System;
using Data_Acces_Layer.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace PokemonBackend.Migrations
{
    [DbContext(typeof(MyDbContext))]
    [Migration("20220722095510_TablasHabilidadesCambiadas")]
    partial class TablasHabilidadesCambiadas
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("PokemonBackend.Models.Entrenador", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("Id"), 1L, 1);

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Entrenadores");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nombre = "Marc"
                        },
                        new
                        {
                            Id = 2,
                            Nombre = "Dani"
                        },
                        new
                        {
                            Id = 3,
                            Nombre = "Ernest"
                        });
                });

            modelBuilder.Entity("PokemonBackend.Models.Entrenadores_Pokemon", b =>
                {
                    b.Property<int>("EntrenadorId")
                        .HasColumnType("int");

                    b.Property<int>("PokemonId")
                        .HasColumnType("int");

                    b.HasKey("EntrenadorId", "PokemonId");

                    b.HasIndex("PokemonId");

                    b.ToTable("Entrenadores_Pokemons");

                    b.HasData(
                        new
                        {
                            EntrenadorId = 2,
                            PokemonId = 4
                        },
                        new
                        {
                            EntrenadorId = 1,
                            PokemonId = 4
                        },
                        new
                        {
                            EntrenadorId = 3,
                            PokemonId = 5
                        });
                });

            modelBuilder.Entity("PokemonBackend.Models.Habilidades", b =>
                {
                    b.Property<int>("HabilidadId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("HabilidadId"), 1L, 1);

                    b.Property<string>("Habilidad_1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Habilidad_2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Habilidad_3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Habilidad_4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TipoId")
                        .HasColumnType("int");

                    b.HasKey("HabilidadId");

                    b.HasIndex("TipoId")
                        .IsUnique();

                    b.ToTable("Habilidades");
                });

            modelBuilder.Entity("PokemonBackend.Models.Pokemon", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("Id"), 1L, 1);

                    b.Property<int?>("EntrenadorId")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("Shiny")
                        .HasColumnType("bit");

                    b.Property<int?>("StatId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EntrenadorId");

                    b.HasIndex("StatId");

                    b.ToTable("Pokemons");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nombre = "Charmander",
                            StatId = 1
                        },
                        new
                        {
                            Id = 2,
                            Nombre = "Squirtle"
                        },
                        new
                        {
                            Id = 3,
                            Nombre = "Bulbasaur"
                        },
                        new
                        {
                            Id = 4,
                            Nombre = "Pikachu"
                        },
                        new
                        {
                            Id = 5,
                            Nombre = "Onix"
                        });
                });

            modelBuilder.Entity("PokemonBackend.Models.Stat", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("Ataque")
                        .HasColumnType("int");

                    b.Property<int?>("Defensa")
                        .HasColumnType("int");

                    b.Property<int?>("Nivel")
                        .HasColumnType("int");

                    b.Property<int?>("Vida")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Stats");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Ataque = 15,
                            Defensa = 10,
                            Nivel = 20,
                            Vida = 40
                        });
                });

            modelBuilder.Entity("PokemonBackend.Models.Tipo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Debil")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Eficaz")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tipo_pokemon")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Tipos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Debil = "Agua",
                            Eficaz = "Planta",
                            Tipo_pokemon = "Fuego"
                        },
                        new
                        {
                            Id = 2,
                            Debil = "Planta",
                            Eficaz = "Fuego",
                            Tipo_pokemon = "Agua"
                        },
                        new
                        {
                            Id = 3,
                            Debil = "Fuego",
                            Eficaz = "Agua",
                            Tipo_pokemon = "Planta"
                        },
                        new
                        {
                            Id = 4,
                            Debil = "Dragon",
                            Eficaz = "Agua",
                            Tipo_pokemon = "Electrico"
                        },
                        new
                        {
                            Id = 5,
                            Debil = "Acero",
                            Eficaz = "Fuego",
                            Tipo_pokemon = "Roca"
                        });
                });

            modelBuilder.Entity("PokemonBackend.Models.Tipos_Pokemons", b =>
                {
                    b.Property<int>("TipoId")
                        .HasColumnType("int");

                    b.Property<int>("PokemonId")
                        .HasColumnType("int");

                    b.HasKey("TipoId", "PokemonId");

                    b.HasIndex("PokemonId");

                    b.ToTable("Tipo_Pokemons");

                    b.HasData(
                        new
                        {
                            TipoId = 1,
                            PokemonId = 1
                        },
                        new
                        {
                            TipoId = 2,
                            PokemonId = 2
                        },
                        new
                        {
                            TipoId = 3,
                            PokemonId = 3
                        },
                        new
                        {
                            TipoId = 4,
                            PokemonId = 4
                        },
                        new
                        {
                            TipoId = 5,
                            PokemonId = 5
                        });
                });

            modelBuilder.Entity("PokemonBackend.Models.Entrenadores_Pokemon", b =>
                {
                    b.HasOne("PokemonBackend.Models.Entrenador", "Entrenador")
                        .WithMany("Entrenador_Pokemons")
                        .HasForeignKey("EntrenadorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PokemonBackend.Models.Pokemon", "Pokemon")
                        .WithMany("Entrenador_Pokemons")
                        .HasForeignKey("PokemonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Entrenador");

                    b.Navigation("Pokemon");
                });

            modelBuilder.Entity("PokemonBackend.Models.Habilidades", b =>
                {
                    b.HasOne("PokemonBackend.Models.Tipo", "Tipo")
                        .WithOne("Habilidades")
                        .HasForeignKey("PokemonBackend.Models.Habilidades", "TipoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Tipo");
                });

            modelBuilder.Entity("PokemonBackend.Models.Pokemon", b =>
                {
                    b.HasOne("PokemonBackend.Models.Entrenador", null)
                        .WithMany("Pokemons")
                        .HasForeignKey("EntrenadorId");

                    b.HasOne("PokemonBackend.Models.Stat", "Stat")
                        .WithMany("Pokemons")
                        .HasForeignKey("StatId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("Stat");
                });

            modelBuilder.Entity("PokemonBackend.Models.Tipos_Pokemons", b =>
                {
                    b.HasOne("PokemonBackend.Models.Pokemon", "Pokemon")
                        .WithMany("Tipos")
                        .HasForeignKey("PokemonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PokemonBackend.Models.Tipo", "Tipo")
                        .WithMany("Tipos")
                        .HasForeignKey("TipoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pokemon");

                    b.Navigation("Tipo");
                });

            modelBuilder.Entity("PokemonBackend.Models.Entrenador", b =>
                {
                    b.Navigation("Entrenador_Pokemons");

                    b.Navigation("Pokemons");
                });

            modelBuilder.Entity("PokemonBackend.Models.Pokemon", b =>
                {
                    b.Navigation("Entrenador_Pokemons");

                    b.Navigation("Tipos");
                });

            modelBuilder.Entity("PokemonBackend.Models.Stat", b =>
                {
                    b.Navigation("Pokemons");
                });

            modelBuilder.Entity("PokemonBackend.Models.Tipo", b =>
                {
                    b.Navigation("Habilidades");

                    b.Navigation("Tipos");
                });
#pragma warning restore 612, 618
        }
    }
}
