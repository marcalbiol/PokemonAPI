using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Acceso_BD.Migrations
{
    public partial class campoShinyBoolean : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Entrenadores_Pokemons",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Entrenadores_Pokemons",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Entrenadores_Pokemons",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.AlterColumn<bool>(
                name: "Shiny",
                table: "Entrenadores_Pokemons",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.InsertData(
                table: "Entrenadores_Pokemons",
                columns: new[] { "Id", "EntrenadorId", "PokemonId", "Shiny" },
                values: new object[] { 1, 1, 5, null });

            migrationBuilder.InsertData(
                table: "Entrenadores_Pokemons",
                columns: new[] { "Id", "EntrenadorId", "PokemonId", "Shiny" },
                values: new object[] { 2, 2, 6, null });

            migrationBuilder.InsertData(
                table: "Entrenadores_Pokemons",
                columns: new[] { "Id", "EntrenadorId", "PokemonId", "Shiny" },
                values: new object[] { 3, 2, 6, null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Entrenadores_Pokemons",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Entrenadores_Pokemons",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Entrenadores_Pokemons",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.AlterColumn<bool>(
                name: "Shiny",
                table: "Entrenadores_Pokemons",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Entrenadores_Pokemons",
                columns: new[] { "Id", "EntrenadorId", "PokemonId", "Shiny" },
                values: new object[] { 1, 1, 5, false });

            migrationBuilder.InsertData(
                table: "Entrenadores_Pokemons",
                columns: new[] { "Id", "EntrenadorId", "PokemonId", "Shiny" },
                values: new object[] { 2, 2, 6, false });

            migrationBuilder.InsertData(
                table: "Entrenadores_Pokemons",
                columns: new[] { "Id", "EntrenadorId", "PokemonId", "Shiny" },
                values: new object[] { 3, 2, 6, false });
        }
    }
}
