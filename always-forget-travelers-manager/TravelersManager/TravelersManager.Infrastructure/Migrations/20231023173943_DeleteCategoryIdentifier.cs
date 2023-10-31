using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TravelersManager.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class DeleteCategoryIdentifier : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CategoryIdentifier",
                table: "Category");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoryIdentifier",
                table: "Category",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
