using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Group4_WebAppFinal.Migrations
{
    /// <inheritdoc />
    public partial class AddedRelationshipBetweenPokemonAndTeam : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PokemonId",
                table: "Teams",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Teams_PokemonId",
                table: "Teams",
                column: "PokemonId");

            migrationBuilder.AddForeignKey(
                name: "FK_Teams_Pokemons_PokemonId",
                table: "Teams",
                column: "PokemonId",
                principalTable: "Pokemons",
                principalColumn: "PokemonId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Teams_Pokemons_PokemonId",
                table: "Teams");

            migrationBuilder.DropIndex(
                name: "IX_Teams_PokemonId",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "PokemonId",
                table: "Teams");
        }
    }
}
