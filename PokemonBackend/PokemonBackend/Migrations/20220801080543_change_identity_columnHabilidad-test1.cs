using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PokemonBackend.Migrations
{
    public partial class change_identity_columnHabilidadtest1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Tipos_Habilidades",
                columns: new[] { "HabilidadId", "TipoId", "Id" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 2, 2 },
                    { 3, 3, 3 },
                    { 3, 4, 5 },
                    { 4, 4, 4 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tipos_Habilidades",
                keyColumns: new[] { "HabilidadId", "TipoId" },
                keyValues: new object[] { 1, 1 });

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
                keyValues: new object[] { 3, 4 });

            migrationBuilder.DeleteData(
                table: "Tipos_Habilidades",
                keyColumns: new[] { "HabilidadId", "TipoId" },
                keyValues: new object[] { 4, 4 });
        }
    }
}
