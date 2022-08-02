using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Acceso_BD.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 1,
                column: "Nombre",
                value: "test");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 1,
                column: "Nombre",
                value: null);
        }
    }
}
