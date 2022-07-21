using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PokemonBackend.Migrations
{
    public partial class AddedRelacion_TipoPokemon_Habilidadesv1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "habilidades_Agua",
                columns: table => new
                {
                    AguaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Habilidad_1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Habilidad_2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Habilidad_3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Habilidad_4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TipoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_habilidades_Agua", x => x.AguaId);
                    table.ForeignKey(
                        name: "FK_habilidades_Agua_Tipos_TipoId",
                        column: x => x.TipoId,
                        principalTable: "Tipos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "habilidades_Fuego",
                columns: table => new
                {
                    FuegoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Habilidad_1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Habilidad_2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Habilidad_3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Habilidad_4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TipoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_habilidades_Fuego", x => x.FuegoId);
                    table.ForeignKey(
                        name: "FK_habilidades_Fuego_Tipos_TipoId",
                        column: x => x.TipoId,
                        principalTable: "Tipos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_habilidades_Agua_TipoId",
                table: "habilidades_Agua",
                column: "TipoId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_habilidades_Fuego_TipoId",
                table: "habilidades_Fuego",
                column: "TipoId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "habilidades_Agua");

            migrationBuilder.DropTable(
                name: "habilidades_Fuego");
        }
    }
}
