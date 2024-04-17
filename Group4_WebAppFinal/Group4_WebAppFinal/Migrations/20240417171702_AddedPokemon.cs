using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Group4_WebAppFinal.Migrations
{
    /// <inheritdoc />
    public partial class AddedPokemon : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pokemons_Generations_GenerationId",
                table: "Pokemons");

            migrationBuilder.DropForeignKey(
                name: "FK_Pokemons_PokemonTypes_Type1TypeName",
                table: "Pokemons");

            migrationBuilder.DropForeignKey(
                name: "FK_Pokemons_PokemonTypes_Type2TypeName",
                table: "Pokemons");

            migrationBuilder.DropIndex(
                name: "IX_Pokemons_GenerationId",
                table: "Pokemons");

            migrationBuilder.DropIndex(
                name: "IX_Pokemons_Type1TypeName",
                table: "Pokemons");

            migrationBuilder.DropIndex(
                name: "IX_Pokemons_Type2TypeName",
                table: "Pokemons");

            migrationBuilder.DropColumn(
                name: "Type1TypeName",
                table: "Pokemons");

            migrationBuilder.DropColumn(
                name: "Type2TypeName",
                table: "Pokemons");

            migrationBuilder.RenameColumn(
                name: "GenerationId",
                table: "Pokemons",
                newName: "Generation");

            migrationBuilder.AddColumn<string>(
                name: "PokemonName",
                table: "PokemonTypes",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Type1",
                table: "Pokemons",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Type2",
                table: "Pokemons",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumn: "TypeName",
                keyValue: "Bug",
                column: "PokemonName",
                value: null);

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumn: "TypeName",
                keyValue: "Dark",
                column: "PokemonName",
                value: null);

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumn: "TypeName",
                keyValue: "Dragon",
                column: "PokemonName",
                value: null);

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumn: "TypeName",
                keyValue: "Electric",
                column: "PokemonName",
                value: null);

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumn: "TypeName",
                keyValue: "Fairy",
                column: "PokemonName",
                value: null);

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumn: "TypeName",
                keyValue: "Fighting",
                column: "PokemonName",
                value: null);

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumn: "TypeName",
                keyValue: "Fire",
                column: "PokemonName",
                value: null);

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumn: "TypeName",
                keyValue: "Flying",
                column: "PokemonName",
                value: null);

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumn: "TypeName",
                keyValue: "Ghost",
                column: "PokemonName",
                value: null);

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumn: "TypeName",
                keyValue: "Grass",
                column: "PokemonName",
                value: null);

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumn: "TypeName",
                keyValue: "Ground",
                column: "PokemonName",
                value: null);

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumn: "TypeName",
                keyValue: "Ice",
                column: "PokemonName",
                value: null);

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumn: "TypeName",
                keyValue: "Normal",
                column: "PokemonName",
                value: null);

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumn: "TypeName",
                keyValue: "Poison",
                column: "PokemonName",
                value: null);

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumn: "TypeName",
                keyValue: "Psychic",
                column: "PokemonName",
                value: null);

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumn: "TypeName",
                keyValue: "Rock",
                column: "PokemonName",
                value: null);

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumn: "TypeName",
                keyValue: "Steel",
                column: "PokemonName",
                value: null);

            migrationBuilder.UpdateData(
                table: "PokemonTypes",
                keyColumn: "TypeName",
                keyValue: "Water",
                column: "PokemonName",
                value: null);

            migrationBuilder.InsertData(
                table: "Pokemons",
                columns: new[] { "PokemonName", "DexNumber", "Generation", "Type1", "Type2" },
                values: new object[] { "Bulbasaur", 1, 1, "Grass", "Poison" });

            migrationBuilder.CreateIndex(
                name: "IX_PokemonTypes_PokemonName",
                table: "PokemonTypes",
                column: "PokemonName");

            migrationBuilder.AddForeignKey(
                name: "FK_PokemonTypes_Pokemons_PokemonName",
                table: "PokemonTypes",
                column: "PokemonName",
                principalTable: "Pokemons",
                principalColumn: "PokemonName");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PokemonTypes_Pokemons_PokemonName",
                table: "PokemonTypes");

            migrationBuilder.DropIndex(
                name: "IX_PokemonTypes_PokemonName",
                table: "PokemonTypes");

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "PokemonName",
                keyValue: "Bulbasaur");

            migrationBuilder.DropColumn(
                name: "PokemonName",
                table: "PokemonTypes");

            migrationBuilder.DropColumn(
                name: "Type1",
                table: "Pokemons");

            migrationBuilder.DropColumn(
                name: "Type2",
                table: "Pokemons");

            migrationBuilder.RenameColumn(
                name: "Generation",
                table: "Pokemons",
                newName: "GenerationId");

            migrationBuilder.AddColumn<string>(
                name: "Type1TypeName",
                table: "Pokemons",
                type: "nvarchar(100)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Type2TypeName",
                table: "Pokemons",
                type: "nvarchar(100)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pokemons_GenerationId",
                table: "Pokemons",
                column: "GenerationId");

            migrationBuilder.CreateIndex(
                name: "IX_Pokemons_Type1TypeName",
                table: "Pokemons",
                column: "Type1TypeName");

            migrationBuilder.CreateIndex(
                name: "IX_Pokemons_Type2TypeName",
                table: "Pokemons",
                column: "Type2TypeName");

            migrationBuilder.AddForeignKey(
                name: "FK_Pokemons_Generations_GenerationId",
                table: "Pokemons",
                column: "GenerationId",
                principalTable: "Generations",
                principalColumn: "GenerationId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Pokemons_PokemonTypes_Type1TypeName",
                table: "Pokemons",
                column: "Type1TypeName",
                principalTable: "PokemonTypes",
                principalColumn: "TypeName",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Pokemons_PokemonTypes_Type2TypeName",
                table: "Pokemons",
                column: "Type2TypeName",
                principalTable: "PokemonTypes",
                principalColumn: "TypeName");
        }
    }
}
