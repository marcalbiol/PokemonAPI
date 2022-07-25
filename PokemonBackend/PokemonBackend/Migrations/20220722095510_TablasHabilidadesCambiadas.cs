using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PokemonBackend.Migrations
{
    public partial class TablasHabilidadesCambiadas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HabilidadesAgua");

            migrationBuilder.DropTable(
                name: "HabilidadesFuego");

            migrationBuilder.CreateTable(
                name: "Habilidades",
                columns: table => new
                {
                    HabilidadId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Habilidad_1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Habilidad_2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Habilidad_3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Habilidad_4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TipoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Habilidades", x => x.HabilidadId);
                    table.ForeignKey(
                        name: "FK_Habilidades_Tipos_TipoId",
                        column: x => x.TipoId,
                        principalTable: "Tipos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Habilidades_TipoId",
                table: "Habilidades",
                column: "TipoId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Habilidades");

            migrationBuilder.CreateTable(
                name: "HabilidadesAgua",
                columns: table => new
                {
                    AguaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipoId = table.Column<int>(type: "int", nullable: false),
                    Habilidad_1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Habilidad_2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Habilidad_3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Habilidad_4 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HabilidadesAgua", x => x.AguaId);
                    table.ForeignKey(
                        name: "FK_HabilidadesAgua_Tipos_TipoId",
                        column: x => x.TipoId,
                        principalTable: "Tipos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HabilidadesFuego",
                columns: table => new
                {
                    FuegoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipoId = table.Column<int>(type: "int", nullable: false),
                    Habilidad_1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Habilidad_2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Habilidad_3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Habilidad_4 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HabilidadesFuego", x => x.FuegoId);
                    table.ForeignKey(
                        name: "FK_HabilidadesFuego_Tipos_TipoId",
                        column: x => x.TipoId,
                        principalTable: "Tipos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HabilidadesAgua_TipoId",
                table: "HabilidadesAgua",
                column: "TipoId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_HabilidadesFuego_TipoId",
                table: "HabilidadesFuego",
                column: "TipoId",
                unique: true);
        }
    }
}
