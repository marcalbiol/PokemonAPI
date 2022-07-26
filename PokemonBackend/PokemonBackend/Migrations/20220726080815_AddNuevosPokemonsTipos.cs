using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PokemonBackend.Migrations
{
    public partial class AddNuevosPokemonsTipos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pokedex_Stats_StatId",
                table: "Pokedex");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Pokedex",
                newName: "ID");

            migrationBuilder.AddColumn<string>(
                name: "Altura",
                table: "Pokedex",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Peso",
                table: "Pokedex",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Pokedex",
                keyColumn: "ID",
                keyValue: 17,
                column: "Nombre",
                value: "Pidgeotto");

            migrationBuilder.UpdateData(
                table: "Pokedex",
                keyColumn: "ID",
                keyValue: 18,
                column: "Nombre",
                value: "Pidgeot");

            migrationBuilder.UpdateData(
                table: "Pokedex",
                keyColumn: "ID",
                keyValue: 19,
                column: "Nombre",
                value: "Rattata");

            migrationBuilder.UpdateData(
                table: "Pokedex",
                keyColumn: "ID",
                keyValue: 20,
                column: "Nombre",
                value: "Raticat");

            migrationBuilder.UpdateData(
                table: "Pokedex",
                keyColumn: "ID",
                keyValue: 21,
                column: "Nombre",
                value: "Spearow");

            migrationBuilder.UpdateData(
                table: "Pokedex",
                keyColumn: "ID",
                keyValue: 22,
                column: "Nombre",
                value: "Fearow");

            migrationBuilder.UpdateData(
                table: "Pokedex",
                keyColumn: "ID",
                keyValue: 23,
                column: "Nombre",
                value: "Ekans");

            migrationBuilder.UpdateData(
                table: "Pokedex",
                keyColumn: "ID",
                keyValue: 24,
                column: "Nombre",
                value: "Arbok");

            migrationBuilder.UpdateData(
                table: "Pokedex",
                keyColumn: "ID",
                keyValue: 25,
                column: "Nombre",
                value: "Pikachu");

            migrationBuilder.UpdateData(
                table: "Pokedex",
                keyColumn: "ID",
                keyValue: 26,
                column: "Nombre",
                value: "Raichu");

            migrationBuilder.UpdateData(
                table: "Pokedex",
                keyColumn: "ID",
                keyValue: 27,
                column: "Nombre",
                value: "Sandshrew");

            migrationBuilder.UpdateData(
                table: "Pokedex",
                keyColumn: "ID",
                keyValue: 28,
                column: "Nombre",
                value: "Sandslah");

            migrationBuilder.UpdateData(
                table: "Pokedex",
                keyColumn: "ID",
                keyValue: 29,
                column: "Nombre",
                value: "Nidoran ♀");

            migrationBuilder.UpdateData(
                table: "Pokedex",
                keyColumn: "ID",
                keyValue: 30,
                column: "Nombre",
                value: "Nidorina");

            migrationBuilder.UpdateData(
                table: "Pokedex",
                keyColumn: "ID",
                keyValue: 31,
                column: "Nombre",
                value: "Nidoqueen");

            migrationBuilder.UpdateData(
                table: "Pokedex",
                keyColumn: "ID",
                keyValue: 32,
                column: "Nombre",
                value: "Nidoran ♂");

            migrationBuilder.UpdateData(
                table: "Pokedex",
                keyColumn: "ID",
                keyValue: 33,
                column: "Nombre",
                value: "Nidorino");

            migrationBuilder.UpdateData(
                table: "Pokedex",
                keyColumn: "ID",
                keyValue: 34,
                column: "Nombre",
                value: "Nidoking");

            migrationBuilder.UpdateData(
                table: "Pokedex",
                keyColumn: "ID",
                keyValue: 35,
                column: "Nombre",
                value: "Clefairy");

            migrationBuilder.UpdateData(
                table: "Pokedex",
                keyColumn: "ID",
                keyValue: 36,
                column: "Nombre",
                value: "Clefable");

            migrationBuilder.UpdateData(
                table: "Pokedex",
                keyColumn: "ID",
                keyValue: 37,
                column: "Nombre",
                value: "Vulpix");

            migrationBuilder.InsertData(
                table: "Pokedex",
                columns: new[] { "ID", "Altura", "Imagen", "Nombre", "Peso", "StatId" },
                values: new object[,]
                {
                    { 38, null, null, "Ninetales", null, null },
                    { 39, null, null, "Jigglypuff", null, null },
                    { 40, null, null, "Wigglytuff", null, null },
                    { 41, null, null, "Zubat", null, null },
                    { 42, null, null, "Golbat", null, null },
                    { 43, null, null, "Oddish", null, null },
                    { 44, null, null, "Gloom", null, null },
                    { 45, null, null, "Vileplume", null, null },
                    { 46, null, null, "Paras", null, null },
                    { 47, null, null, "Parasect", null, null },
                    { 48, null, null, "Venonat", null, null },
                    { 49, null, null, "Venomoth", null, null },
                    { 50, null, null, "Diglett", null, null },
                    { 51, null, null, "Dugtrio", null, null },
                    { 52, null, null, "Meowth", null, null },
                    { 53, null, null, "Persian", null, null },
                    { 54, null, null, "Psyduck", null, null },
                    { 55, null, null, "Golduck", null, null },
                    { 56, null, null, "Mankey", null, null },
                    { 57, null, null, "Primeape", null, null },
                    { 58, null, null, "Growlithe", null, null }
                });

            migrationBuilder.InsertData(
                table: "Pokedex",
                columns: new[] { "ID", "Altura", "Imagen", "Nombre", "Peso", "StatId" },
                values: new object[,]
                {
                    { 59, null, null, "Arcanine", null, null },
                    { 60, null, null, "Poliwag", null, null },
                    { 61, null, null, "Poliwhirl", null, null },
                    { 62, null, null, "Poliwrath", null, null },
                    { 63, null, null, "Abra", null, null },
                    { 64, null, null, "Kadabra", null, null },
                    { 65, null, null, "Alakazam", null, null },
                    { 66, null, null, "Machop", null, null },
                    { 67, null, null, "Machoke", null, null },
                    { 68, null, null, "Machamp", null, null },
                    { 69, null, null, "Bellsprout", null, null },
                    { 70, null, null, "Weepinbell", null, null },
                    { 71, null, null, "Victreebell", null, null },
                    { 72, null, null, "Tentacool", null, null },
                    { 73, null, null, "Tentacruel", null, null },
                    { 74, null, null, "Geodude", null, null },
                    { 75, null, null, "Graveler", null, null },
                    { 76, null, null, "Golem", null, null },
                    { 77, null, null, "Ponyta", null, null },
                    { 78, null, null, "Rapidash", null, null },
                    { 79, null, null, "Slowpoke", null, null },
                    { 80, null, null, "Slowbro", null, null },
                    { 81, null, null, "Magnemite", null, null },
                    { 82, null, null, "Magneton", null, null },
                    { 83, null, null, "Farfetch'd", null, null },
                    { 84, null, null, "Doduo", null, null },
                    { 85, null, null, "Dodrio", null, null },
                    { 86, null, null, "Seel", null, null },
                    { 87, null, null, "Dewgong", null, null },
                    { 88, null, null, "Grimer", null, null },
                    { 89, null, null, "Muk", null, null },
                    { 90, null, null, "Shellder", null, null },
                    { 91, null, null, "Cloyster", null, null },
                    { 92, null, null, "Gastly", null, null },
                    { 93, null, null, "Haunter", null, null },
                    { 94, null, null, "Gengar", null, null },
                    { 95, null, null, "Onix", null, null },
                    { 96, null, null, "Drowzee", null, null },
                    { 97, null, null, "Hypno", null, null },
                    { 98, null, null, "Krabby", null, null },
                    { 99, null, null, "Kingler", null, null },
                    { 100, null, null, "Voltorb", null, null }
                });

            migrationBuilder.InsertData(
                table: "Tipos",
                columns: new[] { "Id", "Debil", "Eficaz", "Tipo_pokemon" },
                values: new object[,]
                {
                    { 6, "", "", "Acero" },
                    { 7, "", "", "Volador" },
                    { 8, "", "", "Hielo" },
                    { 9, "", "", "Bicho" },
                    { 10, "", "", "Normal" },
                    { 11, "", "", "Tierra" },
                    { 12, "", "", "Lucha" },
                    { 13, "", "", "Hada" },
                    { 14, "", "", "Psiquico" },
                    { 15, "", "", "Veneno" },
                    { 16, "", "", "Dragón" },
                    { 17, "", "", "Fantasma" },
                    { 18, "", "", "Siniestro" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Pokedex_Stats_StatId",
                table: "Pokedex",
                column: "StatId",
                principalTable: "Stats",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pokedex_Stats_StatId",
                table: "Pokedex");

            migrationBuilder.DeleteData(
                table: "Pokedex",
                keyColumn: "ID",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Pokedex",
                keyColumn: "ID",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Pokedex",
                keyColumn: "ID",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Pokedex",
                keyColumn: "ID",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Pokedex",
                keyColumn: "ID",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Pokedex",
                keyColumn: "ID",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Pokedex",
                keyColumn: "ID",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Pokedex",
                keyColumn: "ID",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Pokedex",
                keyColumn: "ID",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Pokedex",
                keyColumn: "ID",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Pokedex",
                keyColumn: "ID",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Pokedex",
                keyColumn: "ID",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Pokedex",
                keyColumn: "ID",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Pokedex",
                keyColumn: "ID",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Pokedex",
                keyColumn: "ID",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Pokedex",
                keyColumn: "ID",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Pokedex",
                keyColumn: "ID",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Pokedex",
                keyColumn: "ID",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Pokedex",
                keyColumn: "ID",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Pokedex",
                keyColumn: "ID",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Pokedex",
                keyColumn: "ID",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Pokedex",
                keyColumn: "ID",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Pokedex",
                keyColumn: "ID",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Pokedex",
                keyColumn: "ID",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Pokedex",
                keyColumn: "ID",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Pokedex",
                keyColumn: "ID",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Pokedex",
                keyColumn: "ID",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Pokedex",
                keyColumn: "ID",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Pokedex",
                keyColumn: "ID",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Pokedex",
                keyColumn: "ID",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Pokedex",
                keyColumn: "ID",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Pokedex",
                keyColumn: "ID",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Pokedex",
                keyColumn: "ID",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Pokedex",
                keyColumn: "ID",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Pokedex",
                keyColumn: "ID",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Pokedex",
                keyColumn: "ID",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Pokedex",
                keyColumn: "ID",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Pokedex",
                keyColumn: "ID",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Pokedex",
                keyColumn: "ID",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Pokedex",
                keyColumn: "ID",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Pokedex",
                keyColumn: "ID",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Pokedex",
                keyColumn: "ID",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Pokedex",
                keyColumn: "ID",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Pokedex",
                keyColumn: "ID",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Pokedex",
                keyColumn: "ID",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Pokedex",
                keyColumn: "ID",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Pokedex",
                keyColumn: "ID",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Pokedex",
                keyColumn: "ID",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Pokedex",
                keyColumn: "ID",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Pokedex",
                keyColumn: "ID",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Pokedex",
                keyColumn: "ID",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Pokedex",
                keyColumn: "ID",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Pokedex",
                keyColumn: "ID",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Pokedex",
                keyColumn: "ID",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Pokedex",
                keyColumn: "ID",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Pokedex",
                keyColumn: "ID",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Pokedex",
                keyColumn: "ID",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Pokedex",
                keyColumn: "ID",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Pokedex",
                keyColumn: "ID",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Pokedex",
                keyColumn: "ID",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Pokedex",
                keyColumn: "ID",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Pokedex",
                keyColumn: "ID",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Pokedex",
                keyColumn: "ID",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Tipos",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Tipos",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Tipos",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Tipos",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Tipos",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Tipos",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Tipos",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Tipos",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Tipos",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Tipos",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Tipos",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Tipos",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Tipos",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DropColumn(
                name: "Altura",
                table: "Pokedex");

            migrationBuilder.DropColumn(
                name: "Peso",
                table: "Pokedex");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Pokedex",
                newName: "Id");

            migrationBuilder.UpdateData(
                table: "Pokedex",
                keyColumn: "Id",
                keyValue: 17,
                column: "Nombre",
                value: "Rattata");

            migrationBuilder.UpdateData(
                table: "Pokedex",
                keyColumn: "Id",
                keyValue: 18,
                column: "Nombre",
                value: "Raticat");

            migrationBuilder.UpdateData(
                table: "Pokedex",
                keyColumn: "Id",
                keyValue: 19,
                column: "Nombre",
                value: "Spearow");

            migrationBuilder.UpdateData(
                table: "Pokedex",
                keyColumn: "Id",
                keyValue: 20,
                column: "Nombre",
                value: "Fearow");

            migrationBuilder.UpdateData(
                table: "Pokedex",
                keyColumn: "Id",
                keyValue: 21,
                column: "Nombre",
                value: "Ekans");

            migrationBuilder.UpdateData(
                table: "Pokedex",
                keyColumn: "Id",
                keyValue: 22,
                column: "Nombre",
                value: "Pikachu");

            migrationBuilder.UpdateData(
                table: "Pokedex",
                keyColumn: "Id",
                keyValue: 23,
                column: "Nombre",
                value: "Raichu");

            migrationBuilder.UpdateData(
                table: "Pokedex",
                keyColumn: "Id",
                keyValue: 24,
                column: "Nombre",
                value: "Sandshr");

            migrationBuilder.UpdateData(
                table: "Pokedex",
                keyColumn: "Id",
                keyValue: 25,
                column: "Nombre",
                value: "Sandslah");

            migrationBuilder.UpdateData(
                table: "Pokedex",
                keyColumn: "Id",
                keyValue: 26,
                column: "Nombre",
                value: "Nidoran");

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
                keyValue: 29,
                column: "Nombre",
                value: "Nidoran");

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
                keyValue: 34,
                column: "Nombre",
                value: "Vulpix");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Pokedex_Stats_StatId",
                table: "Pokedex",
                column: "StatId",
                principalTable: "Stats",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
