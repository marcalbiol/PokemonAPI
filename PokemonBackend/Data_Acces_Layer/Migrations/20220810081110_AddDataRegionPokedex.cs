using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Acceso_BD.Migrations
{
    public partial class AddDataRegionPokedex : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Pokedex",
                keyColumn: "ID",
                keyValue: 1,
                column: "RegionId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Pokedex",
                keyColumn: "ID",
                keyValue: 2,
                column: "RegionId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Pokedex",
                keyColumn: "ID",
                keyValue: 3,
                column: "RegionId",
                value: 2);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Pokedex",
                keyColumn: "ID",
                keyValue: 1,
                column: "RegionId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Pokedex",
                keyColumn: "ID",
                keyValue: 2,
                column: "RegionId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Pokedex",
                keyColumn: "ID",
                keyValue: 3,
                column: "RegionId",
                value: null);
        }
    }
}
