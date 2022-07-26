using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PokemonBackend.Migrations
{
    public partial class TablaPokedexAddRelaciones_v2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pokedex_Stats_StatId",
                table: "Pokedex");

            migrationBuilder.AddForeignKey(
                name: "FK_Pokedex_Stats_StatId",
                table: "Pokedex",
                column: "StatId",
                principalTable: "Stats",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pokedex_Stats_StatId",
                table: "Pokedex");

            migrationBuilder.AddForeignKey(
                name: "FK_Pokedex_Stats_StatId",
                table: "Pokedex",
                column: "StatId",
                principalTable: "Stats",
                principalColumn: "Id");
        }
    }
}
