using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PokemonBackend.Migrations
{
    public partial class TablaPokedexAddRelaciones_v1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tipo_Pokemons_Pokemons_PokemonId",
                table: "Tipo_Pokemons");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tipo_Pokemons",
                table: "Tipo_Pokemons");

            migrationBuilder.DeleteData(
                table: "Tipo_Pokemons",
                keyColumns: new[] { "PokemonId", "TipoId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.AlterColumn<int>(
                name: "PokemonId",
                table: "Tipo_Pokemons",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "PokedexId",
                table: "Tipo_Pokemons",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tipo_Pokemons",
                table: "Tipo_Pokemons",
                columns: new[] { "TipoId", "PokedexId" });

            migrationBuilder.UpdateData(
                table: "Pokedex",
                keyColumn: "Id",
                keyValue: 4,
                column: "Nombre",
                value: "Charmander");

            migrationBuilder.UpdateData(
                table: "Pokedex",
                keyColumn: "Id",
                keyValue: 5,
                column: "Nombre",
                value: "Charmeleon");

            migrationBuilder.UpdateData(
                table: "Pokedex",
                keyColumn: "Id",
                keyValue: 6,
                column: "Nombre",
                value: "Charizard ");

            migrationBuilder.UpdateData(
                table: "Pokedex",
                keyColumn: "Id",
                keyValue: 9,
                column: "Nombre",
                value: "Blastoise");

            migrationBuilder.UpdateData(
                table: "Pokedex",
                keyColumn: "Id",
                keyValue: 10,
                column: "Nombre",
                value: "Caterpie");

            migrationBuilder.UpdateData(
                table: "Pokedex",
                keyColumn: "Id",
                keyValue: 25,
                column: "Nombre",
                value: "Sandslah");

            migrationBuilder.UpdateData(
                table: "Pokedex",
                keyColumn: "Id",
                keyValue: 27,
                column: "Nombre",
                value: "Nidorina");

            migrationBuilder.UpdateData(
                table: "Pokedex",
                keyColumn: "Id",
                keyValue: 28,
                column: "Nombre",
                value: "Nidoqueen");

            migrationBuilder.UpdateData(
                table: "Pokedex",
                keyColumn: "Id",
                keyValue: 30,
                column: "Nombre",
                value: "Nidorino");

            migrationBuilder.UpdateData(
                table: "Pokedex",
                keyColumn: "Id",
                keyValue: 31,
                column: "Nombre",
                value: "Nidoking");

            migrationBuilder.UpdateData(
                table: "Pokedex",
                keyColumn: "Id",
                keyValue: 32,
                column: "Nombre",
                value: "Clefairy");

            migrationBuilder.UpdateData(
                table: "Pokedex",
                keyColumn: "Id",
                keyValue: 33,
                column: "Nombre",
                value: "Clefable");

            migrationBuilder.UpdateData(
                table: "Pokedex",
                keyColumn: "Id",
                keyValue: 35,
                column: "Nombre",
                value: "Ninetales");

            migrationBuilder.UpdateData(
                table: "Pokedex",
                keyColumn: "Id",
                keyValue: 36,
                column: "Nombre",
                value: "Jigglypuff");

            migrationBuilder.UpdateData(
                table: "Pokedex",
                keyColumn: "Id",
                keyValue: 37,
                column: "Nombre",
                value: "Wigglytuff");

            migrationBuilder.InsertData(
                table: "Tipo_Pokemons",
                columns: new[] { "PokedexId", "TipoId", "PokemonId" },
                values: new object[] { 1, 3, null });

            migrationBuilder.CreateIndex(
                name: "IX_Tipo_Pokemons_PokedexId",
                table: "Tipo_Pokemons",
                column: "PokedexId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tipo_Pokemons_Pokedex_PokedexId",
                table: "Tipo_Pokemons",
                column: "PokedexId",
                principalTable: "Pokedex",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tipo_Pokemons_Pokemons_PokemonId",
                table: "Tipo_Pokemons",
                column: "PokemonId",
                principalTable: "Pokemons",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tipo_Pokemons_Pokedex_PokedexId",
                table: "Tipo_Pokemons");

            migrationBuilder.DropForeignKey(
                name: "FK_Tipo_Pokemons_Pokemons_PokemonId",
                table: "Tipo_Pokemons");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tipo_Pokemons",
                table: "Tipo_Pokemons");

            migrationBuilder.DropIndex(
                name: "IX_Tipo_Pokemons_PokedexId",
                table: "Tipo_Pokemons");

            migrationBuilder.DeleteData(
                table: "Tipo_Pokemons",
                keyColumns: new[] { "PokedexId", "TipoId" },
                keyColumnTypes: new[] { "int", "int" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DropColumn(
                name: "PokedexId",
                table: "Tipo_Pokemons");

            migrationBuilder.AlterColumn<int>(
                name: "PokemonId",
                table: "Tipo_Pokemons",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tipo_Pokemons",
                table: "Tipo_Pokemons",
                columns: new[] { "TipoId", "PokemonId" });

            migrationBuilder.UpdateData(
                table: "Pokedex",
                keyColumn: "Id",
                keyValue: 4,
                column: "Nombre",
                value: "Charmand ");

            migrationBuilder.UpdateData(
                table: "Pokedex",
                keyColumn: "Id",
                keyValue: 5,
                column: "Nombre",
                value: "Charmele  ");

            migrationBuilder.UpdateData(
                table: "Pokedex",
                keyColumn: "Id",
                keyValue: 6,
                column: "Nombre",
                value: "Charizar ");

            migrationBuilder.UpdateData(
                table: "Pokedex",
                keyColumn: "Id",
                keyValue: 9,
                column: "Nombre",
                value: "Blastois");

            migrationBuilder.UpdateData(
                table: "Pokedex",
                keyColumn: "Id",
                keyValue: 10,
                column: "Nombre",
                value: "Caterpi");

            migrationBuilder.UpdateData(
                table: "Pokedex",
                keyColumn: "Id",
                keyValue: 25,
                column: "Nombre",
                value: "Sandsla");

            migrationBuilder.UpdateData(
                table: "Pokedex",
                keyColumn: "Id",
                keyValue: 27,
                column: "Nombre",
                value: "Nidorin");

            migrationBuilder.UpdateData(
                table: "Pokedex",
                keyColumn: "Id",
                keyValue: 28,
                column: "Nombre",
                value: "Nidoque");

            migrationBuilder.UpdateData(
                table: "Pokedex",
                keyColumn: "Id",
                keyValue: 30,
                column: "Nombre",
                value: "Nidorin");

            migrationBuilder.UpdateData(
                table: "Pokedex",
                keyColumn: "Id",
                keyValue: 31,
                column: "Nombre",
                value: "Nidokin");

            migrationBuilder.UpdateData(
                table: "Pokedex",
                keyColumn: "Id",
                keyValue: 32,
                column: "Nombre",
                value: "Clefair");

            migrationBuilder.UpdateData(
                table: "Pokedex",
                keyColumn: "Id",
                keyValue: 33,
                column: "Nombre",
                value: "Clefabl");

            migrationBuilder.UpdateData(
                table: "Pokedex",
                keyColumn: "Id",
                keyValue: 35,
                column: "Nombre",
                value: "Ninetal");

            migrationBuilder.UpdateData(
                table: "Pokedex",
                keyColumn: "Id",
                keyValue: 36,
                column: "Nombre",
                value: "Jigglyp");

            migrationBuilder.UpdateData(
                table: "Pokedex",
                keyColumn: "Id",
                keyValue: 37,
                column: "Nombre",
                value: "Wigglyt");

            migrationBuilder.InsertData(
                table: "Tipo_Pokemons",
                columns: new[] { "PokemonId", "TipoId" },
                values: new object[] { 1, 1 });

            migrationBuilder.AddForeignKey(
                name: "FK_Tipo_Pokemons_Pokemons_PokemonId",
                table: "Tipo_Pokemons",
                column: "PokemonId",
                principalTable: "Pokemons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
