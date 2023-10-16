using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TravelersManager.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class initialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Address",
                columns: table => new
                {
                    AddressId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Direction = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.AddressId);
                });

            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TravelerId = table.Column<int>(type: "int", nullable: false),
                    CategoryIdentifier = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "PhoneNumbers",
                columns: table => new
                {
                    PhoneNumberId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhoneNumbers", x => x.PhoneNumberId);
                });

            migrationBuilder.CreateTable(
                name: "Travelers",
                columns: table => new
                {
                    TravelerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Birthdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Dni = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CivilState = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Travelers", x => x.TravelerId);
                    table.ForeignKey(
                        name: "FK_Travelers_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TravelerAddress",
                columns: table => new
                {
                    TravelerId = table.Column<int>(type: "int", nullable: false),
                    AddressesAddressId = table.Column<int>(type: "int", nullable: false),
                    AdressId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TravelerAddress", x => new { x.AddressesAddressId, x.TravelerId });
                    table.ForeignKey(
                        name: "FK_TravelerAddress_Address_AddressesAddressId",
                        column: x => x.AddressesAddressId,
                        principalTable: "Address",
                        principalColumn: "AddressId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TravelerAddress_Travelers_TravelerId",
                        column: x => x.TravelerId,
                        principalTable: "Travelers",
                        principalColumn: "TravelerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TravelerNumbers",
                columns: table => new
                {
                    TravelerId = table.Column<int>(type: "int", nullable: false),
                    PhoneNumberId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TravelerNumbers", x => new { x.PhoneNumberId, x.TravelerId });
                    table.ForeignKey(
                        name: "FK_TravelerNumbers_PhoneNumbers_PhoneNumberId",
                        column: x => x.PhoneNumberId,
                        principalTable: "PhoneNumbers",
                        principalColumn: "PhoneNumberId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TravelerNumbers_Travelers_TravelerId",
                        column: x => x.TravelerId,
                        principalTable: "Travelers",
                        principalColumn: "TravelerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TravelerAddress_TravelerId",
                table: "TravelerAddress",
                column: "TravelerId");

            migrationBuilder.CreateIndex(
                name: "IX_TravelerNumbers_TravelerId",
                table: "TravelerNumbers",
                column: "TravelerId");

            migrationBuilder.CreateIndex(
                name: "IX_Travelers_CategoryId",
                table: "Travelers",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TravelerAddress");

            migrationBuilder.DropTable(
                name: "TravelerNumbers");

            migrationBuilder.DropTable(
                name: "Address");

            migrationBuilder.DropTable(
                name: "PhoneNumbers");

            migrationBuilder.DropTable(
                name: "Travelers");

            migrationBuilder.DropTable(
                name: "Category");
        }
    }
}
