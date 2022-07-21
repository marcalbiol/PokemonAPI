using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PokemonBackend.Migrations
{
    public partial class AddedRelacionStatsPokemon : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ataque",
                table: "Pokemons");

            migrationBuilder.DropColumn(
                name: "Defensa",
                table: "Pokemons");

            migrationBuilder.DropColumn(
                name: "Nivel",
                table: "Pokemons");

            migrationBuilder.RenameColumn(
                name: "Ventaja",
                table: "Tipos",
                newName: "Eficaz");

            migrationBuilder.RenameColumn(
                name: "Desventaja",
                table: "Tipos",
                newName: "Debil");

            migrationBuilder.RenameColumn(
                name: "Vida",
                table: "Pokemons",
                newName: "StatId");

            migrationBuilder.AddColumn<bool>(
                name: "Shiny",
                table: "Pokemons",
                type: "bit",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Stat",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nivel = table.Column<int>(type: "int", nullable: true),
                    Ataque = table.Column<int>(type: "int", nullable: true),
                    Defensa = table.Column<int>(type: "int", nullable: true),
                    Vida = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stat", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pokemons_StatId",
                table: "Pokemons",
                column: "StatId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pokemons_Stat_StatId",
                table: "Pokemons",
                column: "StatId",
                principalTable: "Stat",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pokemons_Stat_StatId",
                table: "Pokemons");

            migrationBuilder.DropTable(
                name: "Stat");

            migrationBuilder.DropIndex(
                name: "IX_Pokemons_StatId",
                table: "Pokemons");

            migrationBuilder.DropColumn(
                name: "Shiny",
                table: "Pokemons");

            migrationBuilder.RenameColumn(
                name: "Eficaz",
                table: "Tipos",
                newName: "Ventaja");

            migrationBuilder.RenameColumn(
                name: "Debil",
                table: "Tipos",
                newName: "Desventaja");

            migrationBuilder.RenameColumn(
                name: "StatId",
                table: "Pokemons",
                newName: "Vida");

            migrationBuilder.AddColumn<int>(
                name: "Ataque",
                table: "Pokemons",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Defensa",
                table: "Pokemons",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Nivel",
                table: "Pokemons",
                type: "int",
                nullable: true);
        }
    }
}
