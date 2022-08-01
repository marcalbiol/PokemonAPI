using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PokemonBackend.Migrations
{
    public partial class change_identity_columnEntrenador : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Entrenadores_Pokemons");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Entrenadores_Pokemons",
                columns: table => new
                {
                    EntrenadorId = table.Column<int>(type: "int", nullable: false),
                    PokemonId = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false)
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

            migrationBuilder.InsertData(
                table: "Entrenadores_Pokemons",
                columns: new[] { "EntrenadorId", "PokemonId", "Id" },
                values: new object[] { 1, 5, 0 });

            migrationBuilder.InsertData(
                table: "Entrenadores_Pokemons",
                columns: new[] { "EntrenadorId", "PokemonId", "Id" },
                values: new object[] { 2, 1, 0 });

            migrationBuilder.CreateIndex(
                name: "IX_Entrenadores_Pokemons_PokemonId",
                table: "Entrenadores_Pokemons",
                column: "PokemonId");
        }
    }
}
