using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PokemonBackend.Migrations
{
    public partial class Estable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Entrenadores_Pokemons",
                keyColumns: new[] { "EntrenadorId", "PokemonId" },
                keyValues: new object[] { 1, 5 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Entrenadores_Pokemons",
                columns: new[] { "EntrenadorId", "PokemonId" },
                values: new object[] { 1, 5 });
        }
    }
}
