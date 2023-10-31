using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TravelersManager.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class initialMigration5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Number",
                table: "PhoneNumbers",
                newName: "TelefonicNumber");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TelefonicNumber",
                table: "PhoneNumbers",
                newName: "Number");
        }
    }
}
