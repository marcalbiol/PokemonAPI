using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PokemonBackend.Migrations
{
    public partial class AddedRelacionStatsPokemonv2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pokemons_Stat_StatId",
                table: "Pokemons");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Stat",
                table: "Stat");

            migrationBuilder.RenameTable(
                name: "Stat",
                newName: "Stats");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Stats",
                table: "Stats",
                column: "Id");

            migrationBuilder.InsertData(
                table: "Stats",
                columns: new[] { "Id", "Ataque", "Defensa", "Nivel", "Vida" },
                values: new object[] { 1, 15, 10, 20, 30 });

            migrationBuilder.AddForeignKey(
                name: "FK_Pokemons_Stats_StatId",
                table: "Pokemons",
                column: "StatId",
                principalTable: "Stats",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pokemons_Stats_StatId",
                table: "Pokemons");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Stats",
                table: "Stats");

            migrationBuilder.DeleteData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.RenameTable(
                name: "Stats",
                newName: "Stat");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Stat",
                table: "Stat",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Pokemons_Stat_StatId",
                table: "Pokemons",
                column: "StatId",
                principalTable: "Stat",
                principalColumn: "Id");
        }
    }
}
