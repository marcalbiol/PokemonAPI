using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PokemonBackend.Migrations
{
    public partial class AddedRelacion_TipoPokemon_Habilidadesv3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Habilidades_Agua_Tipos_TipoId",
                table: "Habilidades_Agua");

            migrationBuilder.DropForeignKey(
                name: "FK_Habilidades_Fuego_Tipos_TipoId",
                table: "Habilidades_Fuego");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Habilidades_Fuego",
                table: "Habilidades_Fuego");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Habilidades_Agua",
                table: "Habilidades_Agua");

            migrationBuilder.RenameTable(
                name: "Habilidades_Fuego",
                newName: "HabilidadesFuego");

            migrationBuilder.RenameTable(
                name: "Habilidades_Agua",
                newName: "HabilidadesAgua");

            migrationBuilder.RenameIndex(
                name: "IX_Habilidades_Fuego_TipoId",
                table: "HabilidadesFuego",
                newName: "IX_HabilidadesFuego_TipoId");

            migrationBuilder.RenameIndex(
                name: "IX_Habilidades_Agua_TipoId",
                table: "HabilidadesAgua",
                newName: "IX_HabilidadesAgua_TipoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HabilidadesFuego",
                table: "HabilidadesFuego",
                column: "FuegoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HabilidadesAgua",
                table: "HabilidadesAgua",
                column: "AguaId");

            migrationBuilder.AddForeignKey(
                name: "FK_HabilidadesAgua_Tipos_TipoId",
                table: "HabilidadesAgua",
                column: "TipoId",
                principalTable: "Tipos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HabilidadesFuego_Tipos_TipoId",
                table: "HabilidadesFuego",
                column: "TipoId",
                principalTable: "Tipos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HabilidadesAgua_Tipos_TipoId",
                table: "HabilidadesAgua");

            migrationBuilder.DropForeignKey(
                name: "FK_HabilidadesFuego_Tipos_TipoId",
                table: "HabilidadesFuego");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HabilidadesFuego",
                table: "HabilidadesFuego");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HabilidadesAgua",
                table: "HabilidadesAgua");

            migrationBuilder.RenameTable(
                name: "HabilidadesFuego",
                newName: "Habilidades_Fuego");

            migrationBuilder.RenameTable(
                name: "HabilidadesAgua",
                newName: "Habilidades_Agua");

            migrationBuilder.RenameIndex(
                name: "IX_HabilidadesFuego_TipoId",
                table: "Habilidades_Fuego",
                newName: "IX_Habilidades_Fuego_TipoId");

            migrationBuilder.RenameIndex(
                name: "IX_HabilidadesAgua_TipoId",
                table: "Habilidades_Agua",
                newName: "IX_Habilidades_Agua_TipoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Habilidades_Fuego",
                table: "Habilidades_Fuego",
                column: "FuegoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Habilidades_Agua",
                table: "Habilidades_Agua",
                column: "AguaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Habilidades_Agua_Tipos_TipoId",
                table: "Habilidades_Agua",
                column: "TipoId",
                principalTable: "Tipos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Habilidades_Fuego_Tipos_TipoId",
                table: "Habilidades_Fuego",
                column: "TipoId",
                principalTable: "Tipos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
