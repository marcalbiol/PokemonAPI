using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PokemonBackend.Migrations
{
    public partial class Pokemon_DataSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pokemons_Entrenadores_EntrenadorId",
                table: "Pokemons");

            migrationBuilder.DropIndex(
                name: "IX_Pokemons_EntrenadorId",
                table: "Pokemons");

            migrationBuilder.DropColumn(
                name: "EntrenadorId",
                table: "Pokemons");

            migrationBuilder.RenameColumn(
                name: "nombres_entrenadores",
                table: "Entrenadores",
                newName: "Nombre");

            migrationBuilder.AddColumn<int>(
                name: "Pokemon_idId",
                table: "Entrenadores",
                type: "int",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Pokemons",
                columns: new[] { "Id", "Ataque", "Defensa", "Nivel", "Nombre", "Tipo", "Vida" },
                values: new object[] { 1, 14, 10, 25, "Pikachu", "Electrico", 30 });

            migrationBuilder.InsertData(
                table: "Pokemons",
                columns: new[] { "Id", "Ataque", "Defensa", "Nivel", "Nombre", "Tipo", "Vida" },
                values: new object[] { 2, 14, 10, 25, "Charmander", "Fuego", 30 });

            migrationBuilder.CreateIndex(
                name: "IX_Entrenadores_Pokemon_idId",
                table: "Entrenadores",
                column: "Pokemon_idId");

            migrationBuilder.AddForeignKey(
                name: "FK_Entrenadores_Pokemons_Pokemon_idId",
                table: "Entrenadores",
                column: "Pokemon_idId",
                principalTable: "Pokemons",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Entrenadores_Pokemons_Pokemon_idId",
                table: "Entrenadores");

            migrationBuilder.DropIndex(
                name: "IX_Entrenadores_Pokemon_idId",
                table: "Entrenadores");

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DropColumn(
                name: "Pokemon_idId",
                table: "Entrenadores");

            migrationBuilder.RenameColumn(
                name: "Nombre",
                table: "Entrenadores",
                newName: "nombres_entrenadores");

            migrationBuilder.AddColumn<int>(
                name: "EntrenadorId",
                table: "Pokemons",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pokemons_EntrenadorId",
                table: "Pokemons",
                column: "EntrenadorId",
                unique: true,
                filter: "[EntrenadorId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Pokemons_Entrenadores_EntrenadorId",
                table: "Pokemons",
                column: "EntrenadorId",
                principalTable: "Entrenadores",
                principalColumn: "Id");
        }
    }
}
