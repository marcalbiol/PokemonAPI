using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PokemonBackend.Migrations
{
    public partial class ManyToManyAdded_pokemons_tipos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tipo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tipo_pokemon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ventaja = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Desventaja = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tipo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tipo_Pokemons",
                columns: table => new
                {
                    PokemonId = table.Column<int>(type: "int", nullable: false),
                    TipoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tipo_Pokemons", x => new { x.TipoId, x.PokemonId });
                    table.ForeignKey(
                        name: "FK_Tipo_Pokemons_Pokemons_PokemonId",
                        column: x => x.PokemonId,
                        principalTable: "Pokemons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tipo_Pokemons_Tipo_TipoId",
                        column: x => x.TipoId,
                        principalTable: "Tipo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tipo_Pokemons_PokemonId",
                table: "Tipo_Pokemons",
                column: "PokemonId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tipo_Pokemons");

            migrationBuilder.DropTable(
                name: "Tipo");
        }
    }
}
