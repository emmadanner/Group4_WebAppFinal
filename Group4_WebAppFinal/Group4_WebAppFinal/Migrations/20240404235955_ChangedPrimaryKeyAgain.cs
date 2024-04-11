using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Group4_WebAppFinal.Migrations
{
    /// <inheritdoc />
    public partial class ChangedPrimaryKeyAgain : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Teams_Pokemons_PokemonName1",
                table: "Teams");

            migrationBuilder.DropIndex(
                name: "IX_Teams_PokemonName1",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "PokemonName1",
                table: "Teams");

            migrationBuilder.AlterColumn<string>(
                name: "PokemonName",
                table: "Teams",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.CreateIndex(
                name: "IX_Teams_PokemonName",
                table: "Teams",
                column: "PokemonName");

            migrationBuilder.AddForeignKey(
                name: "FK_Teams_Pokemons_PokemonName",
                table: "Teams",
                column: "PokemonName",
                principalTable: "Pokemons",
                principalColumn: "PokemonName");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Teams_Pokemons_PokemonName",
                table: "Teams");

            migrationBuilder.DropIndex(
                name: "IX_Teams_PokemonName",
                table: "Teams");

            migrationBuilder.AlterColumn<string>(
                name: "PokemonName",
                table: "Teams",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PokemonName1",
                table: "Teams",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Teams_PokemonName1",
                table: "Teams",
                column: "PokemonName1");

            migrationBuilder.AddForeignKey(
                name: "FK_Teams_Pokemons_PokemonName1",
                table: "Teams",
                column: "PokemonName1",
                principalTable: "Pokemons",
                principalColumn: "PokemonName");
        }
    }
}
