using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Group4_WebAppFinal.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedRelationshipPokemonName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Teams_Pokemons_PokemonNamePokemonId",
                table: "Teams");

            migrationBuilder.RenameColumn(
                name: "PokemonNamePokemonId",
                table: "Teams",
                newName: "PokemonId");

            migrationBuilder.RenameIndex(
                name: "IX_Teams_PokemonNamePokemonId",
                table: "Teams",
                newName: "IX_Teams_PokemonId");

            migrationBuilder.AddColumn<string>(
                name: "PokemonName",
                table: "Teams",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

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

            migrationBuilder.DropColumn(
                name: "PokemonName",
                table: "Teams");

            migrationBuilder.RenameColumn(
                name: "PokemonId",
                table: "Teams",
                newName: "PokemonNamePokemonId");

            migrationBuilder.RenameIndex(
                name: "IX_Teams_PokemonId",
                table: "Teams",
                newName: "IX_Teams_PokemonNamePokemonId");

            migrationBuilder.AddForeignKey(
                name: "FK_Teams_Pokemons_PokemonNamePokemonId",
                table: "Teams",
                column: "PokemonNamePokemonId",
                principalTable: "Pokemons",
                principalColumn: "PokemonId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
