using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PokemonBackend.Migrations
{
    public partial class DataSeed_01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pokemons_Entrenadores_EntrenadorId",
                table: "Pokemons");

            migrationBuilder.DropForeignKey(
                name: "FK_Pokemons_Tipo_TipoId",
                table: "Pokemons");

            migrationBuilder.DropIndex(
                name: "IX_Pokemons_TipoId",
                table: "Pokemons");

            migrationBuilder.DropColumn(
                name: "TipoId",
                table: "Pokemons");

            migrationBuilder.AlterColumn<int>(
                name: "EntrenadorId",
                table: "Pokemons",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "Pokemons",
                columns: new[] { "Id", "Ataque", "Defensa", "EntrenadorId", "Nivel", "Nombre", "Vida" },
                values: new object[] { 1, null, null, null, null, null, null });

            migrationBuilder.InsertData(
                table: "Tipo",
                columns: new[] { "Id", "Desventaja", "Tipo_pokemon", "Ventaja" },
                values: new object[,]
                {
                    { 1, "Agua", "Fuego", "Planta" },
                    { 2, "Planta", "Agua", "Fuego" },
                    { 3, "Fuego", "Planta", "Agua" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Pokemons_Entrenadores_EntrenadorId",
                table: "Pokemons",
                column: "EntrenadorId",
                principalTable: "Entrenadores",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pokemons_Entrenadores_EntrenadorId",
                table: "Pokemons");

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tipo",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tipo",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Tipo",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.AlterColumn<int>(
                name: "EntrenadorId",
                table: "Pokemons",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TipoId",
                table: "Pokemons",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pokemons_TipoId",
                table: "Pokemons",
                column: "TipoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pokemons_Entrenadores_EntrenadorId",
                table: "Pokemons",
                column: "EntrenadorId",
                principalTable: "Entrenadores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Pokemons_Tipo_TipoId",
                table: "Pokemons",
                column: "TipoId",
                principalTable: "Tipo",
                principalColumn: "Id");
        }
    }
}
