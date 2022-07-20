﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PokemonBackend.Models;

#nullable disable

namespace PokemonBackend.Migrations
{
    [DbContext(typeof(MyDbContext))]
    [Migration("20220720085406_DataSeed_0.3")]
    partial class DataSeed_03
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
                });

            modelBuilder.Entity("PokemonBackend.Models.Pokemon", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("Id"), 1L, 1);

                    b.Property<int?>("Ataque")
                        .HasColumnType("int");

                    b.Property<int?>("Defensa")
                        .HasColumnType("int");

                    b.Property<int?>("EntrenadorId")
                        .HasColumnType("int");

                    b.Property<int?>("Nivel")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Vida")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EntrenadorId");

                    b.ToTable("Pokemons");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nombre = "Charmander"
                        });
                });

            modelBuilder.Entity("PokemonBackend.Models.Tipo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Desventaja")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tipo_pokemon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ventaja")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Tipos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Desventaja = "Agua",
                            Tipo_pokemon = "Fuego",
                            Ventaja = "Planta"
                        },
                        new
                        {
                            Id = 2,
                            Desventaja = "Planta",
                            Tipo_pokemon = "Agua",
                            Ventaja = "Fuego"
                        },
                        new
                        {
                            Id = 3,
                            Desventaja = "Fuego",
                            Tipo_pokemon = "Planta",
                            Ventaja = "Agua"
                        });
                });

            modelBuilder.Entity("PokemonBackend.Models.Tipo_Pokemons", b =>
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
                        });
                });

            modelBuilder.Entity("PokemonBackend.Models.Pokemon", b =>
                {
                    b.HasOne("PokemonBackend.Models.Entrenador", "Entrenador")
                        .WithMany("Pokemons")
                        .HasForeignKey("EntrenadorId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.Navigation("Entrenador");
                });

            modelBuilder.Entity("PokemonBackend.Models.Tipo_Pokemons", b =>
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
                    b.Navigation("Pokemons");
                });

            modelBuilder.Entity("PokemonBackend.Models.Pokemon", b =>
                {
                    b.Navigation("Tipos");
                });

            modelBuilder.Entity("PokemonBackend.Models.Tipo", b =>
                {
                    b.Navigation("Tipos");
                });
#pragma warning restore 612, 618
        }
    }
}
