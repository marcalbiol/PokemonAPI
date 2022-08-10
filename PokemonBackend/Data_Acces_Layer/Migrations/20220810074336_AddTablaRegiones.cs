using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Acceso_BD.Migrations
{
    public partial class AddTablaRegiones : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Regiones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Regiones", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 1,
                column: "Nombre",
                value: null);

            migrationBuilder.InsertData(
                table: "Regiones",
                columns: new[] { "Id", "Nombre" },
                values: new object[,]
                {
                    { 1, "Kanto" },
                    { 2, "Johto" },
                    { 3, "Hoenn" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Regiones");

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 1,
                column: "Nombre",
                value: "test");
        }
    }
}
