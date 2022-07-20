using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PokemonBackend.Migrations
{
    public partial class testJoin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Pokemons",
                columns: new[] { "Id", "Ataque", "Defensa", "EntrenadorId", "Nivel", "Nombre", "Vida" },
                values: new object[] { 2, null, null, null, null, "Squirtle", null });

            migrationBuilder.InsertData(
                table: "Pokemons",
                columns: new[] { "Id", "Ataque", "Defensa", "EntrenadorId", "Nivel", "Nombre", "Vida" },
                values: new object[] { 3, null, null, null, null, "Bulbasaur", null });

            migrationBuilder.InsertData(
                table: "Tipo_Pokemons",
                columns: new[] { "PokemonId", "TipoId" },
                values: new object[] { 2, 2 });

            migrationBuilder.InsertData(
                table: "Tipo_Pokemons",
                columns: new[] { "PokemonId", "TipoId" },
                values: new object[] { 3, 3 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tipo_Pokemons",
                keyColumns: new[] { "PokemonId", "TipoId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "Tipo_Pokemons",
                keyColumns: new[] { "PokemonId", "TipoId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
