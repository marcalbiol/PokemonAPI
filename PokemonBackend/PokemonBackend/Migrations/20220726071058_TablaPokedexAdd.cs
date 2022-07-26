using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PokemonBackend.Migrations
{
    public partial class TablaPokedexAdd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Tipo_Pokemons",
                keyColumns: new[] { "PokemonId", "TipoId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "Tipo_Pokemons",
                keyColumns: new[] { "PokemonId", "TipoId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "Tipo_Pokemons",
                keyColumns: new[] { "PokemonId", "TipoId" },
                keyValues: new object[] { 4, 4 });

            migrationBuilder.DeleteData(
                table: "Tipo_Pokemons",
                keyColumns: new[] { "PokemonId", "TipoId" },
                keyValues: new object[] { 5, 5 });

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DropColumn(
                name: "PokemonID",
                table: "Pokemons");

            migrationBuilder.CreateTable(
                name: "Pokedex",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Imagen = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StatId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pokedex", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pokedex_Stats_StatId",
                        column: x => x.StatId,
                        principalTable: "Stats",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Pokedex",
                columns: new[] { "Id", "Imagen", "Nombre", "StatId" },
                values: new object[,]
                {
                    { 1, null, "Bulbasaur", null },
                    { 2, null, "Ivysaur", null },
                    { 3, null, "Venasaur", null },
                    { 4, null, "Charmand ", null },
                    { 5, null, "Charmele  ", null },
                    { 6, null, "Charizar ", null },
                    { 7, null, "Squirtle ", null },
                    { 8, null, "Wartotle", null },
                    { 9, null, "Blastois", null },
                    { 10, null, "Caterpi", null },
                    { 11, null, "Metapod", null },
                    { 12, null, "Butterfree", null },
                    { 13, null, "Weedle", null },
                    { 14, null, "Kakuna", null },
                    { 15, null, "Beedril", null },
                    { 16, null, "Pidgey", null },
                    { 17, null, "Rattata", null },
                    { 18, null, "Raticat", null },
                    { 19, null, "Spearow", null },
                    { 20, null, "Fearow", null },
                    { 21, null, "Ekans", null },
                    { 22, null, "Pikachu", null },
                    { 23, null, "Raichu", null },
                    { 24, null, "Sandshr", null },
                    { 25, null, "Sandsla", null },
                    { 26, null, "Nidoran", null },
                    { 27, null, "Nidorin", null },
                    { 28, null, "Nidoque", null },
                    { 29, null, "Nidoran", null },
                    { 30, null, "Nidorin", null },
                    { 31, null, "Nidokin", null },
                    { 32, null, "Clefair", null },
                    { 33, null, "Clefabl", null },
                    { 34, null, "Vulpix", null },
                    { 35, null, "Ninetal", null },
                    { 36, null, "Jigglyp", null },
                    { 37, null, "Wigglyt", null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pokedex_StatId",
                table: "Pokedex",
                column: "StatId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pokedex");

            migrationBuilder.AddColumn<string>(
                name: "PokemonID",
                table: "Pokemons",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Pokemons",
                columns: new[] { "Id", "EntrenadorId", "Nombre", "PokemonID", "Shiny", "StatId" },
                values: new object[,]
                {
                    { 1, null, "Bulbasaur", "#001", null, null },
                    { 2, null, "Ivysaur", "#002", null, null },
                    { 3, null, "Venasaur", "#003", null, null },
                    { 4, null, "Charmander", "#004", null, null },
                    { 5, null, "Charmeleon", "#005", null, null },
                    { 6, null, "Charizard", "#006", null, null },
                    { 7, null, "Squirtle", "#007", null, null },
                    { 8, null, "Wartotle", "#008", null, null },
                    { 9, null, "Blastoise", "#009", null, null },
                    { 10, null, "Caterpie", "#010", null, null },
                    { 11, null, "Metapod", "#011", null, null },
                    { 12, null, "Butterfree", "#012", null, null },
                    { 13, null, "Weedle", "#013", null, null },
                    { 14, null, "Kakuna", "#014", null, null },
                    { 15, null, "Beedrill", "#015", null, null },
                    { 16, null, "Pidgey", "#016", null, null },
                    { 17, null, "Rattata", "#017", null, null },
                    { 18, null, "Raticate", "#018", null, null },
                    { 19, null, "Spearow", "#019", null, null },
                    { 20, null, "Fearow", "#020", null, null },
                    { 21, null, "Ekans", "#021", null, null },
                    { 22, null, "Pikachu", "#022", null, null },
                    { 23, null, "Raichu", "#023", null, null },
                    { 24, null, "Sandshrew", "#024", null, null },
                    { 25, null, "Sandslash", "#025", null, null },
                    { 26, null, "Nidoran ♀", "#026", null, null },
                    { 27, null, "Nidorina", "#027", null, null },
                    { 28, null, "Nidoqueen", "#028", null, null },
                    { 29, null, "Nidoran ♂", "#029", null, null },
                    { 30, null, "Nidorino", "#030", null, null },
                    { 31, null, "Nidoking", "#031", null, null },
                    { 32, null, "Clefairy", "#032", null, null },
                    { 33, null, "Clefable", "#033", null, null },
                    { 34, null, "Vulpix", "#034", null, null },
                    { 35, null, "Ninetales", "#035", null, null },
                    { 36, null, "Jigglypuff", "#036", null, null },
                    { 37, null, "Wigglytuff", "#037", null, null }
                });

            migrationBuilder.InsertData(
                table: "Tipo_Pokemons",
                columns: new[] { "PokemonId", "TipoId" },
                values: new object[,]
                {
                    { 2, 2 },
                    { 3, 3 },
                    { 4, 4 },
                    { 5, 5 }
                });
        }
    }
}
