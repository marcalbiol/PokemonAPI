using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PokemonBackend.Migrations
{
    public partial class DataSeed_Pokemons_Entrenadores : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Pokemons",
                columns: new[] { "Id", "Ataque", "Defensa", "Nivel", "Nombre", "Tipo", "Vida" },
                values: new object[] { 1, 14, 10, 25, "Pikachu", "Electrico", 30 });

            migrationBuilder.InsertData(
                table: "Pokemons",
                columns: new[] { "Id", "Ataque", "Defensa", "Nivel", "Nombre", "Tipo", "Vida" },
                values: new object[] { 2, 14, 10, 25, "Charmander", "Fuego", 30 });

            migrationBuilder.InsertData(
                table: "Entrenadores",
                columns: new[] { "Id", "Derrotas", "Nombre", "PokemonId", "Victorias" },
                values: new object[] { 1, 3, "Marc", 1, 2 });

            migrationBuilder.InsertData(
                table: "Entrenadores",
                columns: new[] { "Id", "Derrotas", "Nombre", "PokemonId", "Victorias" },
                values: new object[] { 2, 3, "Jose", 2, 2 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Entrenadores",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Entrenadores",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
