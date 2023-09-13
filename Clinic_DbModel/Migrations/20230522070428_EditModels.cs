using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Clinic_DbModel.Migrations
{
    public partial class EditModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Comment",
                table: "review",
                type: "longtext",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DoctorId",
                table: "review",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "doctor",
                type: "varchar(255)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "doctor",
                type: "longtext",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_review_DoctorId",
                table: "review",
                column: "DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_doctor_ApplicationUserId",
                table: "doctor",
                column: "ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_doctor_Users_ApplicationUserId",
                table: "doctor",
                column: "ApplicationUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_review_doctor_DoctorId",
                table: "review",
                column: "DoctorId",
                principalTable: "doctor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_doctor_Users_ApplicationUserId",
                table: "doctor");

            migrationBuilder.DropForeignKey(
                name: "FK_review_doctor_DoctorId",
                table: "review");

            migrationBuilder.DropIndex(
                name: "IX_review_DoctorId",
                table: "review");

            migrationBuilder.DropIndex(
                name: "IX_doctor_ApplicationUserId",
                table: "doctor");

            migrationBuilder.DropColumn(
                name: "Comment",
                table: "review");

            migrationBuilder.DropColumn(
                name: "DoctorId",
                table: "review");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "doctor");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "doctor");
        }
    }
}
