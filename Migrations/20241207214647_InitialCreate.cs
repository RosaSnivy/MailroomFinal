using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MailroomFinal.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Residents",
                columns: table => new
                {
                    ResidentID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    name = table.Column<string>(type: "TEXT", nullable: false),
                    email = table.Column<string>(type: "TEXT", nullable: false),
                    unitNumber = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Residents", x => x.ResidentID);
                });

            migrationBuilder.CreateTable(
                name: "StaffLogins",
                columns: table => new
                {
                    StaffLoginID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    username = table.Column<string>(type: "TEXT", nullable: false),
                    password = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StaffLogins", x => x.StaffLoginID);
                });

            migrationBuilder.CreateTable(
                name: "UnknownPackages",
                columns: table => new
                {
                    UnknownPackageID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    name = table.Column<string>(type: "TEXT", nullable: false),
                    postalService = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnknownPackages", x => x.UnknownPackageID);
                });

            migrationBuilder.CreateTable(
                name: "Packages",
                columns: table => new
                {
                    PackageID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    postalService = table.Column<string>(type: "TEXT", nullable: false),
                    ResidentsResidentID = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Packages", x => x.PackageID);
                    table.ForeignKey(
                        name: "FK_Packages_Residents_ResidentsResidentID",
                        column: x => x.ResidentsResidentID,
                        principalTable: "Residents",
                        principalColumn: "ResidentID");
                });

            migrationBuilder.CreateTable(
                name: "Historys",
                columns: table => new
                {
                    HistoryID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PackageID = table.Column<int>(type: "INTEGER", nullable: false),
                    timeReceived = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ResidentID = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Historys", x => x.HistoryID);
                    table.ForeignKey(
                        name: "FK_Historys_Packages_PackageID",
                        column: x => x.PackageID,
                        principalTable: "Packages",
                        principalColumn: "PackageID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Historys_Residents_ResidentID",
                        column: x => x.ResidentID,
                        principalTable: "Residents",
                        principalColumn: "ResidentID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Historys_PackageID",
                table: "Historys",
                column: "PackageID");

            migrationBuilder.CreateIndex(
                name: "IX_Historys_ResidentID",
                table: "Historys",
                column: "ResidentID");

            migrationBuilder.CreateIndex(
                name: "IX_Packages_ResidentsResidentID",
                table: "Packages",
                column: "ResidentsResidentID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Historys");

            migrationBuilder.DropTable(
                name: "StaffLogins");

            migrationBuilder.DropTable(
                name: "UnknownPackages");

            migrationBuilder.DropTable(
                name: "Packages");

            migrationBuilder.DropTable(
                name: "Residents");
        }
    }
}
