using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Acceso_BD.Migrations
{
    public partial class AddTier : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Pokedex",
                keyColumn: "ID",
                keyValue: 3,
                column: "TierId",
                value: 4);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Pokedex",
                keyColumn: "ID",
                keyValue: 3,
                column: "TierId",
                value: 5);
        }
    }
}
