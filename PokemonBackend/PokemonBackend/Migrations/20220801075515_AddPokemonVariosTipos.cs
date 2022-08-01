using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PokemonBackend.Migrations
{
    public partial class AddPokemonVariosTipos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Tipos",
                columns: new[] { "Id", "Tipo_pokemon" },
                values: new object[] { 19, "Veneno" });

            migrationBuilder.UpdateData(
                table: "Tipo_Pokemons",
                keyColumn: "Id",
                keyValue: 2,
                column: "TipoId",
                value: 19);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tipos",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.UpdateData(
                table: "Tipo_Pokemons",
                keyColumn: "Id",
                keyValue: 2,
                column: "TipoId",
                value: 4);
        }
    }
}
