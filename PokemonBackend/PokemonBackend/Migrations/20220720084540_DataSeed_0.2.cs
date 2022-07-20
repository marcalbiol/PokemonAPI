using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PokemonBackend.Migrations
{
    public partial class DataSeed_02 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 1,
                column: "Nombre",
                value: "Charmander");

            migrationBuilder.InsertData(
                table: "Tipo_Pokemons",
                columns: new[] { "PokemonId", "TipoId" },
                values: new object[] { 1, 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tipo_Pokemons",
                keyColumns: new[] { "PokemonId", "TipoId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 1,
                column: "Nombre",
                value: null);
        }
    }
}
