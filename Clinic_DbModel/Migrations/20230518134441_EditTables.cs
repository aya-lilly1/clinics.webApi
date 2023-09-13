using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

#nullable disable

namespace Clinic_DbModel.Migrations
{
    public partial class EditTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_appointment_patient",
                table: "appointment");

            migrationBuilder.DropForeignKey(
                name: "fk_review_patient",
                table: "review");

            migrationBuilder.DropTable(
                name: "clinic");

            migrationBuilder.DropTable(
                name: "patient");

            migrationBuilder.DropIndex(
                name: "fk_review_patient_idx",
                table: "review");

            migrationBuilder.DropIndex(
                name: "Email_UNIQUE",
                table: "doctor");

            migrationBuilder.DropIndex(
                name: "fk_appointment_patient_idx",
                table: "appointment");

            migrationBuilder.DropColumn(
                name: "Patient_Id",
                table: "review");

            migrationBuilder.DropColumn(
                name: "City",
                table: "doctor");

            migrationBuilder.DropColumn(
                name: "ConfirmPassword",
                table: "doctor");

            migrationBuilder.DropColumn(
                name: "Country",
                table: "doctor");

            migrationBuilder.DropColumn(
                name: "DateOfBirth",
                table: "doctor");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "doctor");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "doctor");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "doctor");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "doctor");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "doctor");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "doctor");

            migrationBuilder.DropColumn(
                name: "Username",
                table: "doctor");

            migrationBuilder.DropColumn(
                name: "Patient_Id",
                table: "appointment");

            migrationBuilder.RenameIndex(
                name: "Id_UNIQUE7",
                table: "specialization",
                newName: "Id_UNIQUE6");

            migrationBuilder.RenameIndex(
                name: "Id_UNIQUE6",
                table: "socialmediaurl",
                newName: "Id_UNIQUE5");

            migrationBuilder.RenameIndex(
                name: "Id_UNIQUE5",
                table: "scheduletimings",
                newName: "Id_UNIQUE4");

            migrationBuilder.RenameIndex(
                name: "Id_UNIQUE4",
                table: "review",
                newName: "Id_UNIQUE3");

            migrationBuilder.RenameColumn(
                name: "DoctorImage",
                table: "doctor",
                newName: "Cliniclicense");

            migrationBuilder.RenameIndex(
                name: "Id_UNIQUE3",
                table: "doctor",
                newName: "Id_UNIQUE2");

            migrationBuilder.AddColumn<string>(
                name: "BloodGroup",
                table: "Users",
                type: "longtext",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Users",
                type: "longtext",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "Users",
                type: "longtext",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfBirth",
                table: "Users",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Users",
                type: "varchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "Users",
                type: "longtext",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Users",
                type: "longtext",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Users",
                type: "varchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "User_Id",
                table: "review",
                type: "varchar(255)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ClinicAddress",
                table: "doctor",
                type: "longtext",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ClinicName",
                table: "doctor",
                type: "longtext",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "User_Id",
                table: "appointment",
                type: "varchar(255)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "fk_review_user_idx",
                table: "review",
                column: "User_Id");

            migrationBuilder.CreateIndex(
                name: "fk_appointment_user_idx",
                table: "appointment",
                column: "User_Id");

            migrationBuilder.AddForeignKey(
                name: "fk_appointment_patient",
                table: "appointment",
                column: "User_Id",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "fk_review_user",
                table: "review",
                column: "User_Id",
                principalTable: "Users",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_appointment_patient",
                table: "appointment");

            migrationBuilder.DropForeignKey(
                name: "fk_review_user",
                table: "review");

            migrationBuilder.DropIndex(
                name: "fk_review_user_idx",
                table: "review");

            migrationBuilder.DropIndex(
                name: "fk_appointment_user_idx",
                table: "appointment");

            migrationBuilder.DropColumn(
                name: "BloodGroup",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "City",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Country",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "DateOfBirth",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Image",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "User_Id",
                table: "review");

            migrationBuilder.DropColumn(
                name: "ClinicAddress",
                table: "doctor");

            migrationBuilder.DropColumn(
                name: "ClinicName",
                table: "doctor");

            migrationBuilder.DropColumn(
                name: "User_Id",
                table: "appointment");

            migrationBuilder.RenameIndex(
                name: "Id_UNIQUE6",
                table: "specialization",
                newName: "Id_UNIQUE7");

            migrationBuilder.RenameIndex(
                name: "Id_UNIQUE5",
                table: "socialmediaurl",
                newName: "Id_UNIQUE6");

            migrationBuilder.RenameIndex(
                name: "Id_UNIQUE4",
                table: "scheduletimings",
                newName: "Id_UNIQUE5");

            migrationBuilder.RenameIndex(
                name: "Id_UNIQUE3",
                table: "review",
                newName: "Id_UNIQUE4");

            migrationBuilder.RenameColumn(
                name: "Cliniclicense",
                table: "doctor",
                newName: "DoctorImage");

            migrationBuilder.RenameIndex(
                name: "Id_UNIQUE2",
                table: "doctor",
                newName: "Id_UNIQUE3");

            migrationBuilder.AddColumn<int>(
                name: "Patient_Id",
                table: "review",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "doctor",
                type: "varchar(255)",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ConfirmPassword",
                table: "doctor",
                type: "varchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "doctor",
                type: "varchar(45)",
                maxLength: 45,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfBirth",
                table: "doctor",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "doctor",
                type: "varchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "doctor",
                type: "varchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "doctor",
                type: "varchar(45)",
                maxLength: 45,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "doctor",
                type: "varchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "doctor",
                type: "varchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "doctor",
                type: "varchar(255)",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Username",
                table: "doctor",
                type: "varchar(45)",
                maxLength: 45,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Patient_Id",
                table: "appointment",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "clinic",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Doctor_Id = table.Column<int>(type: "int", nullable: false),
                    ClinicAddress = table.Column<string>(type: "longtext", nullable: true),
                    ClinicName = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_clinic", x => x.Id);
                    table.ForeignKey(
                        name: "fk_clinic_doctor",
                        column: x => x.Doctor_Id,
                        principalTable: "doctor",
                        principalColumn: "Id");
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "patient",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    BloodGroup = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true),
                    City = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true),
                    ConfirmPassword = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    Country = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    Email = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    FirstName = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    LastName = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    Password = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    StreetAddress = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_patient", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "fk_review_patient_idx",
                table: "review",
                column: "Patient_Id");

            migrationBuilder.CreateIndex(
                name: "Email_UNIQUE",
                table: "doctor",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "fk_appointment_patient_idx",
                table: "appointment",
                column: "Patient_Id");

            migrationBuilder.CreateIndex(
                name: "fk_clinic_doctor_idx",
                table: "clinic",
                column: "Doctor_Id");

            migrationBuilder.CreateIndex(
                name: "Id_UNIQUE2",
                table: "clinic",
                column: "Id",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "fk_appointment_patient",
                table: "appointment",
                column: "Patient_Id",
                principalTable: "patient",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "fk_review_patient",
                table: "review",
                column: "Patient_Id",
                principalTable: "patient",
                principalColumn: "Id");
        }
    }
}
