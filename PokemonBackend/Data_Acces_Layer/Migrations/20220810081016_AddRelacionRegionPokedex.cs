using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Acceso_BD.Migrations
{
    public partial class AddRelacionRegionPokedex : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Regiones",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Regiones",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Regiones",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "Regiones",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "RegionId",
                table: "Pokedex",
                type: "int",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Regiones",
                columns: new[] { "Id", "Nombre" },
                values: new object[] { 1, "Kanto" });

            migrationBuilder.InsertData(
                table: "Regiones",
                columns: new[] { "Id", "Nombre" },
                values: new object[] { 2, "Johto" });

            migrationBuilder.InsertData(
                table: "Regiones",
                columns: new[] { "Id", "Nombre" },
                values: new object[] { 3, "Hoenn" });

            migrationBuilder.CreateIndex(
                name: "IX_Pokedex_RegionId",
                table: "Pokedex",
                column: "RegionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pokedex_Regiones_RegionId",
                table: "Pokedex",
                column: "RegionId",
                principalTable: "Regiones",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pokedex_Regiones_RegionId",
                table: "Pokedex");

            migrationBuilder.DropIndex(
                name: "IX_Pokedex_RegionId",
                table: "Pokedex");

            migrationBuilder.DeleteData(
                table: "Regiones",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Regiones",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Regiones",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "RegionId",
                table: "Pokedex");

            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "Regiones",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Regiones",
                columns: new[] { "Id", "Nombre" },
                values: new object[] { 1, "Kanto" });

            migrationBuilder.InsertData(
                table: "Regiones",
                columns: new[] { "Id", "Nombre" },
                values: new object[] { 2, "Johto" });

            migrationBuilder.InsertData(
                table: "Regiones",
                columns: new[] { "Id", "Nombre" },
                values: new object[] { 3, "Hoenn" });
        }
    }
}
