using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PokemonBackend.Migrations
{
    public partial class Data_Seed_02_relaciones : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Entrenadores_Pokemons_PokemonId",
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
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.AlterColumn<int>(
                name: "PokemonId",
                table: "Entrenadores",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Entrenadores_Pokemons_PokemonId",
                table: "Entrenadores",
                column: "PokemonId",
                principalTable: "Pokemons",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Entrenadores_Pokemons_PokemonId",
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

            migrationBuilder.AlterColumn<int>(
                name: "PokemonId",
                table: "Entrenadores",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Entrenadores",
                columns: new[] { "Id", "Derrotas", "Nombre", "PokemonId", "Victorias" },
                values: new object[] { 2, 3, "Jose", 0, 2 });

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

            migrationBuilder.AddForeignKey(
                name: "FK_Entrenadores_Pokemons_PokemonId",
                table: "Entrenadores",
                column: "PokemonId",
                principalTable: "Pokemons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
