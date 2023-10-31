using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TravelersManager.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class initialMigration2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TravelerAddress_Address_AddressesAddressId",
                table: "TravelerAddress");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TravelerAddress",
                table: "TravelerAddress");

            migrationBuilder.DropColumn(
                name: "AddressesAddressId",
                table: "TravelerAddress");

            migrationBuilder.RenameColumn(
                name: "AdressId",
                table: "TravelerAddress",
                newName: "AddressId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TravelerAddress",
                table: "TravelerAddress",
                columns: new[] { "AddressId", "TravelerId" });

            migrationBuilder.AddForeignKey(
                name: "FK_TravelerAddress_Address_AddressId",
                table: "TravelerAddress",
                column: "AddressId",
                principalTable: "Address",
                principalColumn: "AddressId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TravelerAddress_Address_AddressId",
                table: "TravelerAddress");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TravelerAddress",
                table: "TravelerAddress");

            migrationBuilder.RenameColumn(
                name: "AddressId",
                table: "TravelerAddress",
                newName: "AdressId");

            migrationBuilder.AddColumn<int>(
                name: "AddressesAddressId",
                table: "TravelerAddress",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_TravelerAddress",
                table: "TravelerAddress",
                columns: new[] { "AddressesAddressId", "TravelerId" });

            migrationBuilder.AddForeignKey(
                name: "FK_TravelerAddress_Address_AddressesAddressId",
                table: "TravelerAddress",
                column: "AddressesAddressId",
                principalTable: "Address",
                principalColumn: "AddressId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
