using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Acceso_BD.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Entrenadores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entrenadores", x => x.Id);
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
                name: "Regiones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Regiones", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Stats",
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
                    table.PrimaryKey("PK_Stats", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tiers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tiers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tipos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tipo_pokemon = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tipos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Zonas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreZona = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zonas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Bonuses",
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
                    table.PrimaryKey("PK_Bonuses", x => x.Id);
                    table.UniqueConstraint("AK_Bonuses_EficazId_DebilidadId_IdTipo", x => new { x.EficazId, x.DebilidadId, x.IdTipo });
                    table.ForeignKey(
                        name: "FK_Bonuses_Tipos_DebilidadId",
                        column: x => x.DebilidadId,
                        principalTable: "Tipos",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Bonuses_Tipos_EficazId",
                        column: x => x.EficazId,
                        principalTable: "Tipos",
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
                        name: "FK_Debilidades_Tipos_IdTipo",
                        column: x => x.IdTipo,
                        principalTable: "Tipos",
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
                        name: "FK_Fortalezas_Tipos_IdTipo",
                        column: x => x.IdTipo,
                        principalTable: "Tipos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Modificadores",
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
                    table.PrimaryKey("PK_Modificadores", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Modificadores_Tipos_BonusId",
                        column: x => x.BonusId,
                        principalTable: "Tipos",
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
                        name: "FK_Tipos_Habilidades_Tipos_TipoId",
                        column: x => x.TipoId,
                        principalTable: "Tipos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    TierId = table.Column<int>(type: "int", nullable: true),
                    Basico = table.Column<bool>(type: "bit", nullable: true),
                    RegionId = table.Column<int>(type: "int", nullable: true),
                    ZonaId = table.Column<int>(type: "int", nullable: true),
                    StatId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pokedex", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Pokedex_Regiones_RegionId",
                        column: x => x.RegionId,
                        principalTable: "Regiones",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Pokedex_Stats_StatId",
                        column: x => x.StatId,
                        principalTable: "Stats",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Pokedex_Tiers_TierId",
                        column: x => x.TierId,
                        principalTable: "Tiers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Pokedex_Zonas_ZonaId",
                        column: x => x.ZonaId,
                        principalTable: "Zonas",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Pokemons",
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
                    table.PrimaryKey("PK_Pokemons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pokemons_Pokedex_PokedexId",
                        column: x => x.PokedexId,
                        principalTable: "Pokedex",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Pokemons_Stats_StatId",
                        column: x => x.StatId,
                        principalTable: "Stats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tipo_Pokemons",
                columns: table => new
                {
                    TipoId = table.Column<int>(type: "int", nullable: false),
                    PokedexId = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tipo_Pokemons", x => new { x.PokedexId, x.TipoId });
                    table.ForeignKey(
                        name: "FK_Tipo_Pokemons_Pokedex_PokedexId",
                        column: x => x.PokedexId,
                        principalTable: "Pokedex",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tipo_Pokemons_Tipos_TipoId",
                        column: x => x.TipoId,
                        principalTable: "Tipos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Entrenadores_Pokemons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EntrenadorId = table.Column<int>(type: "int", nullable: true),
                    PokemonId = table.Column<int>(type: "int", nullable: true),
                    Shiny = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entrenadores_Pokemons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Entrenadores_Pokemons_Entrenadores_EntrenadorId",
                        column: x => x.EntrenadorId,
                        principalTable: "Entrenadores",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Entrenadores_Pokemons_Pokemons_PokemonId",
                        column: x => x.PokemonId,
                        principalTable: "Pokemons",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Entrenadores",
                columns: new[] { "Id", "Nombre" },
                values: new object[,]
                {
                    { 1, "Marc" },
                    { 2, "Dani" },
                    { 3, "Ernest" },
                    { 4, "Nicol" },
                    { 5, "Jose" }
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
                table: "Modificadores",
                columns: new[] { "Id", "BonusId", "IdTipo", "Modificador", "TipoBonusId" },
                values: new object[,]
                {
                    { 1, null, 1, 1, 2 },
                    { 2, null, 1, 0, 3 }
                });

            migrationBuilder.InsertData(
                table: "Pokedex",
                columns: new[] { "ID", "Altura", "Basico", "Imagen", "Nombre", "Peso", "RegionId", "StatId", "TierId", "ZonaId" },
                values: new object[,]
                {
                    { 4, null, true, null, "Charmander", null, null, null, null, null },
                    { 5, null, false, null, "Charmeleon", null, null, null, null, null },
                    { 6, null, false, null, "Charizard ", null, null, null, null, null },
                    { 7, null, true, null, "Squirtle", null, null, null, null, null },
                    { 8, null, null, null, "Wartotle", null, null, null, null, null },
                    { 9, null, null, null, "Blastoise", null, null, null, null, null },
                    { 11, null, null, null, "Metapod", null, null, null, null, null },
                    { 12, null, null, null, "Butterfree", null, null, null, null, null },
                    { 14, null, null, null, "Kakuna", null, null, null, null, null },
                    { 15, null, null, null, "Beedril", null, null, null, null, null },
                    { 16, null, null, null, "Pidgey", null, null, null, null, null },
                    { 17, null, null, null, "Pidgeotto", null, null, null, null, null },
                    { 18, null, null, null, "Pidgeot", null, null, null, null, null },
                    { 19, null, null, null, "Rattata", null, null, null, null, null },
                    { 20, null, null, null, "Raticat", null, null, null, null, null },
                    { 21, null, null, null, "Spearow", null, null, null, null, null },
                    { 22, null, null, null, "Fearow", null, null, null, null, null },
                    { 23, null, null, null, "Ekans", null, null, null, null, null },
                    { 24, null, null, null, "Arbok", null, null, null, null, null },
                    { 25, null, null, null, "Pikachu", null, null, null, null, null },
                    { 26, null, null, null, "Raichu", null, null, null, null, null },
                    { 27, null, null, null, "Sandshrew", null, null, null, null, null },
                    { 28, null, null, null, "Sandslah", null, null, null, null, null },
                    { 29, null, null, null, "Nidoran ♀", null, null, null, null, null },
                    { 30, null, null, null, "Nidorina", null, null, null, null, null },
                    { 31, null, null, null, "Nidoqueen", null, null, null, null, null },
                    { 32, null, null, null, "Nidoran ♂", null, null, null, null, null },
                    { 33, null, null, null, "Nidorino", null, null, null, null, null },
                    { 34, null, null, null, "Nidoking", null, null, null, null, null },
                    { 35, null, null, null, "Clefairy", null, null, null, null, null },
                    { 36, null, null, null, "Clefable", null, null, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Pokedex",
                columns: new[] { "ID", "Altura", "Basico", "Imagen", "Nombre", "Peso", "RegionId", "StatId", "TierId", "ZonaId" },
                values: new object[,]
                {
                    { 37, null, null, null, "Vulpix", null, null, null, null, null },
                    { 38, null, null, null, "Ninetales", null, null, null, null, null },
                    { 39, null, null, null, "Jigglypuff", null, null, null, null, null },
                    { 40, null, null, null, "Wigglytuff", null, null, null, null, null },
                    { 41, null, null, null, "Zubat", null, null, null, null, null },
                    { 42, null, null, null, "Golbat", null, null, null, null, null },
                    { 43, null, null, null, "Oddish", null, null, null, null, null },
                    { 44, null, null, null, "Gloom", null, null, null, null, null },
                    { 45, null, null, null, "Vileplume", null, null, null, null, null },
                    { 46, null, null, null, "Paras", null, null, null, null, null },
                    { 47, null, null, null, "Parasect", null, null, null, null, null },
                    { 48, null, null, null, "Venonat", null, null, null, null, null },
                    { 49, null, null, null, "Venomoth", null, null, null, null, null },
                    { 50, null, null, null, "Diglett", null, null, null, null, null },
                    { 51, null, null, null, "Dugtrio", null, null, null, null, null },
                    { 52, null, null, null, "Meowth", null, null, null, null, null },
                    { 53, null, null, null, "Persian", null, null, null, null, null },
                    { 54, null, null, null, "Psyduck", null, null, null, null, null },
                    { 55, null, null, null, "Golduck", null, null, null, null, null },
                    { 56, null, null, null, "Mankey", null, null, null, null, null },
                    { 57, null, null, null, "Primeape", null, null, null, null, null },
                    { 58, null, null, null, "Growlithe", null, null, null, null, null },
                    { 59, null, null, null, "Arcanine", null, null, null, null, null },
                    { 60, null, null, null, "Poliwag", null, null, null, null, null },
                    { 61, null, null, null, "Poliwhirl", null, null, null, null, null },
                    { 62, null, null, null, "Poliwrath", null, null, null, null, null },
                    { 63, null, null, null, "Abra", null, null, null, null, null },
                    { 64, null, null, null, "Kadabra", null, null, null, null, null },
                    { 65, null, null, null, "Alakazam", null, null, null, null, null },
                    { 66, null, null, null, "Machop", null, null, null, null, null },
                    { 67, null, null, null, "Machoke", null, null, null, null, null },
                    { 68, null, null, null, "Machamp", null, null, null, null, null },
                    { 69, null, null, null, "Bellsprout", null, null, null, null, null },
                    { 70, null, null, null, "Weepinbell", null, null, null, null, null },
                    { 71, null, null, null, "Victreebell", null, null, null, null, null },
                    { 72, null, null, null, "Tentacool", null, null, null, null, null },
                    { 73, null, null, null, "Tentacruel", null, null, null, null, null },
                    { 74, null, null, null, "Geodude", null, null, null, null, null },
                    { 75, null, null, null, "Graveler", null, null, null, null, null },
                    { 76, null, null, null, "Golem", null, null, null, null, null },
                    { 77, null, null, null, "Ponyta", null, null, null, null, null },
                    { 78, null, null, null, "Rapidash", null, null, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Pokedex",
                columns: new[] { "ID", "Altura", "Basico", "Imagen", "Nombre", "Peso", "RegionId", "StatId", "TierId", "ZonaId" },
                values: new object[,]
                {
                    { 79, null, null, null, "Slowpoke", null, null, null, null, null },
                    { 80, null, null, null, "Slowbro", null, null, null, null, null },
                    { 81, null, null, null, "Magnemite", null, null, null, null, null },
                    { 82, null, null, null, "Magneton", null, null, null, null, null },
                    { 83, null, null, null, "Farfetch'd", null, null, null, null, null },
                    { 84, null, null, null, "Doduo", null, null, null, null, null },
                    { 85, null, null, null, "Dodrio", null, null, null, null, null },
                    { 86, null, null, null, "Seel", null, null, null, null, null },
                    { 87, null, null, null, "Dewgong", null, null, null, null, null },
                    { 88, null, null, null, "Grimer", null, null, null, null, null },
                    { 89, null, null, null, "Muk", null, null, null, null, null },
                    { 90, null, null, null, "Shellder", null, null, null, null, null },
                    { 91, null, null, null, "Cloyster", null, null, null, null, null },
                    { 92, null, null, null, "Gastly", null, null, null, null, null },
                    { 93, null, null, null, "Haunter", null, null, null, null, null },
                    { 94, null, null, null, "Gengar", null, null, null, null, null },
                    { 95, null, null, null, "Onix", null, null, null, null, null },
                    { 96, null, null, null, "Drowzee", null, null, null, null, null },
                    { 97, null, null, null, "Hypno", null, null, null, null, null },
                    { 98, null, null, null, "Krabby", null, null, null, null, null },
                    { 99, null, null, null, "Kingler", null, null, null, null, null },
                    { 100, null, null, null, "Voltorb", null, null, null, null, null },
                    { 101, null, null, null, "Electrode", null, null, null, null, null },
                    { 102, null, null, null, "Exeggcute", null, null, null, null, null },
                    { 103, null, null, null, "Exeggutor", null, null, null, null, null },
                    { 104, null, null, null, "Cubone", null, null, null, null, null },
                    { 105, null, null, null, "Marowak", null, null, null, null, null },
                    { 106, null, null, null, "Hitmonlee", null, null, null, null, null },
                    { 107, null, null, null, "Hitmonchan", null, null, null, null, null },
                    { 108, null, null, null, "Lickitung", null, null, null, null, null },
                    { 109, null, null, null, "Koffing", null, null, null, null, null },
                    { 110, null, null, null, "Weezing", null, null, null, null, null },
                    { 111, null, null, null, "Rhyhorn", null, null, null, null, null },
                    { 112, null, null, null, "Rhydon", null, null, null, null, null },
                    { 113, null, null, null, "Chansey", null, null, null, null, null },
                    { 114, null, null, null, "Tangela", null, null, null, null, null },
                    { 115, null, null, null, "Kangskhan", null, null, null, null, null },
                    { 116, null, null, null, "Horsea", null, null, null, null, null },
                    { 117, null, null, null, "Seadra", null, null, null, null, null },
                    { 118, null, null, null, "Goldeen", null, null, null, null, null },
                    { 119, null, null, null, "Seaking", null, null, null, null, null },
                    { 120, null, null, null, "Staryu", null, null, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Pokedex",
                columns: new[] { "ID", "Altura", "Basico", "Imagen", "Nombre", "Peso", "RegionId", "StatId", "TierId", "ZonaId" },
                values: new object[,]
                {
                    { 121, null, null, null, "Starmie", null, null, null, null, null },
                    { 122, null, null, null, "Mr.Mime", null, null, null, null, null },
                    { 123, null, null, null, "Scyher", null, null, null, null, null },
                    { 124, null, null, null, "Jynx", null, null, null, null, null },
                    { 125, null, null, null, "Electabuzz", null, null, null, null, null },
                    { 126, null, null, null, "Magmar", null, null, null, null, null },
                    { 127, null, null, null, "Pinsir", null, null, null, null, null },
                    { 128, null, null, null, "Tauros", null, null, null, null, null },
                    { 129, null, null, null, "Magikarp", null, null, null, null, null },
                    { 130, null, null, null, "Gyarados", null, null, null, null, null },
                    { 131, null, null, null, "Lapras", null, null, null, null, null },
                    { 132, null, null, null, "Ditto", null, null, null, null, null },
                    { 133, null, null, null, "Eevee", null, null, null, null, null },
                    { 134, null, null, null, "Vaporeon", null, null, null, null, null },
                    { 135, null, null, null, "Jolteon", null, null, null, null, null },
                    { 136, null, null, null, "Flareon", null, null, null, null, null },
                    { 137, null, null, null, "Porygon", null, null, null, null, null },
                    { 138, null, null, null, "Omanyte", null, null, null, null, null },
                    { 139, null, null, null, "Omastar", null, null, null, null, null },
                    { 140, null, null, null, "Kabuto", null, null, null, null, null },
                    { 141, null, null, null, "Kabutops", null, null, null, null, null },
                    { 142, null, null, null, "Aerodactyl", null, null, null, null, null },
                    { 143, null, null, null, "Snorlax", null, null, null, null, null },
                    { 144, null, null, null, "Articuno", null, null, null, null, null },
                    { 145, null, null, null, "Zapdos", null, null, null, null, null },
                    { 146, null, null, null, "Moltres", null, null, null, null, null },
                    { 147, null, null, null, "Dratini", null, null, null, null, null },
                    { 148, null, null, null, "Dragonair", null, null, null, null, null },
                    { 149, null, null, null, "Dragonite", null, null, null, null, null },
                    { 150, null, null, null, "Mewtwo", null, null, null, null, null },
                    { 151, null, null, null, "Mew", null, null, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Regiones",
                columns: new[] { "Id", "Nombre" },
                values: new object[,]
                {
                    { 1, "Kanto" },
                    { 2, "Johto" },
                    { 3, "Hoenn" }
                });

            migrationBuilder.InsertData(
                table: "Stats",
                columns: new[] { "Id", "Ataque", "Defensa", "Nivel", "Vida" },
                values: new object[] { 1, 15, 10, 20, 40 });

            migrationBuilder.InsertData(
                table: "Tiers",
                columns: new[] { "Id", "Descripcion" },
                values: new object[,]
                {
                    { 1, "Basico" },
                    { 4, "Legendario" }
                });

            migrationBuilder.InsertData(
                table: "Tipos",
                columns: new[] { "Id", "Tipo_pokemon" },
                values: new object[,]
                {
                    { 1, "Fuego" },
                    { 2, "Agua" },
                    { 3, "Planta" },
                    { 4, "Electrico" },
                    { 5, "Roca" }
                });

            migrationBuilder.InsertData(
                table: "Tipos",
                columns: new[] { "Id", "Tipo_pokemon" },
                values: new object[,]
                {
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
                    { 17, "Fantasma" },
                    { 18, "Siniestro" },
                    { 19, "Veneno" }
                });

            migrationBuilder.InsertData(
                table: "Zonas",
                columns: new[] { "Id", "NombreZona" },
                values: new object[,]
                {
                    { 1, "Inicio" },
                    { 2, "Inicio2" }
                });

            migrationBuilder.InsertData(
                table: "Bonuses",
                columns: new[] { "Id", "DebilidadId", "EficazId", "IdTipo" },
                values: new object[,]
                {
                    { 1, 2, 3, 1 },
                    { 2, 4, 1, 2 },
                    { 3, 8, 11, 2 }
                });

            migrationBuilder.InsertData(
                table: "Pokedex",
                columns: new[] { "ID", "Altura", "Basico", "Imagen", "Nombre", "Peso", "RegionId", "StatId", "TierId", "ZonaId" },
                values: new object[,]
                {
                    { 1, null, true, null, "Bulbasaur", null, 1, null, 1, null },
                    { 2, null, false, null, "Ivysaur", null, 1, null, null, null },
                    { 3, null, false, null, "Venasaur", null, 2, null, null, null },
                    { 10, null, null, null, "Caterpie", null, null, null, null, 1 },
                    { 13, null, null, null, "Weedle", null, null, null, null, 2 }
                });

            migrationBuilder.InsertData(
                table: "Pokemons",
                columns: new[] { "Id", "Nivel", "Nombre", "PokedexId", "Shiny", "StatId" },
                values: new object[,]
                {
                    { 2, 0, null, 4, null, null },
                    { 4, 0, null, 5, null, null },
                    { 5, 0, null, 100, null, null },
                    { 6, 0, null, 25, null, null }
                });

            migrationBuilder.InsertData(
                table: "Tipo_Pokemons",
                columns: new[] { "PokedexId", "TipoId", "Id" },
                values: new object[,]
                {
                    { 4, 1, 7 },
                    { 5, 1, 8 },
                    { 6, 1, 9 },
                    { 6, 7, 10 },
                    { 7, 2, 11 },
                    { 8, 2, 12 },
                    { 9, 2, 13 },
                    { 11, 9, 15 },
                    { 12, 7, 17 },
                    { 12, 9, 16 },
                    { 14, 7, 20 },
                    { 14, 19, 21 },
                    { 15, 7, 22 },
                    { 15, 19, 23 },
                    { 16, 7, 24 },
                    { 16, 10, 25 },
                    { 17, 7, 26 },
                    { 17, 10, 27 },
                    { 18, 7, 28 },
                    { 18, 10, 29 },
                    { 19, 10, 30 },
                    { 20, 10, 31 },
                    { 21, 7, 33 },
                    { 21, 10, 32 },
                    { 22, 7, 34 },
                    { 22, 10, 35 },
                    { 23, 19, 36 },
                    { 24, 19, 37 },
                    { 25, 4, 38 },
                    { 26, 4, 39 }
                });

            migrationBuilder.InsertData(
                table: "Tipo_Pokemons",
                columns: new[] { "PokedexId", "TipoId", "Id" },
                values: new object[,]
                {
                    { 27, 11, 40 },
                    { 28, 11, 41 },
                    { 29, 19, 42 },
                    { 30, 19, 43 },
                    { 31, 11, 45 },
                    { 31, 19, 44 },
                    { 32, 19, 46 },
                    { 33, 19, 47 },
                    { 34, 11, 49 },
                    { 34, 19, 48 },
                    { 35, 13, 50 },
                    { 36, 13, 51 },
                    { 37, 1, 52 },
                    { 38, 1, 53 }
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
                table: "Entrenadores_Pokemons",
                columns: new[] { "Id", "EntrenadorId", "PokemonId", "Shiny" },
                values: new object[,]
                {
                    { 1, 1, 5, null },
                    { 2, 2, 6, null },
                    { 3, 2, 6, null }
                });

            migrationBuilder.InsertData(
                table: "Pokemons",
                columns: new[] { "Id", "Nivel", "Nombre", "PokedexId", "Shiny", "StatId" },
                values: new object[,]
                {
                    { 1, 0, null, 1, null, null },
                    { 3, 0, null, 2, null, null }
                });

            migrationBuilder.InsertData(
                table: "Tipo_Pokemons",
                columns: new[] { "PokedexId", "TipoId", "Id" },
                values: new object[,]
                {
                    { 1, 3, 1 },
                    { 1, 19, 2 },
                    { 2, 3, 3 },
                    { 2, 19, 4 },
                    { 3, 3, 5 },
                    { 3, 19, 6 },
                    { 10, 9, 14 },
                    { 13, 7, 18 },
                    { 13, 19, 19 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bonuses_DebilidadId",
                table: "Bonuses",
                column: "DebilidadId");

            migrationBuilder.CreateIndex(
                name: "IX_Debilidades_IdTipo",
                table: "Debilidades",
                column: "IdTipo");

            migrationBuilder.CreateIndex(
                name: "IX_Entrenadores_Pokemons_EntrenadorId",
                table: "Entrenadores_Pokemons",
                column: "EntrenadorId");

            migrationBuilder.CreateIndex(
                name: "IX_Entrenadores_Pokemons_PokemonId",
                table: "Entrenadores_Pokemons",
                column: "PokemonId");

            migrationBuilder.CreateIndex(
                name: "IX_Fortalezas_IdTipo",
                table: "Fortalezas",
                column: "IdTipo");

            migrationBuilder.CreateIndex(
                name: "IX_Modificadores_BonusId",
                table: "Modificadores",
                column: "BonusId");

            migrationBuilder.CreateIndex(
                name: "IX_Pokedex_RegionId",
                table: "Pokedex",
                column: "RegionId");

            migrationBuilder.CreateIndex(
                name: "IX_Pokedex_StatId",
                table: "Pokedex",
                column: "StatId");

            migrationBuilder.CreateIndex(
                name: "IX_Pokedex_TierId",
                table: "Pokedex",
                column: "TierId",
                unique: true,
                filter: "[TierId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Pokedex_ZonaId",
                table: "Pokedex",
                column: "ZonaId");

            migrationBuilder.CreateIndex(
                name: "IX_Pokemons_PokedexId",
                table: "Pokemons",
                column: "PokedexId");

            migrationBuilder.CreateIndex(
                name: "IX_Pokemons_StatId",
                table: "Pokemons",
                column: "StatId");

            migrationBuilder.CreateIndex(
                name: "IX_Tipo_Pokemons_TipoId",
                table: "Tipo_Pokemons",
                column: "TipoId");

            migrationBuilder.CreateIndex(
                name: "IX_Tipos_Habilidades_HabilidadId",
                table: "Tipos_Habilidades",
                column: "HabilidadId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bonuses");

            migrationBuilder.DropTable(
                name: "Debilidades");

            migrationBuilder.DropTable(
                name: "Entrenadores_Pokemons");

            migrationBuilder.DropTable(
                name: "Fortalezas");

            migrationBuilder.DropTable(
                name: "Modificadores");

            migrationBuilder.DropTable(
                name: "Tipo_Pokemons");

            migrationBuilder.DropTable(
                name: "Tipos_Habilidades");

            migrationBuilder.DropTable(
                name: "Entrenadores");

            migrationBuilder.DropTable(
                name: "Pokemons");

            migrationBuilder.DropTable(
                name: "Habilidades");

            migrationBuilder.DropTable(
                name: "Tipos");

            migrationBuilder.DropTable(
                name: "Pokedex");

            migrationBuilder.DropTable(
                name: "Regiones");

            migrationBuilder.DropTable(
                name: "Stats");

            migrationBuilder.DropTable(
                name: "Tiers");

            migrationBuilder.DropTable(
                name: "Zonas");
        }
    }
}
