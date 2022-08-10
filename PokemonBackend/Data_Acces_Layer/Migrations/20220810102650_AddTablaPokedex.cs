using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Acceso_BD.Migrations
{
    public partial class AddTablaPokedex : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Pokedex",
                columns: new[] { "ID", "Altura", "Basico", "Imagen", "Nombre", "Peso", "RegionId", "StatId", "Tier", "ZonaId" },
                values: new object[,]
                {
                    { 101, null, null, null, "Electrode", null, null, null, null, null },
                    { 102, null, null, null, "Exeggcute", null, null, null, null, null },
                    { 103, null, null, null, "Exeggutor", null, null, null, null, null },
                    { 104, null, null, null, "Cubone", null, null, null, null, null },
                    { 105, null, null, null, "Marowak", null, null, null, null, null },
                    { 106, null, null, null, "Hitmonlee", null, null, null, null, null },
                    { 107, null, null, null, "Hitmonchan", null, null, null, null, null },
                    { 108, null, null, null, "Lickitung", null, null, null, null, null },
                    { 109, null, null, null, "Koffing", null, null, null, null, null },
                    { 110, null, null, null, "Weezing", null, null, null, null, null },
                    { 111, null, null, null, "Rhyhorn", null, null, null, null, null },
                    { 112, null, null, null, "Rhydon", null, null, null, null, null },
                    { 113, null, null, null, "Chansey", null, null, null, null, null },
                    { 114, null, null, null, "Tangela", null, null, null, null, null },
                    { 115, null, null, null, "Kangskhan", null, null, null, null, null },
                    { 116, null, null, null, "Horsea", null, null, null, null, null },
                    { 117, null, null, null, "Seadra", null, null, null, null, null },
                    { 118, null, null, null, "Goldeen", null, null, null, null, null },
                    { 119, null, null, null, "Seaking", null, null, null, null, null },
                    { 120, null, null, null, "Staryu", null, null, null, null, null },
                    { 121, null, null, null, "Starmie", null, null, null, null, null },
                    { 122, null, null, null, "Mr.Mime", null, null, null, null, null },
                    { 123, null, null, null, "Scyher", null, null, null, null, null },
                    { 124, null, null, null, "Jynx", null, null, null, null, null },
                    { 125, null, null, null, "Electabuzz", null, null, null, null, null },
                    { 126, null, null, null, "Magmar", null, null, null, null, null },
                    { 127, null, null, null, "Pinsir", null, null, null, null, null },
                    { 128, null, null, null, "Tauros", null, null, null, null, null },
                    { 129, null, null, null, "Magikarp", null, null, null, null, null },
                    { 130, null, null, null, "Gyarados", null, null, null, null, null },
                    { 131, null, null, null, "Lapras", null, null, null, null, null },
                    { 132, null, null, null, "Ditto", null, null, null, null, null },
                    { 133, null, null, null, "Eevee", null, null, null, null, null },
                    { 134, null, null, null, "Vaporeon", null, null, null, null, null },
                    { 135, null, null, null, "Jolteon", null, null, null, null, null },
                    { 136, null, null, null, "Flareon", null, null, null, null, null },
                    { 137, null, null, null, "Porygon", null, null, null, null, null },
                    { 138, null, null, null, "Omanyte", null, null, null, null, null },
                    { 139, null, null, null, "Omastar", null, null, null, null, null },
                    { 140, null, null, null, "Kabuto", null, null, null, null, null },
                    { 141, null, null, null, "Kabutops", null, null, null, null, null },
                    { 142, null, null, null, "Aerodactyl", null, null, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Pokedex",
                columns: new[] { "ID", "Altura", "Basico", "Imagen", "Nombre", "Peso", "RegionId", "StatId", "Tier", "ZonaId" },
                values: new object[,]
                {
                    { 143, null, null, null, "Snorlax", null, null, null, null, null },
                    { 144, null, null, null, "Articuno", null, null, null, null, null },
                    { 145, null, null, null, "Zapdos", null, null, null, null, null },
                    { 146, null, null, null, "Moltres", null, null, null, null, null },
                    { 147, null, null, null, "Dratini", null, null, null, null, null },
                    { 148, null, null, null, "Dragonair", null, null, null, null, null },
                    { 149, null, null, null, "Dragonite", null, null, null, null, null },
                    { 150, null, null, null, "Mewtwo", null, null, null, null, null },
                    { 151, null, null, null, "Mew", null, null, null, null, null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Pokedex",
                keyColumn: "ID",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Pokedex",
                keyColumn: "ID",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Pokedex",
                keyColumn: "ID",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Pokedex",
                keyColumn: "ID",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Pokedex",
                keyColumn: "ID",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Pokedex",
                keyColumn: "ID",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Pokedex",
                keyColumn: "ID",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Pokedex",
                keyColumn: "ID",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Pokedex",
                keyColumn: "ID",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Pokedex",
                keyColumn: "ID",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Pokedex",
                keyColumn: "ID",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Pokedex",
                keyColumn: "ID",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Pokedex",
                keyColumn: "ID",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Pokedex",
                keyColumn: "ID",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Pokedex",
                keyColumn: "ID",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Pokedex",
                keyColumn: "ID",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Pokedex",
                keyColumn: "ID",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Pokedex",
                keyColumn: "ID",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Pokedex",
                keyColumn: "ID",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Pokedex",
                keyColumn: "ID",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Pokedex",
                keyColumn: "ID",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Pokedex",
                keyColumn: "ID",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Pokedex",
                keyColumn: "ID",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Pokedex",
                keyColumn: "ID",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Pokedex",
                keyColumn: "ID",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Pokedex",
                keyColumn: "ID",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Pokedex",
                keyColumn: "ID",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Pokedex",
                keyColumn: "ID",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Pokedex",
                keyColumn: "ID",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Pokedex",
                keyColumn: "ID",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Pokedex",
                keyColumn: "ID",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Pokedex",
                keyColumn: "ID",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Pokedex",
                keyColumn: "ID",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Pokedex",
                keyColumn: "ID",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Pokedex",
                keyColumn: "ID",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Pokedex",
                keyColumn: "ID",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Pokedex",
                keyColumn: "ID",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Pokedex",
                keyColumn: "ID",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Pokedex",
                keyColumn: "ID",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Pokedex",
                keyColumn: "ID",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Pokedex",
                keyColumn: "ID",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Pokedex",
                keyColumn: "ID",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Pokedex",
                keyColumn: "ID",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Pokedex",
                keyColumn: "ID",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Pokedex",
                keyColumn: "ID",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Pokedex",
                keyColumn: "ID",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Pokedex",
                keyColumn: "ID",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Pokedex",
                keyColumn: "ID",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Pokedex",
                keyColumn: "ID",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Pokedex",
                keyColumn: "ID",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Pokedex",
                keyColumn: "ID",
                keyValue: 151);
        }
    }
}
