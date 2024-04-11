using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Group4_WebAppFinal.Migrations
{
    /// <inheritdoc />
    public partial class AddedAllTablesAndRelationships : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.CreateTable(
                name: "Generations",
                columns: table => new
                {
                    GenerationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GenGames = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Generations", x => x.GenerationId);
                });

            migrationBuilder.CreateTable(
                name: "PokemonTypes",
                columns: table => new
                {
                    TypeName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PokemonTypes", x => x.TypeName);
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropTable(
                name: "Generations");

            migrationBuilder.DropTable(
                name: "PokemonTypes");

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
        }
    }
}
