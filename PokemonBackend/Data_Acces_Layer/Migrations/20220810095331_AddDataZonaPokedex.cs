using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Acceso_BD.Migrations
{
    public partial class AddDataZonaPokedex : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Pokedex",
                keyColumn: "ID",
                keyValue: 10,
                column: "ZonaId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Pokedex",
                keyColumn: "ID",
                keyValue: 13,
                column: "ZonaId",
                value: 2);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Pokedex",
                keyColumn: "ID",
                keyValue: 10,
                column: "ZonaId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Pokedex",
                keyColumn: "ID",
                keyValue: 13,
                column: "ZonaId",
                value: null);
        }
    }
}
