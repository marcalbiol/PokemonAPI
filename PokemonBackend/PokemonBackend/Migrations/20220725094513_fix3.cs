using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PokemonBackend.Migrations
{
    public partial class fix3 : Migration
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Pokemons",
                columns: new[] { "Id", "EntrenadorId", "Nombre", "PokemonID", "Shiny", "StatId" },
                values: new object[,]
                {
                    { 1, null, "Charmander", null, null, 1 },
                    { 2, null, "Squirtle", null, null, null },
                    { 3, null, "Bulbasaur", null, null, null },
                    { 4, null, "Pikachu", null, null, null },
                    { 5, null, "Onix", null, null, null }
                });
        }
    }
}
