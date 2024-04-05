using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Group4_WebAppFinal.Migrations
{
    /// <inheritdoc />
    public partial class ChangedPrimaryKey : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Teams_Pokemons_PokemonId",
                table: "Teams");

            migrationBuilder.DropIndex(
                name: "IX_Teams_PokemonId",
                table: "Teams");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Pokemons",
                table: "Pokemons");

            migrationBuilder.DropColumn(
                name: "PokemonId",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "PokemonId",
                table: "Pokemons");

            migrationBuilder.AddColumn<string>(
                name: "PokemonName1",
                table: "Teams",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PokemonName",
                table: "Pokemons",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pokemons",
                table: "Pokemons",
                column: "PokemonName");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Teams_Pokemons_PokemonName1",
                table: "Teams");

            migrationBuilder.DropIndex(
                name: "IX_Teams_PokemonName1",
                table: "Teams");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Pokemons",
                table: "Pokemons");

            migrationBuilder.DropColumn(
                name: "PokemonName1",
                table: "Teams");

            migrationBuilder.AddColumn<int>(
                name: "PokemonId",
                table: "Teams",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "PokemonName",
                table: "Pokemons",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<int>(
                name: "PokemonId",
                table: "Pokemons",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pokemons",
                table: "Pokemons",
                column: "PokemonId");

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
    }
}
