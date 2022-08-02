using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Acceso_BD.Migrations
{
    public partial class Estable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Entrenador",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entrenador", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Habilidades",
                columns: table => new
                {
                    HabilidadId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Habilidad_1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Habilidad_2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Habilidad_3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Habilidad_4 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Habilidades", x => x.HabilidadId);
                });

            migrationBuilder.CreateTable(
                name: "Stat",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nivel = table.Column<int>(type: "int", nullable: true),
                    Ataque = table.Column<int>(type: "int", nullable: true),
                    Defensa = table.Column<int>(type: "int", nullable: true),
                    Vida = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stat", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tipo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tipo_pokemon = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tipo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pokedex",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Imagen = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Altura = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Peso = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tier = table.Column<int>(type: "int", maxLength: 3, nullable: true),
                    Basico = table.Column<bool>(type: "bit", nullable: true),
                    StatId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pokedex", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Pokedex_Stat_StatId",
                        column: x => x.StatId,
                        principalTable: "Stat",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Debilidades",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdTipo = table.Column<int>(type: "int", nullable: false),
                    DebilidadId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Debilidades", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Debilidades_Tipo_IdTipo",
                        column: x => x.IdTipo,
                        principalTable: "Tipo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Fortalezas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdTipo = table.Column<int>(type: "int", nullable: false),
                    EficazId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fortalezas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Fortalezas_Tipo_IdTipo",
                        column: x => x.IdTipo,
                        principalTable: "Tipo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ModificadorTipo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdTipo = table.Column<int>(type: "int", nullable: false),
                    Modificador = table.Column<int>(type: "int", nullable: false),
                    BonusId = table.Column<int>(type: "int", nullable: true),
                    TipoBonusId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModificadorTipo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ModificadorTipo_Tipo_BonusId",
                        column: x => x.BonusId,
                        principalTable: "Tipo",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TipoBonus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdTipo = table.Column<int>(type: "int", nullable: false),
                    EficazId = table.Column<int>(type: "int", nullable: false),
                    DebilidadId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoBonus", x => x.Id);
                    table.UniqueConstraint("AK_TipoBonus_EficazId_DebilidadId_IdTipo", x => new { x.EficazId, x.DebilidadId, x.IdTipo });
                    table.ForeignKey(
                        name: "FK_TipoBonus_Tipo_DebilidadId",
                        column: x => x.DebilidadId,
                        principalTable: "Tipo",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TipoBonus_Tipo_EficazId",
                        column: x => x.EficazId,
                        principalTable: "Tipo",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Tipos_Habilidades",
                columns: table => new
                {
                    HabilidadId = table.Column<int>(type: "int", nullable: false),
                    TipoId = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tipos_Habilidades", x => new { x.TipoId, x.HabilidadId });
                    table.ForeignKey(
                        name: "FK_Tipos_Habilidades_Habilidades_HabilidadId",
                        column: x => x.HabilidadId,
                        principalTable: "Habilidades",
                        principalColumn: "HabilidadId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tipos_Habilidades_Tipo_TipoId",
                        column: x => x.TipoId,
                        principalTable: "Tipo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Pokemon",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Shiny = table.Column<bool>(type: "bit", nullable: true),
                    Nivel = table.Column<int>(type: "int", nullable: false),
                    PokedexId = table.Column<int>(type: "int", nullable: true),
                    StatId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pokemon", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pokemon_Pokedex_PokedexId",
                        column: x => x.PokedexId,
                        principalTable: "Pokedex",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Pokemon_Stat_StatId",
                        column: x => x.StatId,
                        principalTable: "Stat",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Entrenadores_Pokemon",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EntrenadorId = table.Column<int>(type: "int", nullable: true),
                    PokemonId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entrenadores_Pokemon", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Entrenadores_Pokemon_Entrenador_EntrenadorId",
                        column: x => x.EntrenadorId,
                        principalTable: "Entrenador",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Entrenadores_Pokemon_Pokemon_PokemonId",
                        column: x => x.PokemonId,
                        principalTable: "Pokemon",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Tipos_Pokemons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipoId = table.Column<int>(type: "int", nullable: false),
                    PokedexId = table.Column<int>(type: "int", nullable: true),
                    PokemonId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tipos_Pokemons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tipos_Pokemons_Pokedex_PokedexId",
                        column: x => x.PokedexId,
                        principalTable: "Pokedex",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Tipos_Pokemons_Pokemon_PokemonId",
                        column: x => x.PokemonId,
                        principalTable: "Pokemon",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Tipos_Pokemons_Tipo_TipoId",
                        column: x => x.TipoId,
                        principalTable: "Tipo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Entrenador",
                columns: new[] { "Id", "Nombre" },
                values: new object[,]
                {
                    { 1, "Marc" },
                    { 2, "Dani" },
                    { 3, "Ernest" }
                });

            migrationBuilder.InsertData(
                table: "Habilidades",
                columns: new[] { "HabilidadId", "Habilidad_1", "Habilidad_2", "Habilidad_3", "Habilidad_4" },
                values: new object[,]
                {
                    { 1, "Placaje", "Ascuas", "Llamarada", "Gruñido" },
                    { 2, "Placaje", "Pistola Agua", "Surf", "Ataque arena" },
                    { 3, "Placaje", "Latigo cepa", "Hoja afilada", "Ataque arena" },
                    { 4, "Placaje", "Impactrueno", "Rayo", "Trueno" }
                });

            migrationBuilder.InsertData(
                table: "ModificadorTipo",
                columns: new[] { "Id", "BonusId", "IdTipo", "Modificador", "TipoBonusId" },
                values: new object[,]
                {
                    { 1, null, 1, 1, 2 },
                    { 2, null, 1, 0, 3 }
                });

            migrationBuilder.InsertData(
                table: "Pokedex",
                columns: new[] { "ID", "Altura", "Basico", "Imagen", "Nombre", "Peso", "StatId", "Tier" },
                values: new object[,]
                {
                    { 1, null, true, null, "Bulbasaur", null, null, 1 },
                    { 2, null, false, null, "Ivysaur", null, null, 2 },
                    { 3, null, false, null, "Venasaur", null, null, 3 },
                    { 4, null, true, null, "Charmander", null, null, 1 },
                    { 5, null, false, null, "Charmeleon", null, null, 2 },
                    { 6, null, false, null, "Charizard ", null, null, 3 },
                    { 7, null, true, null, "Squirtle", null, null, 1 },
                    { 8, null, null, null, "Wartotle", null, null, null },
                    { 9, null, null, null, "Blastoise", null, null, null },
                    { 10, null, null, null, "Caterpie", null, null, null },
                    { 11, null, null, null, "Metapod", null, null, null },
                    { 12, null, null, null, "Butterfree", null, null, null },
                    { 13, null, null, null, "Weedle", null, null, null },
                    { 14, null, null, null, "Kakuna", null, null, null },
                    { 15, null, null, null, "Beedril", null, null, null },
                    { 16, null, null, null, "Pidgey", null, null, null },
                    { 17, null, null, null, "Pidgeotto", null, null, null },
                    { 18, null, null, null, "Pidgeot", null, null, null },
                    { 19, null, null, null, "Rattata", null, null, null },
                    { 20, null, null, null, "Raticat", null, null, null },
                    { 21, null, null, null, "Spearow", null, null, null },
                    { 22, null, null, null, "Fearow", null, null, null },
                    { 23, null, null, null, "Ekans", null, null, null },
                    { 24, null, null, null, "Arbok", null, null, null },
                    { 25, null, null, null, "Pikachu", null, null, null },
                    { 26, null, null, null, "Raichu", null, null, null },
                    { 27, null, null, null, "Sandshrew", null, null, null },
                    { 28, null, null, null, "Sandslah", null, null, null },
                    { 29, null, null, null, "Nidoran ♀", null, null, null },
                    { 30, null, null, null, "Nidorina", null, null, null },
                    { 31, null, null, null, "Nidoqueen", null, null, null },
                    { 32, null, null, null, "Nidoran ♂", null, null, null },
                    { 33, null, null, null, "Nidorino", null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Pokedex",
                columns: new[] { "ID", "Altura", "Basico", "Imagen", "Nombre", "Peso", "StatId", "Tier" },
                values: new object[,]
                {
                    { 34, null, null, null, "Nidoking", null, null, null },
                    { 35, null, null, null, "Clefairy", null, null, null },
                    { 36, null, null, null, "Clefable", null, null, null },
                    { 37, null, null, null, "Vulpix", null, null, null },
                    { 38, null, null, null, "Ninetales", null, null, null },
                    { 39, null, null, null, "Jigglypuff", null, null, null },
                    { 40, null, null, null, "Wigglytuff", null, null, null },
                    { 41, null, null, null, "Zubat", null, null, null },
                    { 42, null, null, null, "Golbat", null, null, null },
                    { 43, null, null, null, "Oddish", null, null, null },
                    { 44, null, null, null, "Gloom", null, null, null },
                    { 45, null, null, null, "Vileplume", null, null, null },
                    { 46, null, null, null, "Paras", null, null, null },
                    { 47, null, null, null, "Parasect", null, null, null },
                    { 48, null, null, null, "Venonat", null, null, null },
                    { 49, null, null, null, "Venomoth", null, null, null },
                    { 50, null, null, null, "Diglett", null, null, null },
                    { 51, null, null, null, "Dugtrio", null, null, null },
                    { 52, null, null, null, "Meowth", null, null, null },
                    { 53, null, null, null, "Persian", null, null, null },
                    { 54, null, null, null, "Psyduck", null, null, null },
                    { 55, null, null, null, "Golduck", null, null, null },
                    { 56, null, null, null, "Mankey", null, null, null },
                    { 57, null, null, null, "Primeape", null, null, null },
                    { 58, null, null, null, "Growlithe", null, null, null },
                    { 59, null, null, null, "Arcanine", null, null, null },
                    { 60, null, null, null, "Poliwag", null, null, null },
                    { 61, null, null, null, "Poliwhirl", null, null, null },
                    { 62, null, null, null, "Poliwrath", null, null, null },
                    { 63, null, null, null, "Abra", null, null, null },
                    { 64, null, null, null, "Kadabra", null, null, null },
                    { 65, null, null, null, "Alakazam", null, null, null },
                    { 66, null, null, null, "Machop", null, null, null },
                    { 67, null, null, null, "Machoke", null, null, null },
                    { 68, null, null, null, "Machamp", null, null, null },
                    { 69, null, null, null, "Bellsprout", null, null, null },
                    { 70, null, null, null, "Weepinbell", null, null, null },
                    { 71, null, null, null, "Victreebell", null, null, null },
                    { 72, null, null, null, "Tentacool", null, null, null },
                    { 73, null, null, null, "Tentacruel", null, null, null },
                    { 74, null, null, null, "Geodude", null, null, null },
                    { 75, null, null, null, "Graveler", null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Pokedex",
                columns: new[] { "ID", "Altura", "Basico", "Imagen", "Nombre", "Peso", "StatId", "Tier" },
                values: new object[,]
                {
                    { 76, null, null, null, "Golem", null, null, null },
                    { 77, null, null, null, "Ponyta", null, null, null },
                    { 78, null, null, null, "Rapidash", null, null, null },
                    { 79, null, null, null, "Slowpoke", null, null, null },
                    { 80, null, null, null, "Slowbro", null, null, null },
                    { 81, null, null, null, "Magnemite", null, null, null },
                    { 82, null, null, null, "Magneton", null, null, null },
                    { 83, null, null, null, "Farfetch'd", null, null, null },
                    { 84, null, null, null, "Doduo", null, null, null },
                    { 85, null, null, null, "Dodrio", null, null, null },
                    { 86, null, null, null, "Seel", null, null, null },
                    { 87, null, null, null, "Dewgong", null, null, null },
                    { 88, null, null, null, "Grimer", null, null, null },
                    { 89, null, null, null, "Muk", null, null, null },
                    { 90, null, null, null, "Shellder", null, null, null },
                    { 91, null, null, null, "Cloyster", null, null, null },
                    { 92, null, null, null, "Gastly", null, null, null },
                    { 93, null, null, null, "Haunter", null, null, null },
                    { 94, null, null, null, "Gengar", null, null, null },
                    { 95, null, null, null, "Onix", null, null, null },
                    { 96, null, null, null, "Drowzee", null, null, null },
                    { 97, null, null, null, "Hypno", null, null, null },
                    { 98, null, null, null, "Krabby", null, null, null },
                    { 99, null, null, null, "Kingler", null, null, null },
                    { 100, null, null, null, "Voltorb", null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Stat",
                columns: new[] { "Id", "Ataque", "Defensa", "Nivel", "Vida" },
                values: new object[] { 1, 15, 10, 20, 40 });

            migrationBuilder.InsertData(
                table: "Tipo",
                columns: new[] { "Id", "Tipo_pokemon" },
                values: new object[,]
                {
                    { 1, "Fuego" },
                    { 2, "Agua" },
                    { 3, "Planta" },
                    { 4, "Electrico" },
                    { 5, "Roca" },
                    { 6, "Acero" },
                    { 7, "Volador" },
                    { 8, "Hielo" },
                    { 9, "Bicho" },
                    { 10, "Normal" },
                    { 11, "Tierra" },
                    { 12, "Lucha" },
                    { 13, "Hada" },
                    { 14, "Psiquico" },
                    { 16, "Dragón" },
                    { 17, "Fantasma" }
                });

            migrationBuilder.InsertData(
                table: "Tipo",
                columns: new[] { "Id", "Tipo_pokemon" },
                values: new object[] { 18, "Siniestro" });

            migrationBuilder.InsertData(
                table: "Tipo",
                columns: new[] { "Id", "Tipo_pokemon" },
                values: new object[] { 19, "Veneno" });

            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "Id", "Nivel", "Nombre", "PokedexId", "Shiny", "StatId" },
                values: new object[,]
                {
                    { 1, 0, null, 1, null, null },
                    { 2, 0, null, 4, null, null },
                    { 3, 0, null, 2, null, null },
                    { 4, 0, null, 5, null, null },
                    { 5, 0, null, 100, null, null },
                    { 6, 0, null, 25, null, null }
                });

            migrationBuilder.InsertData(
                table: "TipoBonus",
                columns: new[] { "Id", "DebilidadId", "EficazId", "IdTipo" },
                values: new object[,]
                {
                    { 1, 2, 3, 1 },
                    { 2, 4, 1, 2 },
                    { 3, 8, 11, 2 }
                });

            migrationBuilder.InsertData(
                table: "Tipos_Habilidades",
                columns: new[] { "HabilidadId", "TipoId", "Id" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 2, 2 },
                    { 3, 3, 3 },
                    { 3, 4, 5 },
                    { 4, 4, 4 }
                });

            migrationBuilder.InsertData(
                table: "Tipos_Pokemons",
                columns: new[] { "Id", "PokedexId", "PokemonId", "TipoId" },
                values: new object[,]
                {
                    { 1, 1, null, 3 },
                    { 2, 1, null, 19 }
                });

            migrationBuilder.InsertData(
                table: "Entrenadores_Pokemon",
                columns: new[] { "Id", "EntrenadorId", "PokemonId" },
                values: new object[] { 1, 1, 5 });

            migrationBuilder.InsertData(
                table: "Entrenadores_Pokemon",
                columns: new[] { "Id", "EntrenadorId", "PokemonId" },
                values: new object[] { 2, 2, 6 });

            migrationBuilder.InsertData(
                table: "Entrenadores_Pokemon",
                columns: new[] { "Id", "EntrenadorId", "PokemonId" },
                values: new object[] { 3, 2, 6 });

            migrationBuilder.CreateIndex(
                name: "IX_Debilidades_IdTipo",
                table: "Debilidades",
                column: "IdTipo");

            migrationBuilder.CreateIndex(
                name: "IX_Entrenadores_Pokemon_EntrenadorId",
                table: "Entrenadores_Pokemon",
                column: "EntrenadorId");

            migrationBuilder.CreateIndex(
                name: "IX_Entrenadores_Pokemon_PokemonId",
                table: "Entrenadores_Pokemon",
                column: "PokemonId");

            migrationBuilder.CreateIndex(
                name: "IX_Fortalezas_IdTipo",
                table: "Fortalezas",
                column: "IdTipo");

            migrationBuilder.CreateIndex(
                name: "IX_ModificadorTipo_BonusId",
                table: "ModificadorTipo",
                column: "BonusId");

            migrationBuilder.CreateIndex(
                name: "IX_Pokedex_StatId",
                table: "Pokedex",
                column: "StatId");

            migrationBuilder.CreateIndex(
                name: "IX_Pokemon_PokedexId",
                table: "Pokemon",
                column: "PokedexId");

            migrationBuilder.CreateIndex(
                name: "IX_Pokemon_StatId",
                table: "Pokemon",
                column: "StatId");

            migrationBuilder.CreateIndex(
                name: "IX_TipoBonus_DebilidadId",
                table: "TipoBonus",
                column: "DebilidadId");

            migrationBuilder.CreateIndex(
                name: "IX_Tipos_Habilidades_HabilidadId",
                table: "Tipos_Habilidades",
                column: "HabilidadId");

            migrationBuilder.CreateIndex(
                name: "IX_Tipos_Pokemons_PokedexId",
                table: "Tipos_Pokemons",
                column: "PokedexId");

            migrationBuilder.CreateIndex(
                name: "IX_Tipos_Pokemons_PokemonId",
                table: "Tipos_Pokemons",
                column: "PokemonId");

            migrationBuilder.CreateIndex(
                name: "IX_Tipos_Pokemons_TipoId",
                table: "Tipos_Pokemons",
                column: "TipoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Debilidades");

            migrationBuilder.DropTable(
                name: "Entrenadores_Pokemon");

            migrationBuilder.DropTable(
                name: "Fortalezas");

            migrationBuilder.DropTable(
                name: "ModificadorTipo");

            migrationBuilder.DropTable(
                name: "TipoBonus");

            migrationBuilder.DropTable(
                name: "Tipos_Habilidades");

            migrationBuilder.DropTable(
                name: "Tipos_Pokemons");

            migrationBuilder.DropTable(
                name: "Entrenador");

            migrationBuilder.DropTable(
                name: "Habilidades");

            migrationBuilder.DropTable(
                name: "Pokemon");

            migrationBuilder.DropTable(
                name: "Tipo");

            migrationBuilder.DropTable(
                name: "Pokedex");

            migrationBuilder.DropTable(
                name: "Stat");
        }
    }
}
