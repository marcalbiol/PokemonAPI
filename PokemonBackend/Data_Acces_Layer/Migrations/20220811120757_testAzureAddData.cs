using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Acceso_BD.Migrations
{
    public partial class testAzureAddData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Entrenadores",
                columns: new[] { "Id", "Nombre" },
                values: new object[] { 4, "Nicol" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Entrenadores",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
