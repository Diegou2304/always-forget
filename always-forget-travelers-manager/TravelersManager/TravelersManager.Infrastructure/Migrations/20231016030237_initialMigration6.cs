using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TravelersManager.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class initialMigration6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CategoryName",
                table: "Category",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CategoryName",
                table: "Category");
        }
    }
}
