using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace covid19.web.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CoronaֹVaccine",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Corona_Vaccine1 = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Corona_Manufacturer1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Corona_Vaccine2 = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Corona_Manufacturer2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Corona_Vaccine3 = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Corona_Manufacturer3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Corona_Vaccine4 = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Corona_Manufacturer4 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CoronaֹVaccine", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Patients",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    full_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date_Of_Birth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Telphone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mobile_Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Covid_Positive_Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Covid_Recovery_Date = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patients", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CoronaֹVaccine");

            migrationBuilder.DropTable(
                name: "Patients");
        }
    }
}
