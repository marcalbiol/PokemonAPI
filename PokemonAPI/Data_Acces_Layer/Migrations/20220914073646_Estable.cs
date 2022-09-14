using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Acceso_BD.Migrations
{
    public partial class Estable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Entrenadores_Pokemons_Entrenadores_EntrenadorId",
                table: "Entrenadores_Pokemons");

            migrationBuilder.DropForeignKey(
                name: "FK_Entrenadores_Pokemons_Pokemons_PokemonId",
                table: "Entrenadores_Pokemons");

            migrationBuilder.DropForeignKey(
                name: "FK_Tipos_Habilidades_Habilidades_HabilidadId",
                table: "Tipos_Habilidades");

            migrationBuilder.DropForeignKey(
                name: "FK_Tipos_Habilidades_Tipos_TipoId",
                table: "Tipos_Habilidades");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tipos_Habilidades",
                table: "Tipos_Habilidades");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Entrenadores_Pokemons",
                table: "Entrenadores_Pokemons");

            migrationBuilder.RenameTable(
                name: "Tipos_Habilidades",
                newName: "TiposHabilidades");

            migrationBuilder.RenameTable(
                name: "Entrenadores_Pokemons",
                newName: "EntrenadoresPokemons");

            migrationBuilder.RenameIndex(
                name: "IX_Tipos_Habilidades_HabilidadId",
                table: "TiposHabilidades",
                newName: "IX_TiposHabilidades_HabilidadId");

            migrationBuilder.RenameIndex(
                name: "IX_Entrenadores_Pokemons_PokemonId",
                table: "EntrenadoresPokemons",
                newName: "IX_EntrenadoresPokemons_PokemonId");

            migrationBuilder.RenameIndex(
                name: "IX_Entrenadores_Pokemons_EntrenadorId",
                table: "EntrenadoresPokemons",
                newName: "IX_EntrenadoresPokemons_EntrenadorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TiposHabilidades",
                table: "TiposHabilidades",
                columns: new[] { "TipoId", "HabilidadId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_EntrenadoresPokemons",
                table: "EntrenadoresPokemons",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_EntrenadoresPokemons_Entrenadores_EntrenadorId",
                table: "EntrenadoresPokemons",
                column: "EntrenadorId",
                principalTable: "Entrenadores",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_EntrenadoresPokemons_Pokemons_PokemonId",
                table: "EntrenadoresPokemons",
                column: "PokemonId",
                principalTable: "Pokemons",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TiposHabilidades_Habilidades_HabilidadId",
                table: "TiposHabilidades",
                column: "HabilidadId",
                principalTable: "Habilidades",
                principalColumn: "HabilidadId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TiposHabilidades_Tipos_TipoId",
                table: "TiposHabilidades",
                column: "TipoId",
                principalTable: "Tipos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EntrenadoresPokemons_Entrenadores_EntrenadorId",
                table: "EntrenadoresPokemons");

            migrationBuilder.DropForeignKey(
                name: "FK_EntrenadoresPokemons_Pokemons_PokemonId",
                table: "EntrenadoresPokemons");

            migrationBuilder.DropForeignKey(
                name: "FK_TiposHabilidades_Habilidades_HabilidadId",
                table: "TiposHabilidades");

            migrationBuilder.DropForeignKey(
                name: "FK_TiposHabilidades_Tipos_TipoId",
                table: "TiposHabilidades");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TiposHabilidades",
                table: "TiposHabilidades");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EntrenadoresPokemons",
                table: "EntrenadoresPokemons");

            migrationBuilder.RenameTable(
                name: "TiposHabilidades",
                newName: "Tipos_Habilidades");

            migrationBuilder.RenameTable(
                name: "EntrenadoresPokemons",
                newName: "Entrenadores_Pokemons");

            migrationBuilder.RenameIndex(
                name: "IX_TiposHabilidades_HabilidadId",
                table: "Tipos_Habilidades",
                newName: "IX_Tipos_Habilidades_HabilidadId");

            migrationBuilder.RenameIndex(
                name: "IX_EntrenadoresPokemons_PokemonId",
                table: "Entrenadores_Pokemons",
                newName: "IX_Entrenadores_Pokemons_PokemonId");

            migrationBuilder.RenameIndex(
                name: "IX_EntrenadoresPokemons_EntrenadorId",
                table: "Entrenadores_Pokemons",
                newName: "IX_Entrenadores_Pokemons_EntrenadorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tipos_Habilidades",
                table: "Tipos_Habilidades",
                columns: new[] { "TipoId", "HabilidadId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Entrenadores_Pokemons",
                table: "Entrenadores_Pokemons",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Entrenadores_Pokemons_Entrenadores_EntrenadorId",
                table: "Entrenadores_Pokemons",
                column: "EntrenadorId",
                principalTable: "Entrenadores",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Entrenadores_Pokemons_Pokemons_PokemonId",
                table: "Entrenadores_Pokemons",
                column: "PokemonId",
                principalTable: "Pokemons",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Tipos_Habilidades_Habilidades_HabilidadId",
                table: "Tipos_Habilidades",
                column: "HabilidadId",
                principalTable: "Habilidades",
                principalColumn: "HabilidadId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tipos_Habilidades_Tipos_TipoId",
                table: "Tipos_Habilidades",
                column: "TipoId",
                principalTable: "Tipos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
