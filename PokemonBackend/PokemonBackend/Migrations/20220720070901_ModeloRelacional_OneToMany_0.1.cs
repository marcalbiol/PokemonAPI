using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PokemonBackend.Migrations
{
    public partial class ModeloRelacional_OneToMany_01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Entrenadores_pokemons");

            migrationBuilder.DropColumn(
                name: "Tipo",
                table: "Pokemons");

            migrationBuilder.DropColumn(
                name: "Derrotas",
                table: "Entrenadores");

            migrationBuilder.DropColumn(
                name: "Victorias",
                table: "Entrenadores");

            migrationBuilder.AddColumn<int>(
                name: "EntrenadorId",
                table: "Pokemons",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Pokemons_EntrenadorId",
                table: "Pokemons",
                column: "EntrenadorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pokemons_Entrenadores_EntrenadorId",
                table: "Pokemons",
                column: "EntrenadorId",
                principalTable: "Entrenadores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "Tipo",
                table: "Pokemons",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Derrotas",
                table: "Entrenadores",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Victorias",
                table: "Entrenadores",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Entrenadores_pokemons",
                columns: table => new
                {
                    EntrenadorId = table.Column<int>(type: "int", nullable: false),
                    PokemonId = table.Column<int>(type: "int", nullable: false),
                    Entrenador_PokemonEntrenadorId = table.Column<int>(type: "int", nullable: true),
                    Entrenador_PokemonPokemonId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entrenadores_pokemons", x => new { x.EntrenadorId, x.PokemonId });
                    table.ForeignKey(
                        name: "FK_Entrenadores_pokemons_Entrenadores_EntrenadorId",
                        column: x => x.EntrenadorId,
                        principalTable: "Entrenadores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Entrenadores_pokemons_Entrenadores_pokemons_Entrenador_PokemonEntrenadorId_Entrenador_PokemonPokemonId",
                        columns: x => new { x.Entrenador_PokemonEntrenadorId, x.Entrenador_PokemonPokemonId },
                        principalTable: "Entrenadores_pokemons",
                        principalColumns: new[] { "EntrenadorId", "PokemonId" });
                    table.ForeignKey(
                        name: "FK_Entrenadores_pokemons_Pokemons_PokemonId",
                        column: x => x.PokemonId,
                        principalTable: "Pokemons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Entrenadores_pokemons_Entrenador_PokemonEntrenadorId_Entrenador_PokemonPokemonId",
                table: "Entrenadores_pokemons",
                columns: new[] { "Entrenador_PokemonEntrenadorId", "Entrenador_PokemonPokemonId" });

            migrationBuilder.CreateIndex(
                name: "IX_Entrenadores_pokemons_PokemonId",
                table: "Entrenadores_pokemons",
                column: "PokemonId");
        }
    }
}
