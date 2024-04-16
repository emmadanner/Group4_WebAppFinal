using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Group4_WebAppFinal.Migrations
{
    /// <inheritdoc />
    public partial class PrebuiltTypesandGenerationEntities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Generations",
                columns: new[] { "GenerationId", "GenGames" },
                values: new object[,]
                {
                    { 1, "Red, Blue, Green, Yellow" },
                    { 2, "Gold, Silver, Crystal" },
                    { 3, "Ruby, Sapphire, Emerald, FireRed, LeafGreen" },
                    { 4, "Diamond, Pearl, Platinum, HeartGold, SoulSilver" },
                    { 5, "Black, White, Black 2, White 2" },
                    { 6, "X, Y, Omega Ruby, Alpha Sapphire" },
                    { 7, "Sun, Moon, Ultra Sun, Ultra Moon" },
                    { 8, "Sword, Shield, Brilliant Diamond, Shining Pearl" },
                    { 9, "Scarlet, Violet" }
                });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                column: "TypeName",
                values: new object[]
                {
                    "Bug",
                    "Dark",
                    "Dragon",
                    "Electric",
                    "Fairy",
                    "Fighting",
                    "Fire",
                    "Flying",
                    "Ghost",
                    "Grass",
                    "Ground",
                    "Ice",
                    "Normal",
                    "Poison",
                    "Psychic",
                    "Rock",
                    "Steel",
                    "Water"
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Generations",
                keyColumn: "GenerationId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Generations",
                keyColumn: "GenerationId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Generations",
                keyColumn: "GenerationId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Generations",
                keyColumn: "GenerationId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Generations",
                keyColumn: "GenerationId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Generations",
                keyColumn: "GenerationId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Generations",
                keyColumn: "GenerationId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Generations",
                keyColumn: "GenerationId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Generations",
                keyColumn: "GenerationId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "PokemonTypes",
                keyColumn: "TypeName",
                keyValue: "Bug");

            migrationBuilder.DeleteData(
                table: "PokemonTypes",
                keyColumn: "TypeName",
                keyValue: "Dark");

            migrationBuilder.DeleteData(
                table: "PokemonTypes",
                keyColumn: "TypeName",
                keyValue: "Dragon");

            migrationBuilder.DeleteData(
                table: "PokemonTypes",
                keyColumn: "TypeName",
                keyValue: "Electric");

            migrationBuilder.DeleteData(
                table: "PokemonTypes",
                keyColumn: "TypeName",
                keyValue: "Fairy");

            migrationBuilder.DeleteData(
                table: "PokemonTypes",
                keyColumn: "TypeName",
                keyValue: "Fighting");

            migrationBuilder.DeleteData(
                table: "PokemonTypes",
                keyColumn: "TypeName",
                keyValue: "Fire");

            migrationBuilder.DeleteData(
                table: "PokemonTypes",
                keyColumn: "TypeName",
                keyValue: "Flying");

            migrationBuilder.DeleteData(
                table: "PokemonTypes",
                keyColumn: "TypeName",
                keyValue: "Ghost");

            migrationBuilder.DeleteData(
                table: "PokemonTypes",
                keyColumn: "TypeName",
                keyValue: "Grass");

            migrationBuilder.DeleteData(
                table: "PokemonTypes",
                keyColumn: "TypeName",
                keyValue: "Ground");

            migrationBuilder.DeleteData(
                table: "PokemonTypes",
                keyColumn: "TypeName",
                keyValue: "Ice");

            migrationBuilder.DeleteData(
                table: "PokemonTypes",
                keyColumn: "TypeName",
                keyValue: "Normal");

            migrationBuilder.DeleteData(
                table: "PokemonTypes",
                keyColumn: "TypeName",
                keyValue: "Poison");

            migrationBuilder.DeleteData(
                table: "PokemonTypes",
                keyColumn: "TypeName",
                keyValue: "Psychic");

            migrationBuilder.DeleteData(
                table: "PokemonTypes",
                keyColumn: "TypeName",
                keyValue: "Rock");

            migrationBuilder.DeleteData(
                table: "PokemonTypes",
                keyColumn: "TypeName",
                keyValue: "Steel");

            migrationBuilder.DeleteData(
                table: "PokemonTypes",
                keyColumn: "TypeName",
                keyValue: "Water");
        }
    }
}
