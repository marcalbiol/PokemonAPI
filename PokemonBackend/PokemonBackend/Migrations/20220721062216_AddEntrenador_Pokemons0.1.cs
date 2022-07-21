using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PokemonBackend.Migrations
{
    public partial class AddEntrenador_Pokemons01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Entrenadores",
                columns: new[] { "Id", "Nombre" },
                values: new object[,]
                {
                    { 1, "Marc" },
                    { 2, "Dani" },
                    { 3, "Ernest" }
                });

            migrationBuilder.InsertData(
                table: "Pokemons",
                columns: new[] { "Id", "Ataque", "Defensa", "EntrenadorId", "Nivel", "Nombre", "Vida" },
                values: new object[,]
                {
                    { 4, null, null, null, null, "Pikachu", null },
                    { 5, null, null, null, null, "Onix", null }
                });

            migrationBuilder.InsertData(
                table: "Tipos",
                columns: new[] { "Id", "Desventaja", "Tipo_pokemon", "Ventaja" },
                values: new object[,]
                {
                    { 4, "Dragon", "Electrico", "Agua" },
                    { 5, "Acero", "Roca", "Fuego" }
                });

            migrationBuilder.InsertData(
                table: "Entrenadores_Pokemons",
                columns: new[] { "EntrenadorId", "PokemonId" },
                values: new object[,]
                {
                    { 1, 4 },
                    { 2, 4 },
                    { 3, 5 }
                });

            migrationBuilder.InsertData(
                table: "Tipo_Pokemons",
                columns: new[] { "PokemonId", "TipoId" },
                values: new object[,]
                {
                    { 4, 4 },
                    { 5, 5 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Entrenadores_Pokemons",
                keyColumns: new[] { "EntrenadorId", "PokemonId" },
                keyValues: new object[] { 1, 4 });

            migrationBuilder.DeleteData(
                table: "Entrenadores_Pokemons",
                keyColumns: new[] { "EntrenadorId", "PokemonId" },
                keyValues: new object[] { 2, 4 });

            migrationBuilder.DeleteData(
                table: "Entrenadores_Pokemons",
                keyColumns: new[] { "EntrenadorId", "PokemonId" },
                keyValues: new object[] { 3, 5 });

            migrationBuilder.DeleteData(
                table: "Tipo_Pokemons",
                keyColumns: new[] { "PokemonId", "TipoId" },
                keyValues: new object[] { 4, 4 });

            migrationBuilder.DeleteData(
                table: "Tipo_Pokemons",
                keyColumns: new[] { "PokemonId", "TipoId" },
                keyValues: new object[] { 5, 5 });

            migrationBuilder.DeleteData(
                table: "Entrenadores",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Entrenadores",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Entrenadores",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Tipos",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Tipos",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
