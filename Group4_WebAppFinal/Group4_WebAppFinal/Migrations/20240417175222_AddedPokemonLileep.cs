using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Group4_WebAppFinal.Migrations
{
    /// <inheritdoc />
    public partial class AddedPokemonLileep : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PokemonName",
                table: "Generations",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Generations",
                keyColumn: "GenerationId",
                keyValue: 1,
                column: "PokemonName",
                value: null);

            migrationBuilder.UpdateData(
                table: "Generations",
                keyColumn: "GenerationId",
                keyValue: 2,
                column: "PokemonName",
                value: null);

            migrationBuilder.UpdateData(
                table: "Generations",
                keyColumn: "GenerationId",
                keyValue: 3,
                column: "PokemonName",
                value: null);

            migrationBuilder.UpdateData(
                table: "Generations",
                keyColumn: "GenerationId",
                keyValue: 4,
                column: "PokemonName",
                value: null);

            migrationBuilder.UpdateData(
                table: "Generations",
                keyColumn: "GenerationId",
                keyValue: 5,
                column: "PokemonName",
                value: null);

            migrationBuilder.UpdateData(
                table: "Generations",
                keyColumn: "GenerationId",
                keyValue: 6,
                column: "PokemonName",
                value: null);

            migrationBuilder.UpdateData(
                table: "Generations",
                keyColumn: "GenerationId",
                keyValue: 7,
                column: "PokemonName",
                value: null);

            migrationBuilder.UpdateData(
                table: "Generations",
                keyColumn: "GenerationId",
                keyValue: 8,
                column: "PokemonName",
                value: null);

            migrationBuilder.UpdateData(
                table: "Generations",
                keyColumn: "GenerationId",
                keyValue: 9,
                column: "PokemonName",
                value: null);

            migrationBuilder.InsertData(
                table: "Pokemons",
                columns: new[] { "PokemonName", "DexNumber", "Generation", "Type1", "Type2" },
                values: new object[] { "Lileep", 345, 3, "Rock", "Grass" });

            migrationBuilder.CreateIndex(
                name: "IX_Generations_PokemonName",
                table: "Generations",
                column: "PokemonName");

            migrationBuilder.AddForeignKey(
                name: "FK_Generations_Pokemons_PokemonName",
                table: "Generations",
                column: "PokemonName",
                principalTable: "Pokemons",
                principalColumn: "PokemonName");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Generations_Pokemons_PokemonName",
                table: "Generations");

            migrationBuilder.DropIndex(
                name: "IX_Generations_PokemonName",
                table: "Generations");

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "PokemonName",
                keyValue: "Lileep");

            migrationBuilder.DropColumn(
                name: "PokemonName",
                table: "Generations");
        }
    }
}
