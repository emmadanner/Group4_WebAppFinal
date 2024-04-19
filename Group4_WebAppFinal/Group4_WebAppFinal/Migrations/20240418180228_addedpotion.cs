using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Group4_WebAppFinal.Migrations
{
    /// <inheritdoc />
    public partial class addedpotion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Bags",
                columns: new[] { "ItemName", "Description", "ItemQuantity", "ItemType" },
                values: new object[] { "Potion", "Restores 10HP", 1, "Consumable" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Bags",
                keyColumn: "ItemName",
                keyValue: "Potion");
        }
    }
}
