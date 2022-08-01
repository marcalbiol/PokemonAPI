using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PokemonBackend.Migrations
{
    public partial class change_identity_columnEntrenadorTest1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Entrenadores_Pokemons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EntrenadorId = table.Column<int>(type: "int", nullable: true),
                    PokemonId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entrenadores_Pokemons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Entrenadores_Pokemons_Entrenadores_EntrenadorId",
                        column: x => x.EntrenadorId,
                        principalTable: "Entrenadores",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Entrenadores_Pokemons_Pokemons_PokemonId",
                        column: x => x.PokemonId,
                        principalTable: "Pokemons",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Entrenadores_Pokemons",
                columns: new[] { "Id", "EntrenadorId", "PokemonId" },
                values: new object[] { 1, 1, 5 });

            migrationBuilder.InsertData(
                table: "Entrenadores_Pokemons",
                columns: new[] { "Id", "EntrenadorId", "PokemonId" },
                values: new object[] { 2, 2, 1 });

            migrationBuilder.InsertData(
                table: "Entrenadores_Pokemons",
                columns: new[] { "Id", "EntrenadorId", "PokemonId" },
                values: new object[] { 3, 2, 1 });

            migrationBuilder.CreateIndex(
                name: "IX_Entrenadores_Pokemons_EntrenadorId",
                table: "Entrenadores_Pokemons",
                column: "EntrenadorId");

            migrationBuilder.CreateIndex(
                name: "IX_Entrenadores_Pokemons_PokemonId",
                table: "Entrenadores_Pokemons",
                column: "PokemonId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Entrenadores_Pokemons");
        }
    }
}
