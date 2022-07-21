using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PokemonBackend.Migrations
{
    public partial class AddedRelacion_TipoPokemon_Habilidadesv2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_habilidades_Agua_Tipos_TipoId",
                table: "habilidades_Agua");

            migrationBuilder.DropForeignKey(
                name: "FK_habilidades_Fuego_Tipos_TipoId",
                table: "habilidades_Fuego");

            migrationBuilder.DropPrimaryKey(
                name: "PK_habilidades_Fuego",
                table: "habilidades_Fuego");

            migrationBuilder.DropPrimaryKey(
                name: "PK_habilidades_Agua",
                table: "habilidades_Agua");

            migrationBuilder.RenameTable(
                name: "habilidades_Fuego",
                newName: "Habilidades_Fuego");

            migrationBuilder.RenameTable(
                name: "habilidades_Agua",
                newName: "Habilidades_Agua");

            migrationBuilder.RenameIndex(
                name: "IX_habilidades_Fuego_TipoId",
                table: "Habilidades_Fuego",
                newName: "IX_Habilidades_Fuego_TipoId");

            migrationBuilder.RenameIndex(
                name: "IX_habilidades_Agua_TipoId",
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                newName: "habilidades_Fuego");

            migrationBuilder.RenameTable(
                name: "Habilidades_Agua",
                newName: "habilidades_Agua");

            migrationBuilder.RenameIndex(
                name: "IX_Habilidades_Fuego_TipoId",
                table: "habilidades_Fuego",
                newName: "IX_habilidades_Fuego_TipoId");

            migrationBuilder.RenameIndex(
                name: "IX_Habilidades_Agua_TipoId",
                table: "habilidades_Agua",
                newName: "IX_habilidades_Agua_TipoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_habilidades_Fuego",
                table: "habilidades_Fuego",
                column: "FuegoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_habilidades_Agua",
                table: "habilidades_Agua",
                column: "AguaId");

            migrationBuilder.AddForeignKey(
                name: "FK_habilidades_Agua_Tipos_TipoId",
                table: "habilidades_Agua",
                column: "TipoId",
                principalTable: "Tipos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_habilidades_Fuego_Tipos_TipoId",
                table: "habilidades_Fuego",
                column: "TipoId",
                principalTable: "Tipos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
