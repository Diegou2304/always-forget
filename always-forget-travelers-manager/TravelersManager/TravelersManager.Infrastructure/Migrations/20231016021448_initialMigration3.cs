using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TravelersManager.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class initialMigration3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TravelerId",
                table: "Category");

            migrationBuilder.AddColumn<string>(
                name: "Number",
                table: "PhoneNumbers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Number",
                table: "PhoneNumbers");

            migrationBuilder.AddColumn<int>(
                name: "TravelerId",
                table: "Category",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
