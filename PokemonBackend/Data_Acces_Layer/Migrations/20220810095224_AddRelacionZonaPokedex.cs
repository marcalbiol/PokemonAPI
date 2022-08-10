using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Acceso_BD.Migrations
{
    public partial class AddRelacionZonaPokedex : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ZonaID",
                table: "Zonas");

            migrationBuilder.AddColumn<string>(
                name: "NombreZona",
                table: "Zonas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Zonas",
                columns: new[] { "Id", "NombreZona" },
                values: new object[] { 1, "Inicio" });

            migrationBuilder.InsertData(
                table: "Zonas",
                columns: new[] { "Id", "NombreZona" },
                values: new object[] { 2, "Inicio2" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Zonas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Zonas",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DropColumn(
                name: "NombreZona",
                table: "Zonas");

            migrationBuilder.AddColumn<int>(
                name: "ZonaID",
                table: "Zonas",
                type: "int",
                nullable: true);
        }
    }
}
