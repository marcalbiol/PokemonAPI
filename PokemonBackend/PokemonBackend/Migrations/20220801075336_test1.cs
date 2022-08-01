using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PokemonBackend.Migrations
{
    public partial class test1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Tipo_Pokemons",
                columns: new[] { "Id", "PokedexId", "PokemonId", "TipoId" },
                values: new object[] { 1, 1, null, 3 });

            migrationBuilder.InsertData(
                table: "Tipo_Pokemons",
                columns: new[] { "Id", "PokedexId", "PokemonId", "TipoId" },
                values: new object[] { 2, 1, null, 4 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tipo_Pokemons",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tipo_Pokemons",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
