using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Acceso_BD.Migrations
{
    public partial class editZonaTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pokedex_Zonas_ZonaId",
                table: "Pokedex");

            migrationBuilder.AddForeignKey(
                name: "FK_Pokedex_Zonas_ZonaId",
                table: "Pokedex",
                column: "ZonaId",
                principalTable: "Zonas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pokedex_Zonas_ZonaId",
                table: "Pokedex");

            migrationBuilder.AddForeignKey(
                name: "FK_Pokedex_Zonas_ZonaId",
                table: "Pokedex",
                column: "ZonaId",
                principalTable: "Zonas",
                principalColumn: "Id");
        }
    }
}
