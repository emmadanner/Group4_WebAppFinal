using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Group4_WebAppFinal.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedPrimaryKeys : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Bags",
                table: "Bags");

            migrationBuilder.DropColumn(
                name: "ItemName",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "BagId",
                table: "Bags");

            migrationBuilder.AddColumn<string>(
                name: "BagItemName",
                table: "Teams",
                type: "nvarchar(100)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Bags",
                table: "Bags",
                column: "ItemName");

            migrationBuilder.CreateIndex(
                name: "IX_Teams_BagItemName",
                table: "Teams",
                column: "BagItemName");

            migrationBuilder.AddForeignKey(
                name: "FK_Teams_Bags_BagItemName",
                table: "Teams",
                column: "BagItemName",
                principalTable: "Bags",
                principalColumn: "ItemName");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Teams_Bags_BagItemName",
                table: "Teams");

            migrationBuilder.DropIndex(
                name: "IX_Teams_BagItemName",
                table: "Teams");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Bags",
                table: "Bags");

            migrationBuilder.DropColumn(
                name: "BagItemName",
                table: "Teams");

            migrationBuilder.AddColumn<string>(
                name: "ItemName",
                table: "Teams",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BagId",
                table: "Bags",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Bags",
                table: "Bags",
                column: "BagId");
        }
    }
}
