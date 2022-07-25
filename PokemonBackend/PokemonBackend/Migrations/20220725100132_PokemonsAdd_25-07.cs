using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PokemonBackend.Migrations
{
    public partial class PokemonsAdd_2507 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 1);

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
        }
    }
}
