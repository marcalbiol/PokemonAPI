using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PokemonBackend.Migrations
{
    public partial class TablasHabilidades_Tipo_ModeloRelacionalAdd_HabilidadesNuevas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Habilidades",
                columns: new[] { "HabilidadId", "Habilidad_1", "Habilidad_2", "Habilidad_3", "Habilidad_4" },
                values: new object[] { 2, "Placaje", "Pistola Agua", "Surf", "Ataque arena" });

            migrationBuilder.InsertData(
                table: "Habilidades",
                columns: new[] { "HabilidadId", "Habilidad_1", "Habilidad_2", "Habilidad_3", "Habilidad_4" },
                values: new object[] { 3, "Placaje", "Latigo cepa", "Hoja afilada", "Ataque arena" });

            migrationBuilder.InsertData(
                table: "Habilidades",
                columns: new[] { "HabilidadId", "Habilidad_1", "Habilidad_2", "Habilidad_3", "Habilidad_4" },
                values: new object[] { 4, "Placaje", "Impactrueno", "Rayo", "Trueno" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Habilidades",
                keyColumn: "HabilidadId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Habilidades",
                keyColumn: "HabilidadId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Habilidades",
                keyColumn: "HabilidadId",
                keyValue: 4);
        }
    }
}
