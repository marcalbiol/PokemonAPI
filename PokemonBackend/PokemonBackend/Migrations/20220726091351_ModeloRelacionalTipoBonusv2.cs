using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PokemonBackend.Migrations
{
    public partial class ModeloRelacionalTipoBonusv2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tipo_Bonus_Bonus_BonusId",
                table: "Tipo_Bonus");

            migrationBuilder.DropForeignKey(
                name: "FK_Tipo_Bonus_Tipos_TipoId",
                table: "Tipo_Bonus");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tipo_Bonus",
                table: "Tipo_Bonus");

            migrationBuilder.RenameTable(
                name: "Tipo_Bonus",
                newName: "Tipos_Bonus");

            migrationBuilder.RenameIndex(
                name: "IX_Tipo_Bonus_BonusId",
                table: "Tipos_Bonus",
                newName: "IX_Tipos_Bonus_BonusId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tipos_Bonus",
                table: "Tipos_Bonus",
                columns: new[] { "TipoId", "BonusId" });

            migrationBuilder.AddForeignKey(
                name: "FK_Tipos_Bonus_Bonus_BonusId",
                table: "Tipos_Bonus",
                column: "BonusId",
                principalTable: "Bonus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tipos_Bonus_Tipos_TipoId",
                table: "Tipos_Bonus",
                column: "TipoId",
                principalTable: "Tipos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tipos_Bonus_Bonus_BonusId",
                table: "Tipos_Bonus");

            migrationBuilder.DropForeignKey(
                name: "FK_Tipos_Bonus_Tipos_TipoId",
                table: "Tipos_Bonus");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tipos_Bonus",
                table: "Tipos_Bonus");

            migrationBuilder.RenameTable(
                name: "Tipos_Bonus",
                newName: "Tipo_Bonus");

            migrationBuilder.RenameIndex(
                name: "IX_Tipos_Bonus_BonusId",
                table: "Tipo_Bonus",
                newName: "IX_Tipo_Bonus_BonusId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tipo_Bonus",
                table: "Tipo_Bonus",
                columns: new[] { "TipoId", "BonusId" });

            migrationBuilder.AddForeignKey(
                name: "FK_Tipo_Bonus_Bonus_BonusId",
                table: "Tipo_Bonus",
                column: "BonusId",
                principalTable: "Bonus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tipo_Bonus_Tipos_TipoId",
                table: "Tipo_Bonus",
                column: "TipoId",
                principalTable: "Tipos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
