using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Clinic_DbModel.Migrations
{
    public partial class newupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Time",
                table: "scheduletimings");

            migrationBuilder.RenameColumn(
                name: "TimeDuration",
                table: "scheduletimings",
                newName: "DurationTime");

            migrationBuilder.AddColumn<DateTime>(
                name: "EndTime",
                table: "scheduletimings",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "StartTime",
                table: "scheduletimings",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EndTime",
                table: "scheduletimings");

            migrationBuilder.DropColumn(
                name: "StartTime",
                table: "scheduletimings");

            migrationBuilder.RenameColumn(
                name: "DurationTime",
                table: "scheduletimings",
                newName: "TimeDuration");

            migrationBuilder.AddColumn<DateTime>(
                name: "Time",
                table: "scheduletimings",
                type: "datetime(6)",
                nullable: true);
        }
    }
}
