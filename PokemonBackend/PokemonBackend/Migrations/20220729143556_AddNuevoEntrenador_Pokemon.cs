using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PokemonBackend.Migrations
{
    public partial class AddNuevoEntrenador_Pokemon : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Entrenadores_Pokemons",
                columns: new[] { "EntrenadorId", "PokemonId" },
                values: new object[] { 2, 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Entrenadores_Pokemons",
                keyColumns: new[] { "EntrenadorId", "PokemonId" },
                keyValues: new object[] { 2, 1 });
        }
    }
}
