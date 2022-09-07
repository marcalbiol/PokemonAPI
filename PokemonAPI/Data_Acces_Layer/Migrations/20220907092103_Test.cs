using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Acceso_BD.Migrations
{
    public partial class Test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Zonas",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageURL",
                value: "https://i.pinimg.com/736x/d6/7c/3c/d67c3cbce4d7e9355e8522e10434d76c.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Zonas",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageURL",
                value: null);
        }
    }
}
