using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Acceso_BD.Migrations
{
    public partial class test1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pokedex_Regiones_RegionId",
                table: "Pokedex");

            migrationBuilder.DropForeignKey(
                name: "FK_Pokedex_Tiers_TierId",
                table: "Pokedex");

            migrationBuilder.DropForeignKey(
                name: "FK_Pokemons_Pokedex_PokedexId",
                table: "Pokemons");

            migrationBuilder.AddForeignKey(
                name: "FK_Pokedex_Regiones_RegionId",
                table: "Pokedex",
                column: "RegionId",
                principalTable: "Regiones",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Pokedex_Tiers_TierId",
                table: "Pokedex",
                column: "TierId",
                principalTable: "Tiers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Pokemons_Pokedex_PokedexId",
                table: "Pokemons",
                column: "PokedexId",
                principalTable: "Pokedex",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pokedex_Regiones_RegionId",
                table: "Pokedex");

            migrationBuilder.DropForeignKey(
                name: "FK_Pokedex_Tiers_TierId",
                table: "Pokedex");

            migrationBuilder.DropForeignKey(
                name: "FK_Pokemons_Pokedex_PokedexId",
                table: "Pokemons");

            migrationBuilder.AddForeignKey(
                name: "FK_Pokedex_Regiones_RegionId",
                table: "Pokedex",
                column: "RegionId",
                principalTable: "Regiones",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Pokedex_Tiers_TierId",
                table: "Pokedex",
                column: "TierId",
                principalTable: "Tiers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Pokemons_Pokedex_PokedexId",
                table: "Pokemons",
                column: "PokedexId",
                principalTable: "Pokedex",
                principalColumn: "ID");
        }
    }
}
