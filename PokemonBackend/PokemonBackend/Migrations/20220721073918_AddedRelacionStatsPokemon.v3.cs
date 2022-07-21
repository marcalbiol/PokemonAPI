using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PokemonBackend.Migrations
{
    public partial class AddedRelacionStatsPokemonv3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pokemons_Stats_StatId",
                table: "Pokemons");

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 1,
                column: "StatId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 1,
                column: "Vida",
                value: 40);

            migrationBuilder.AddForeignKey(
                name: "FK_Pokemons_Stats_StatId",
                table: "Pokemons",
                column: "StatId",
                principalTable: "Stats",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pokemons_Stats_StatId",
                table: "Pokemons");

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 1,
                column: "StatId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 1,
                column: "Vida",
                value: 30);

            migrationBuilder.AddForeignKey(
                name: "FK_Pokemons_Stats_StatId",
                table: "Pokemons",
                column: "StatId",
                principalTable: "Stats",
                principalColumn: "Id");
        }
    }
}
