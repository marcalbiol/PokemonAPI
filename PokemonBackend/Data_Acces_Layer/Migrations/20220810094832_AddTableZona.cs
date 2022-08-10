using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Acceso_BD.Migrations
{
    public partial class AddTableZona : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ZonaId",
                table: "Pokedex",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Zonas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ZonaID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zonas", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pokedex_ZonaId",
                table: "Pokedex",
                column: "ZonaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pokedex_Zonas_ZonaId",
                table: "Pokedex",
                column: "ZonaId",
                principalTable: "Zonas",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pokedex_Zonas_ZonaId",
                table: "Pokedex");

            migrationBuilder.DropTable(
                name: "Zonas");

            migrationBuilder.DropIndex(
                name: "IX_Pokedex_ZonaId",
                table: "Pokedex");

            migrationBuilder.DropColumn(
                name: "ZonaId",
                table: "Pokedex");
        }
    }
}
