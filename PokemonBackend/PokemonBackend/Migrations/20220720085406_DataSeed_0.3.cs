using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PokemonBackend.Migrations
{
    public partial class DataSeed_03 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tipo_Pokemons_Tipo_TipoId",
                table: "Tipo_Pokemons");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tipo",
                table: "Tipo");

            migrationBuilder.RenameTable(
                name: "Tipo",
                newName: "Tipos");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tipos",
                table: "Tipos",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Tipo_Pokemons_Tipos_TipoId",
                table: "Tipo_Pokemons",
                column: "TipoId",
                principalTable: "Tipos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tipo_Pokemons_Tipos_TipoId",
                table: "Tipo_Pokemons");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tipos",
                table: "Tipos");

            migrationBuilder.RenameTable(
                name: "Tipos",
                newName: "Tipo");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tipo",
                table: "Tipo",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Tipo_Pokemons_Tipo_TipoId",
                table: "Tipo_Pokemons",
                column: "TipoId",
                principalTable: "Tipo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
