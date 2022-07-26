using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PokemonBackend.Migrations
{
    public partial class ModeloRelacionalTipoBonusv3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Debil",
                table: "Bonus");

            migrationBuilder.DropColumn(
                name: "Eficaz",
                table: "Bonus");

            migrationBuilder.AddColumn<string>(
                name: "Debil",
                table: "Tipos_Bonus",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Eficaz",
                table: "Tipos_Bonus",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Debil",
                table: "Tipos_Bonus");

            migrationBuilder.DropColumn(
                name: "Eficaz",
                table: "Tipos_Bonus");

            migrationBuilder.AddColumn<string>(
                name: "Debil",
                table: "Bonus",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Eficaz",
                table: "Bonus",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
