using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CourseWork.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Flights",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    StartLocation = table.Column<string>(type: "TEXT", maxLength: 255, nullable: false),
                    EndLocation = table.Column<string>(type: "TEXT", maxLength: 255, nullable: false),
                    Distance = table.Column<int>(type: "INTEGER", nullable: false),
                    StartTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    EndTime = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Flights", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Planes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Model = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    LicensePlate = table.Column<string>(type: "TEXT", maxLength: 6, nullable: false),
                    Capacity = table.Column<int>(type: "INTEGER", nullable: false),
                    LastMaintenanceDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    FlyingTime = table.Column<double>(type: "REAL", nullable: false),
                    FlightId = table.Column<int>(type: "INTEGER", nullable: true),
                    PilotId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Planes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Planes_Flights_FlightId",
                        column: x => x.FlightId,
                        principalTable: "Flights",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Pilots",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstName = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Age = table.Column<int>(type: "INTEGER", nullable: false),
                    FlyingExperience = table.Column<int>(type: "INTEGER", nullable: false),
                    PlaneId = table.Column<int>(type: "INTEGER", nullable: true),
                    FlightId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pilots", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pilots_Flights_FlightId",
                        column: x => x.FlightId,
                        principalTable: "Flights",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Pilots_Planes_PlaneId",
                        column: x => x.PlaneId,
                        principalTable: "Planes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pilots_FlightId",
                table: "Pilots",
                column: "FlightId");

            migrationBuilder.CreateIndex(
                name: "IX_Pilots_PlaneId",
                table: "Pilots",
                column: "PlaneId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Planes_FlightId",
                table: "Planes",
                column: "FlightId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pilots");

            migrationBuilder.DropTable(
                name: "Planes");

            migrationBuilder.DropTable(
                name: "Flights");
        }
    }
}
