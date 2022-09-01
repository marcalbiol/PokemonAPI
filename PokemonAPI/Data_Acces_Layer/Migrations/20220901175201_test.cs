using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Acceso_BD.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tipo_Pokemons_Pokemons_PokemonId",
                table: "Tipo_Pokemons");

            migrationBuilder.DropIndex(
                name: "IX_Tipo_Pokemons_PokemonId",
                table: "Tipo_Pokemons");

            migrationBuilder.DropColumn(
                name: "PokemonId",
                table: "Tipo_Pokemons");

            migrationBuilder.CreateTable(
                name: "PokedexTipo",
                columns: table => new
                {
                    PokedexsID = table.Column<int>(type: "int", nullable: false),
                    TiposId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PokedexTipo", x => new { x.PokedexsID, x.TiposId });
                    table.ForeignKey(
                        name: "FK_PokedexTipo_Pokedex_PokedexsID",
                        column: x => x.PokedexsID,
                        principalTable: "Pokedex",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PokedexTipo_Tipos_TiposId",
                        column: x => x.TiposId,
                        principalTable: "Tipos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PokedexTipo_TiposId",
                table: "PokedexTipo",
                column: "TiposId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PokedexTipo");

            migrationBuilder.AddColumn<int>(
                name: "PokemonId",
                table: "Tipo_Pokemons",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tipo_Pokemons_PokemonId",
                table: "Tipo_Pokemons",
                column: "PokemonId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tipo_Pokemons_Pokemons_PokemonId",
                table: "Tipo_Pokemons",
                column: "PokemonId",
                principalTable: "Pokemons",
                principalColumn: "Id");
        }
    }
}
