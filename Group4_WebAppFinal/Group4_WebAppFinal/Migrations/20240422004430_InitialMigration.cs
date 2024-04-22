using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Group4_WebAppFinal.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bags",
                columns: table => new
                {
                    ItemName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ItemQuantity = table.Column<int>(type: "int", nullable: false),
                    ItemType = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bags", x => x.ItemName);
                });

            migrationBuilder.CreateTable(
                name: "Pokemons",
                columns: table => new
                {
                    DexNumberID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PokemonName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type1 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Type2 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pokemons", x => x.DexNumberID);
                });

            migrationBuilder.CreateTable(
                name: "PokemonTypes",
                columns: table => new
                {
                    TypeName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PokemonDexNumberID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PokemonTypes", x => x.TypeName);
                    table.ForeignKey(
                        name: "FK_PokemonTypes_Pokemons_PokemonDexNumberID",
                        column: x => x.PokemonDexNumberID,
                        principalTable: "Pokemons",
                        principalColumn: "DexNumberID");
                });

            migrationBuilder.CreateTable(
                name: "Teams",
                columns: table => new
                {
                    TeamId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PokemonDexNumberID = table.Column<int>(type: "int", nullable: false),
                    BagItemName = table.Column<string>(type: "nvarchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => x.TeamId);
                    table.ForeignKey(
                        name: "FK_Teams_Bags_BagItemName",
                        column: x => x.BagItemName,
                        principalTable: "Bags",
                        principalColumn: "ItemName");
                    table.ForeignKey(
                        name: "FK_Teams_Pokemons_PokemonDexNumberID",
                        column: x => x.PokemonDexNumberID,
                        principalTable: "Pokemons",
                        principalColumn: "DexNumberID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Bags",
                columns: new[] { "ItemName", "Description", "ItemQuantity", "ItemType" },
                values: new object[] { "Potion", "Restores 10HP", 1, "Consumable" });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "TypeName", "PokemonDexNumberID" },
                values: new object[,]
                {
                    { "Bug", null },
                    { "Dark", null },
                    { "Dragon", null },
                    { "Electric", null },
                    { "Fairy", null },
                    { "Fighting", null },
                    { "Fire", null },
                    { "Flying", null },
                    { "Ghost", null },
                    { "Grass", null },
                    { "Ground", null },
                    { "Ice", null },
                    { "None", null },
                    { "Normal", null },
                    { "Poison", null },
                    { "Psychic", null },
                    { "Rock", null },
                    { "Steel", null },
                    { "Water", null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_PokemonTypes_PokemonDexNumberID",
                table: "PokemonTypes",
                column: "PokemonDexNumberID");

            migrationBuilder.CreateIndex(
                name: "IX_Teams_BagItemName",
                table: "Teams",
                column: "BagItemName");

            migrationBuilder.CreateIndex(
                name: "IX_Teams_PokemonDexNumberID",
                table: "Teams",
                column: "PokemonDexNumberID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PokemonTypes");

            migrationBuilder.DropTable(
                name: "Teams");

            migrationBuilder.DropTable(
                name: "Bags");

            migrationBuilder.DropTable(
                name: "Pokemons");
        }
    }
}
