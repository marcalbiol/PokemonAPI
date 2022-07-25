using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PokemonBackend.Migrations
{
    public partial class TablasHabilidades_Tipo_ModeloRelacionalAdd_Habilidad : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Habilidades",
                columns: new[] { "HabilidadId", "Habilidad_1", "Habilidad_2", "Habilidad_3", "Habilidad_4" },
                values: new object[] { 1, "Placaje", "Ascuas", "Llamarada", "Gruñido" });

            migrationBuilder.InsertData(
                table: "Tipos_Habilidades",
                columns: new[] { "HabilidadId", "TipoId" },
                values: new object[] { 1, 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tipos_Habilidades",
                keyColumns: new[] { "HabilidadId", "TipoId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "Habilidades",
                keyColumn: "HabilidadId",
                keyValue: 1);
        }
    }
}
