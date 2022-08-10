using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Acceso_BD.Migrations
{
    public partial class AddDataPokemonsTipos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Tipo_Pokemons",
                columns: new[] { "Id", "PokedexId", "PokemonId", "TipoId" },
                values: new object[,]
                {
                    { 3, 2, null, 3 },
                    { 4, 2, null, 19 },
                    { 5, 3, null, 3 },
                    { 6, 3, null, 19 },
                    { 7, 4, null, 1 },
                    { 8, 5, null, 1 },
                    { 9, 6, null, 1 },
                    { 10, 6, null, 7 },
                    { 11, 7, null, 2 },
                    { 12, 8, null, 2 },
                    { 13, 9, null, 2 },
                    { 14, 10, null, 9 },
                    { 15, 11, null, 9 },
                    { 16, 12, null, 9 },
                    { 17, 12, null, 7 },
                    { 18, 13, null, 7 },
                    { 19, 13, null, 19 },
                    { 20, 14, null, 7 },
                    { 21, 14, null, 19 },
                    { 22, 15, null, 7 },
                    { 23, 15, null, 19 },
                    { 24, 16, null, 7 },
                    { 25, 16, null, 10 },
                    { 26, 17, null, 7 },
                    { 27, 17, null, 10 },
                    { 28, 18, null, 7 },
                    { 29, 18, null, 10 },
                    { 30, 19, null, 10 },
                    { 31, 20, null, 10 },
                    { 32, 21, null, 10 },
                    { 33, 21, null, 7 },
                    { 34, 22, null, 7 },
                    { 35, 22, null, 10 },
                    { 36, 23, null, 19 },
                    { 37, 24, null, 19 },
                    { 38, 25, null, 4 },
                    { 39, 26, null, 4 },
                    { 40, 27, null, 11 },
                    { 41, 28, null, 11 },
                    { 42, 29, null, 19 },
                    { 43, 30, null, 19 },
                    { 44, 31, null, 19 }
                });

            migrationBuilder.InsertData(
                table: "Tipo_Pokemons",
                columns: new[] { "Id", "PokedexId", "PokemonId", "TipoId" },
                values: new object[,]
                {
                    { 45, 31, null, 11 },
                    { 46, 32, null, 19 },
                    { 47, 33, null, 19 },
                    { 48, 34, null, 19 },
                    { 49, 34, null, 11 },
                    { 50, 35, null, 13 },
                    { 51, 36, null, 13 },
                    { 52, 37, null, 1 },
                    { 53, 38, null, 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tipo_Pokemons",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Tipo_Pokemons",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Tipo_Pokemons",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Tipo_Pokemons",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Tipo_Pokemons",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Tipo_Pokemons",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Tipo_Pokemons",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Tipo_Pokemons",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Tipo_Pokemons",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Tipo_Pokemons",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Tipo_Pokemons",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Tipo_Pokemons",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Tipo_Pokemons",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Tipo_Pokemons",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Tipo_Pokemons",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Tipo_Pokemons",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Tipo_Pokemons",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Tipo_Pokemons",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Tipo_Pokemons",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Tipo_Pokemons",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Tipo_Pokemons",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Tipo_Pokemons",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Tipo_Pokemons",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Tipo_Pokemons",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Tipo_Pokemons",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Tipo_Pokemons",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Tipo_Pokemons",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Tipo_Pokemons",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Tipo_Pokemons",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Tipo_Pokemons",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Tipo_Pokemons",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Tipo_Pokemons",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Tipo_Pokemons",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Tipo_Pokemons",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Tipo_Pokemons",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Tipo_Pokemons",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Tipo_Pokemons",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Tipo_Pokemons",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Tipo_Pokemons",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Tipo_Pokemons",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Tipo_Pokemons",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Tipo_Pokemons",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Tipo_Pokemons",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Tipo_Pokemons",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Tipo_Pokemons",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Tipo_Pokemons",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Tipo_Pokemons",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Tipo_Pokemons",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Tipo_Pokemons",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Tipo_Pokemons",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Tipo_Pokemons",
                keyColumn: "Id",
                keyValue: 53);
        }
    }
}
