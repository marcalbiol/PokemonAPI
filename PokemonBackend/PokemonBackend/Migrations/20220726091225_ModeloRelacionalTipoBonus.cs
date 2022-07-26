using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PokemonBackend.Migrations
{
    public partial class ModeloRelacionalTipoBonus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tipos",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DropColumn(
                name: "Debil",
                table: "Tipos");

            migrationBuilder.DropColumn(
                name: "Eficaz",
                table: "Tipos");

            migrationBuilder.CreateTable(
                name: "Bonus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Eficaz = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Debil = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bonus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tipo_Bonus",
                columns: table => new
                {
                    TipoId = table.Column<int>(type: "int", nullable: false),
                    BonusId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tipo_Bonus", x => new { x.TipoId, x.BonusId });
                    table.ForeignKey(
                        name: "FK_Tipo_Bonus_Bonus_BonusId",
                        column: x => x.BonusId,
                        principalTable: "Bonus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tipo_Bonus_Tipos_TipoId",
                        column: x => x.TipoId,
                        principalTable: "Tipos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Pokedex",
                keyColumn: "ID",
                keyValue: 1,
                column: "Nombre",
                value: "Bulbasaur ");

            migrationBuilder.CreateIndex(
                name: "IX_Tipo_Bonus_BonusId",
                table: "Tipo_Bonus",
                column: "BonusId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tipo_Bonus");

            migrationBuilder.DropTable(
                name: "Bonus");

            migrationBuilder.AddColumn<string>(
                name: "Debil",
                table: "Tipos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Eficaz",
                table: "Tipos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Pokedex",
                keyColumn: "ID",
                keyValue: 1,
                column: "Nombre",
                value: "Bulbasaur");

            migrationBuilder.UpdateData(
                table: "Tipos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Debil", "Eficaz" },
                values: new object[] { "Agua", "Planta" });

            migrationBuilder.UpdateData(
                table: "Tipos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Debil", "Eficaz" },
                values: new object[] { "Planta", "Fuego" });

            migrationBuilder.UpdateData(
                table: "Tipos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Debil", "Eficaz" },
                values: new object[] { "Fuego", "Agua" });

            migrationBuilder.UpdateData(
                table: "Tipos",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Debil", "Eficaz" },
                values: new object[] { "Dragon", "Agua" });

            migrationBuilder.UpdateData(
                table: "Tipos",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Debil", "Eficaz" },
                values: new object[] { "Acero", "Fuego" });

            migrationBuilder.UpdateData(
                table: "Tipos",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Debil", "Eficaz" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Tipos",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Debil", "Eficaz" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Tipos",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Debil", "Eficaz" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Tipos",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Debil", "Eficaz" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Tipos",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Debil", "Eficaz" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Tipos",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Debil", "Eficaz" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Tipos",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Debil", "Eficaz" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Tipos",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Debil", "Eficaz" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Tipos",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Debil", "Eficaz" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Tipos",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Debil", "Eficaz" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Tipos",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Debil", "Eficaz" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Tipos",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Debil", "Eficaz" },
                values: new object[] { "", "" });

            migrationBuilder.InsertData(
                table: "Tipos",
                columns: new[] { "Id", "Debil", "Eficaz", "Tipo_pokemon" },
                values: new object[] { 15, "", "", "Veneno" });
        }
    }
}
