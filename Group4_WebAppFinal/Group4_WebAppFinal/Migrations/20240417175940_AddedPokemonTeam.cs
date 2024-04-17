using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Group4_WebAppFinal.Migrations
{
    /// <inheritdoc />
    public partial class AddedPokemonTeam : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TeamNum",
                table: "Pokemons",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "PokemonName",
                keyValue: "Bulbasaur",
                column: "TeamNum",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "PokemonName",
                keyValue: "Lileep",
                column: "TeamNum",
                value: null);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TeamNum",
                table: "Pokemons");
        }
    }
}
