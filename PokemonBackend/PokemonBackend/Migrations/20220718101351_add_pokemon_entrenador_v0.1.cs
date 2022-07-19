using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PokemonBackend.Migrations
{
    public partial class add_pokemon_entrenador_v01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Entrenadores_Pokemons_Pokemon_idId",
                table: "Entrenadores");

            migrationBuilder.RenameColumn(
                name: "Pokemon_idId",
                table: "Entrenadores",
                newName: "pokemonId");

            migrationBuilder.RenameIndex(
                name: "IX_Entrenadores_Pokemon_idId",
                table: "Entrenadores",
                newName: "IX_Entrenadores_pokemonId");

            migrationBuilder.InsertData(
                table: "Entrenadores",
                columns: new[] { "Id", "Derrotas", "Nombre", "Victorias", "pokemonId" },
                values: new object[,]
                {
                    { 1, 3, "Marc", 2, null },
                    { 2, 3, "Jose", 2, null }
                });

            migrationBuilder.InsertData(
                table: "Pokemons",
                columns: new[] { "Id", "Ataque", "Defensa", "Nivel", "Nombre", "Tipo", "Vida" },
                values: new object[,]
                {
                    { 1, 14, 10, 25, "Pikachu", "Electrico", 30 },
                    { 2, 14, 10, 25, "Charmander", "Fuego", 30 }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Entrenadores_Pokemons_pokemonId",
                table: "Entrenadores",
                column: "pokemonId",
                principalTable: "Pokemons",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Entrenadores_Pokemons_pokemonId",
                table: "Entrenadores");

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

            migrationBuilder.RenameColumn(
                name: "pokemonId",
                table: "Entrenadores",
                newName: "Pokemon_idId");

            migrationBuilder.RenameIndex(
                name: "IX_Entrenadores_pokemonId",
                table: "Entrenadores",
                newName: "IX_Entrenadores_Pokemon_idId");

            migrationBuilder.AddForeignKey(
                name: "FK_Entrenadores_Pokemons_Pokemon_idId",
                table: "Entrenadores",
                column: "Pokemon_idId",
                principalTable: "Pokemons",
                principalColumn: "Id");
        }
    }
}
