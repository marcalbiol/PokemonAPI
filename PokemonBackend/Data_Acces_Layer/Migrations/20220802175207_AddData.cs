using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Acceso_BD.Migrations
{
    public partial class AddData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Debilidades_Tipo_IdTipo",
                table: "Debilidades");

            migrationBuilder.DropForeignKey(
                name: "FK_Entrenadores_Pokemon_Entrenador_EntrenadorId",
                table: "Entrenadores_Pokemon");

            migrationBuilder.DropForeignKey(
                name: "FK_Entrenadores_Pokemon_Pokemon_PokemonId",
                table: "Entrenadores_Pokemon");

            migrationBuilder.DropForeignKey(
                name: "FK_Fortalezas_Tipo_IdTipo",
                table: "Fortalezas");

            migrationBuilder.DropForeignKey(
                name: "FK_ModificadorTipo_Tipo_BonusId",
                table: "ModificadorTipo");

            migrationBuilder.DropForeignKey(
                name: "FK_Pokedex_Stat_StatId",
                table: "Pokedex");

            migrationBuilder.DropForeignKey(
                name: "FK_Pokemon_Pokedex_PokedexId",
                table: "Pokemon");

            migrationBuilder.DropForeignKey(
                name: "FK_Pokemon_Stat_StatId",
                table: "Pokemon");

            migrationBuilder.DropForeignKey(
                name: "FK_TipoBonus_Tipo_DebilidadId",
                table: "TipoBonus");

            migrationBuilder.DropForeignKey(
                name: "FK_TipoBonus_Tipo_EficazId",
                table: "TipoBonus");

            migrationBuilder.DropForeignKey(
                name: "FK_Tipos_Habilidades_Tipo_TipoId",
                table: "Tipos_Habilidades");

            migrationBuilder.DropForeignKey(
                name: "FK_Tipos_Pokemons_Pokedex_PokedexId",
                table: "Tipos_Pokemons");

            migrationBuilder.DropForeignKey(
                name: "FK_Tipos_Pokemons_Pokemon_PokemonId",
                table: "Tipos_Pokemons");

            migrationBuilder.DropForeignKey(
                name: "FK_Tipos_Pokemons_Tipo_TipoId",
                table: "Tipos_Pokemons");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tipos_Pokemons",
                table: "Tipos_Pokemons");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_TipoBonus_EficazId_DebilidadId_IdTipo",
                table: "TipoBonus");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TipoBonus",
                table: "TipoBonus");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tipo",
                table: "Tipo");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Stat",
                table: "Stat");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Pokemon",
                table: "Pokemon");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ModificadorTipo",
                table: "ModificadorTipo");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Entrenadores_Pokemon",
                table: "Entrenadores_Pokemon");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Entrenador",
                table: "Entrenador");

            migrationBuilder.RenameTable(
                name: "Tipos_Pokemons",
                newName: "Tipo_Pokemons");

            migrationBuilder.RenameTable(
                name: "TipoBonus",
                newName: "Bonuses");

            migrationBuilder.RenameTable(
                name: "Tipo",
                newName: "Tipos");

            migrationBuilder.RenameTable(
                name: "Stat",
                newName: "Stats");

            migrationBuilder.RenameTable(
                name: "Pokemon",
                newName: "Pokemons");

            migrationBuilder.RenameTable(
                name: "ModificadorTipo",
                newName: "Modificadores");

            migrationBuilder.RenameTable(
                name: "Entrenadores_Pokemon",
                newName: "Entrenadores_Pokemons");

            migrationBuilder.RenameTable(
                name: "Entrenador",
                newName: "Entrenadores");

            migrationBuilder.RenameIndex(
                name: "IX_Tipos_Pokemons_TipoId",
                table: "Tipo_Pokemons",
                newName: "IX_Tipo_Pokemons_TipoId");

            migrationBuilder.RenameIndex(
                name: "IX_Tipos_Pokemons_PokemonId",
                table: "Tipo_Pokemons",
                newName: "IX_Tipo_Pokemons_PokemonId");

            migrationBuilder.RenameIndex(
                name: "IX_Tipos_Pokemons_PokedexId",
                table: "Tipo_Pokemons",
                newName: "IX_Tipo_Pokemons_PokedexId");

            migrationBuilder.RenameIndex(
                name: "IX_TipoBonus_DebilidadId",
                table: "Bonuses",
                newName: "IX_Bonuses_DebilidadId");

            migrationBuilder.RenameIndex(
                name: "IX_Pokemon_StatId",
                table: "Pokemons",
                newName: "IX_Pokemons_StatId");

            migrationBuilder.RenameIndex(
                name: "IX_Pokemon_PokedexId",
                table: "Pokemons",
                newName: "IX_Pokemons_PokedexId");

            migrationBuilder.RenameIndex(
                name: "IX_ModificadorTipo_BonusId",
                table: "Modificadores",
                newName: "IX_Modificadores_BonusId");

            migrationBuilder.RenameIndex(
                name: "IX_Entrenadores_Pokemon_PokemonId",
                table: "Entrenadores_Pokemons",
                newName: "IX_Entrenadores_Pokemons_PokemonId");

            migrationBuilder.RenameIndex(
                name: "IX_Entrenadores_Pokemon_EntrenadorId",
                table: "Entrenadores_Pokemons",
                newName: "IX_Entrenadores_Pokemons_EntrenadorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tipo_Pokemons",
                table: "Tipo_Pokemons",
                column: "Id");

            migrationBuilder.AddUniqueConstraint(
                name: "AK_Bonuses_EficazId_DebilidadId_IdTipo",
                table: "Bonuses",
                columns: new[] { "EficazId", "DebilidadId", "IdTipo" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Bonuses",
                table: "Bonuses",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tipos",
                table: "Tipos",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Stats",
                table: "Stats",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pokemons",
                table: "Pokemons",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Modificadores",
                table: "Modificadores",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Entrenadores_Pokemons",
                table: "Entrenadores_Pokemons",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Entrenadores",
                table: "Entrenadores",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Bonuses_Tipos_DebilidadId",
                table: "Bonuses",
                column: "DebilidadId",
                principalTable: "Tipos",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Bonuses_Tipos_EficazId",
                table: "Bonuses",
                column: "EficazId",
                principalTable: "Tipos",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Debilidades_Tipos_IdTipo",
                table: "Debilidades",
                column: "IdTipo",
                principalTable: "Tipos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

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
                name: "FK_Fortalezas_Tipos_IdTipo",
                table: "Fortalezas",
                column: "IdTipo",
                principalTable: "Tipos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Modificadores_Tipos_BonusId",
                table: "Modificadores",
                column: "BonusId",
                principalTable: "Tipos",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Pokedex_Stats_StatId",
                table: "Pokedex",
                column: "StatId",
                principalTable: "Stats",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Pokemons_Pokedex_PokedexId",
                table: "Pokemons",
                column: "PokedexId",
                principalTable: "Pokedex",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Pokemons_Stats_StatId",
                table: "Pokemons",
                column: "StatId",
                principalTable: "Stats",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tipo_Pokemons_Pokedex_PokedexId",
                table: "Tipo_Pokemons",
                column: "PokedexId",
                principalTable: "Pokedex",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Tipo_Pokemons_Pokemons_PokemonId",
                table: "Tipo_Pokemons",
                column: "PokemonId",
                principalTable: "Pokemons",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Tipo_Pokemons_Tipos_TipoId",
                table: "Tipo_Pokemons",
                column: "TipoId",
                principalTable: "Tipos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tipos_Habilidades_Tipos_TipoId",
                table: "Tipos_Habilidades",
                column: "TipoId",
                principalTable: "Tipos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bonuses_Tipos_DebilidadId",
                table: "Bonuses");

            migrationBuilder.DropForeignKey(
                name: "FK_Bonuses_Tipos_EficazId",
                table: "Bonuses");

            migrationBuilder.DropForeignKey(
                name: "FK_Debilidades_Tipos_IdTipo",
                table: "Debilidades");

            migrationBuilder.DropForeignKey(
                name: "FK_Entrenadores_Pokemons_Entrenadores_EntrenadorId",
                table: "Entrenadores_Pokemons");

            migrationBuilder.DropForeignKey(
                name: "FK_Entrenadores_Pokemons_Pokemons_PokemonId",
                table: "Entrenadores_Pokemons");

            migrationBuilder.DropForeignKey(
                name: "FK_Fortalezas_Tipos_IdTipo",
                table: "Fortalezas");

            migrationBuilder.DropForeignKey(
                name: "FK_Modificadores_Tipos_BonusId",
                table: "Modificadores");

            migrationBuilder.DropForeignKey(
                name: "FK_Pokedex_Stats_StatId",
                table: "Pokedex");

            migrationBuilder.DropForeignKey(
                name: "FK_Pokemons_Pokedex_PokedexId",
                table: "Pokemons");

            migrationBuilder.DropForeignKey(
                name: "FK_Pokemons_Stats_StatId",
                table: "Pokemons");

            migrationBuilder.DropForeignKey(
                name: "FK_Tipo_Pokemons_Pokedex_PokedexId",
                table: "Tipo_Pokemons");

            migrationBuilder.DropForeignKey(
                name: "FK_Tipo_Pokemons_Pokemons_PokemonId",
                table: "Tipo_Pokemons");

            migrationBuilder.DropForeignKey(
                name: "FK_Tipo_Pokemons_Tipos_TipoId",
                table: "Tipo_Pokemons");

            migrationBuilder.DropForeignKey(
                name: "FK_Tipos_Habilidades_Tipos_TipoId",
                table: "Tipos_Habilidades");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tipos",
                table: "Tipos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tipo_Pokemons",
                table: "Tipo_Pokemons");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Stats",
                table: "Stats");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Pokemons",
                table: "Pokemons");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Modificadores",
                table: "Modificadores");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Entrenadores_Pokemons",
                table: "Entrenadores_Pokemons");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Entrenadores",
                table: "Entrenadores");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_Bonuses_EficazId_DebilidadId_IdTipo",
                table: "Bonuses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Bonuses",
                table: "Bonuses");

            migrationBuilder.RenameTable(
                name: "Tipos",
                newName: "Tipo");

            migrationBuilder.RenameTable(
                name: "Tipo_Pokemons",
                newName: "Tipos_Pokemons");

            migrationBuilder.RenameTable(
                name: "Stats",
                newName: "Stat");

            migrationBuilder.RenameTable(
                name: "Pokemons",
                newName: "Pokemon");

            migrationBuilder.RenameTable(
                name: "Modificadores",
                newName: "ModificadorTipo");

            migrationBuilder.RenameTable(
                name: "Entrenadores_Pokemons",
                newName: "Entrenadores_Pokemon");

            migrationBuilder.RenameTable(
                name: "Entrenadores",
                newName: "Entrenador");

            migrationBuilder.RenameTable(
                name: "Bonuses",
                newName: "TipoBonus");

            migrationBuilder.RenameIndex(
                name: "IX_Tipo_Pokemons_TipoId",
                table: "Tipos_Pokemons",
                newName: "IX_Tipos_Pokemons_TipoId");

            migrationBuilder.RenameIndex(
                name: "IX_Tipo_Pokemons_PokemonId",
                table: "Tipos_Pokemons",
                newName: "IX_Tipos_Pokemons_PokemonId");

            migrationBuilder.RenameIndex(
                name: "IX_Tipo_Pokemons_PokedexId",
                table: "Tipos_Pokemons",
                newName: "IX_Tipos_Pokemons_PokedexId");

            migrationBuilder.RenameIndex(
                name: "IX_Pokemons_StatId",
                table: "Pokemon",
                newName: "IX_Pokemon_StatId");

            migrationBuilder.RenameIndex(
                name: "IX_Pokemons_PokedexId",
                table: "Pokemon",
                newName: "IX_Pokemon_PokedexId");

            migrationBuilder.RenameIndex(
                name: "IX_Modificadores_BonusId",
                table: "ModificadorTipo",
                newName: "IX_ModificadorTipo_BonusId");

            migrationBuilder.RenameIndex(
                name: "IX_Entrenadores_Pokemons_PokemonId",
                table: "Entrenadores_Pokemon",
                newName: "IX_Entrenadores_Pokemon_PokemonId");

            migrationBuilder.RenameIndex(
                name: "IX_Entrenadores_Pokemons_EntrenadorId",
                table: "Entrenadores_Pokemon",
                newName: "IX_Entrenadores_Pokemon_EntrenadorId");

            migrationBuilder.RenameIndex(
                name: "IX_Bonuses_DebilidadId",
                table: "TipoBonus",
                newName: "IX_TipoBonus_DebilidadId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tipo",
                table: "Tipo",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tipos_Pokemons",
                table: "Tipos_Pokemons",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Stat",
                table: "Stat",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pokemon",
                table: "Pokemon",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ModificadorTipo",
                table: "ModificadorTipo",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Entrenadores_Pokemon",
                table: "Entrenadores_Pokemon",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Entrenador",
                table: "Entrenador",
                column: "Id");

            migrationBuilder.AddUniqueConstraint(
                name: "AK_TipoBonus_EficazId_DebilidadId_IdTipo",
                table: "TipoBonus",
                columns: new[] { "EficazId", "DebilidadId", "IdTipo" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_TipoBonus",
                table: "TipoBonus",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Debilidades_Tipo_IdTipo",
                table: "Debilidades",
                column: "IdTipo",
                principalTable: "Tipo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Entrenadores_Pokemon_Entrenador_EntrenadorId",
                table: "Entrenadores_Pokemon",
                column: "EntrenadorId",
                principalTable: "Entrenador",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Entrenadores_Pokemon_Pokemon_PokemonId",
                table: "Entrenadores_Pokemon",
                column: "PokemonId",
                principalTable: "Pokemon",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Fortalezas_Tipo_IdTipo",
                table: "Fortalezas",
                column: "IdTipo",
                principalTable: "Tipo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ModificadorTipo_Tipo_BonusId",
                table: "ModificadorTipo",
                column: "BonusId",
                principalTable: "Tipo",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Pokedex_Stat_StatId",
                table: "Pokedex",
                column: "StatId",
                principalTable: "Stat",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Pokemon_Pokedex_PokedexId",
                table: "Pokemon",
                column: "PokedexId",
                principalTable: "Pokedex",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Pokemon_Stat_StatId",
                table: "Pokemon",
                column: "StatId",
                principalTable: "Stat",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TipoBonus_Tipo_DebilidadId",
                table: "TipoBonus",
                column: "DebilidadId",
                principalTable: "Tipo",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TipoBonus_Tipo_EficazId",
                table: "TipoBonus",
                column: "EficazId",
                principalTable: "Tipo",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Tipos_Habilidades_Tipo_TipoId",
                table: "Tipos_Habilidades",
                column: "TipoId",
                principalTable: "Tipo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tipos_Pokemons_Pokedex_PokedexId",
                table: "Tipos_Pokemons",
                column: "PokedexId",
                principalTable: "Pokedex",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Tipos_Pokemons_Pokemon_PokemonId",
                table: "Tipos_Pokemons",
                column: "PokemonId",
                principalTable: "Pokemon",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Tipos_Pokemons_Tipo_TipoId",
                table: "Tipos_Pokemons",
                column: "TipoId",
                principalTable: "Tipo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
