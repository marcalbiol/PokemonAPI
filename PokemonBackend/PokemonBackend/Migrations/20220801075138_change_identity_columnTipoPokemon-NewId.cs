using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PokemonBackend.Migrations
{
    public partial class change_identity_columnTipoPokemonNewId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tipo_Pokemons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipoId = table.Column<int>(type: "int", nullable: false),
                    PokedexId = table.Column<int>(type: "int", nullable: true),
                    PokemonId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tipo_Pokemons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tipo_Pokemons_Pokedex_PokedexId",
                        column: x => x.PokedexId,
                        principalTable: "Pokedex",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Tipo_Pokemons_Pokemons_PokemonId",
                        column: x => x.PokemonId,
                        principalTable: "Pokemons",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Tipo_Pokemons_Tipos_TipoId",
                        column: x => x.TipoId,
                        principalTable: "Tipos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tipo_Pokemons_PokedexId",
                table: "Tipo_Pokemons",
                column: "PokedexId");

            migrationBuilder.CreateIndex(
                name: "IX_Tipo_Pokemons_PokemonId",
                table: "Tipo_Pokemons",
                column: "PokemonId");

            migrationBuilder.CreateIndex(
                name: "IX_Tipo_Pokemons_TipoId",
                table: "Tipo_Pokemons",
                column: "TipoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tipo_Pokemons");
        }
    }
}
