using Microsoft.EntityFrameworkCore.Migrations;


#nullable disable

namespace PokemonBackend.Migrations
{
    public partial class db_modelos_relacionados : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Entrenadores_Pokemons_pokemonId",
                table: "Entrenadores");

            migrationBuilder.RenameColumn(
                name: "pokemonId",
                table: "Entrenadores",
                newName: "PokemonId");

            migrationBuilder.RenameIndex(
                name: "IX_Entrenadores_pokemonId",
                table: "Entrenadores",
                newName: "IX_Entrenadores_PokemonId");

            migrationBuilder.AlterColumn<int>(
                name: "PokemonId",
                table: "Entrenadores",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Entrenadores",
                keyColumn: "Id",
                keyValue: 1,
                column: "PokemonId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Entrenadores",
                keyColumn: "Id",
                keyValue: 2,
                column: "PokemonId",
                value: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Entrenadores_Pokemons_PokemonId",
                table: "Entrenadores",
                column: "PokemonId",
                principalTable: "Pokemons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
            
        }

       

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Entrenadores_Pokemons_PokemonId",
                table: "Entrenadores");

            migrationBuilder.RenameColumn(
                name: "PokemonId",
                table: "Entrenadores",
                newName: "pokemonId");

            migrationBuilder.RenameIndex(
                name: "IX_Entrenadores_PokemonId",
                table: "Entrenadores",
                newName: "IX_Entrenadores_pokemonId");

            migrationBuilder.AlterColumn<int>(
                name: "pokemonId",
                table: "Entrenadores",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Entrenadores",
                keyColumn: "Id",
                keyValue: 1,
                column: "pokemonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Entrenadores",
                keyColumn: "Id",
                keyValue: 2,
                column: "pokemonId",
                value: null);

            migrationBuilder.AddForeignKey(
                name: "FK_Entrenadores_Pokemons_pokemonId",
                table: "Entrenadores",
                column: "pokemonId",
                principalTable: "Pokemons",
                principalColumn: "Id");
        }
    }
}
