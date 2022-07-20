using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PokemonBackend.Migrations
{
    public partial class ModeloRelacional : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pokemons_Entrenadores_EntrenadorId",
                table: "Pokemons");

            migrationBuilder.CreateTable(
                name: "Entrenadores_Pokemons",
                columns: table => new
                {
                    EntrenadorId = table.Column<int>(type: "int", nullable: false),
                    PokemonId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entrenadores_Pokemons", x => new { x.EntrenadorId, x.PokemonId });
                    table.ForeignKey(
                        name: "FK_Entrenadores_Pokemons_Entrenadores_EntrenadorId",
                        column: x => x.EntrenadorId,
                        principalTable: "Entrenadores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Entrenadores_Pokemons_Pokemons_PokemonId",
                        column: x => x.PokemonId,
                        principalTable: "Pokemons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Entrenadores_Pokemons_PokemonId",
                table: "Entrenadores_Pokemons",
                column: "PokemonId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pokemons_Entrenadores_EntrenadorId",
                table: "Pokemons",
                column: "EntrenadorId",
                principalTable: "Entrenadores",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pokemons_Entrenadores_EntrenadorId",
                table: "Pokemons");

            migrationBuilder.DropTable(
                name: "Entrenadores_Pokemons");

            migrationBuilder.AddForeignKey(
                name: "FK_Pokemons_Entrenadores_EntrenadorId",
                table: "Pokemons",
                column: "EntrenadorId",
                principalTable: "Entrenadores",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }
    }
}
