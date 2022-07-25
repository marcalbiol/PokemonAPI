using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PokemonBackend.Migrations
{
    public partial class TablasHabilidades_Tipo_ModeloRelacionalAdd_HabilidadesNuevas02 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Tipos_Habilidades",
                columns: new[] { "HabilidadId", "TipoId" },
                values: new object[] { 2, 2 });

            migrationBuilder.InsertData(
                table: "Tipos_Habilidades",
                columns: new[] { "HabilidadId", "TipoId" },
                values: new object[] { 3, 3 });

            migrationBuilder.InsertData(
                table: "Tipos_Habilidades",
                columns: new[] { "HabilidadId", "TipoId" },
                values: new object[] { 4, 4 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tipos_Habilidades",
                keyColumns: new[] { "HabilidadId", "TipoId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "Tipos_Habilidades",
                keyColumns: new[] { "HabilidadId", "TipoId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "Tipos_Habilidades",
                keyColumns: new[] { "HabilidadId", "TipoId" },
                keyValues: new object[] { 4, 4 });
        }
    }
}
