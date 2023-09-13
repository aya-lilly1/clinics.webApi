using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

#nullable disable

namespace Clinic_DbModel.Migrations
{
    public partial class identityTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "patient",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    LastName = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    Email = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    BloodGroup = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true),
                    StreetAddress = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true),
                    City = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true),
                    Country = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true),
                    Password = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    ConfirmPassword = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_patient", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "RoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<string>(type: "longtext", nullable: true),
                    ClaimType = table.Column<string>(type: "longtext", nullable: true),
                    ClaimValue = table.Column<string>(type: "longtext", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleClaims", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false),
                    Name = table.Column<string>(type: "longtext", nullable: true),
                    NormalizedName = table.Column<string>(type: "longtext", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "longtext", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "specialization",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    SpecialtyName = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false),
                    IsDelete = table.Column<sbyte>(type: "tinyint", nullable: false, defaultValueSql: "'0'")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_specialization", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "UserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(type: "longtext", nullable: true),
                    ClaimType = table.Column<string>(type: "longtext", nullable: true),
                    ClaimValue = table.Column<string>(type: "longtext", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserClaims", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "UserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "longtext", nullable: true),
                    ProviderKey = table.Column<string>(type: "longtext", nullable: true),
                    ProviderDisplayName = table.Column<string>(type: "longtext", nullable: true),
                    UserId = table.Column<string>(type: "longtext", nullable: true)
                },
                constraints: table =>
                {
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "longtext", nullable: true),
                    RoleId = table.Column<string>(type: "longtext", nullable: true)
                },
                constraints: table =>
                {
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false),
                    UserName = table.Column<string>(type: "longtext", nullable: true),
                    NormalizedUserName = table.Column<string>(type: "longtext", nullable: true),
                    Email = table.Column<string>(type: "longtext", nullable: true),
                    NormalizedEmail = table.Column<string>(type: "longtext", nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    PasswordHash = table.Column<string>(type: "longtext", nullable: true),
                    SecurityStamp = table.Column<string>(type: "longtext", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "longtext", nullable: true),
                    PhoneNumber = table.Column<string>(type: "longtext", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetime(6)", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "UserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "longtext", nullable: true),
                    LoginProvider = table.Column<string>(type: "longtext", nullable: true),
                    Name = table.Column<string>(type: "longtext", nullable: true),
                    Value = table.Column<string>(type: "longtext", nullable: true)
                },
                constraints: table =>
                {
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "review",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Patient_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_review", x => x.Id);
                    table.ForeignKey(
                        name: "fk_review_patient",
                        column: x => x.Patient_Id,
                        principalTable: "patient",
                        principalColumn: "Id");
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "doctor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    LastName = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    Username = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true),
                    Email = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    Gender = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true),
                    AboutMe = table.Column<string>(type: "longtext", nullable: true),
                    Address = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true),
                    City = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true),
                    Country = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true),
                    DoctorSpecialization = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true),
                    DoctorServices = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true),
                    DoctorImage = table.Column<string>(type: "longtext", nullable: true),
                    Degree = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true),
                    College = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true),
                    YearOfCompletion = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true),
                    Specialty_Id = table.Column<int>(type: "int", nullable: true),
                    Password = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    ConfirmPassword = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_doctor", x => x.Id);
                    table.ForeignKey(
                        name: "fk_doctor_specialization",
                        column: x => x.Specialty_Id,
                        principalTable: "specialization",
                        principalColumn: "Id");
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "appointment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Patient_Id = table.Column<int>(type: "int", nullable: false),
                    Doctor_Id = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Day = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false),
                    Time = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    IsDeleted = table.Column<sbyte>(type: "tinyint", nullable: true, defaultValueSql: "'0'")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_appointment", x => x.Id);
                    table.ForeignKey(
                        name: "fk_appointment_doctor",
                        column: x => x.Doctor_Id,
                        principalTable: "doctor",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "fk_appointment_patient",
                        column: x => x.Patient_Id,
                        principalTable: "patient",
                        principalColumn: "Id");
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "blog",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Doctor_Id = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true),
                    Content = table.Column<string>(type: "longtext", nullable: false),
                    Image = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true),
                    IsDeleted = table.Column<sbyte>(type: "tinyint", nullable: true, defaultValueSql: "'0'")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_blog", x => x.Id);
                    table.ForeignKey(
                        name: "fk_blog_doctor",
                        column: x => x.Doctor_Id,
                        principalTable: "doctor",
                        principalColumn: "Id");
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "clinic",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    ClinicName = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false),
                    Doctor_Id = table.Column<int>(type: "int", nullable: false),
                    ClinicAddress = table.Column<string>(type: "longtext", nullable: true)
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
                name: "scheduletimings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Doctor_Id = table.Column<int>(type: "int", nullable: false),
                    TimeDuration = table.Column<int>(type: "int", nullable: false),
                    Day = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true),
                    Time = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_scheduletimings", x => x.Id);
                    table.ForeignKey(
                        name: "fk_scheduletiming_doctor",
                        column: x => x.Doctor_Id,
                        principalTable: "doctor",
                        principalColumn: "Id");
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "socialmediaurl",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Doctor_Id = table.Column<int>(type: "int", nullable: false),
                    FacebookURL = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true),
                    TwitterURL = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true),
                    InstagramURL = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true),
                    LinkedInURL = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true),
                    WebsiteURL = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_socialmediaurl", x => x.Id);
                    table.ForeignKey(
                        name: "fk_socialmediaurl_doctor",
                        column: x => x.Doctor_Id,
                        principalTable: "doctor",
                        principalColumn: "Id");
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "fk_appointment_doctor_idx",
                table: "appointment",
                column: "Doctor_Id");

            migrationBuilder.CreateIndex(
                name: "fk_appointment_patient_idx",
                table: "appointment",
                column: "Patient_Id");

            migrationBuilder.CreateIndex(
                name: "Id_UNIQUE",
                table: "appointment",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "fk_blog_doctor_idx",
                table: "blog",
                column: "Doctor_Id");

            migrationBuilder.CreateIndex(
                name: "Id_UNIQUE1",
                table: "blog",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "fk_clinic_doctor_idx",
                table: "clinic",
                column: "Doctor_Id");

            migrationBuilder.CreateIndex(
                name: "Id_UNIQUE2",
                table: "clinic",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "Email_UNIQUE",
                table: "doctor",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "fk_doctor_specialty_idx",
                table: "doctor",
                column: "Specialty_Id");

            migrationBuilder.CreateIndex(
                name: "Id_UNIQUE3",
                table: "doctor",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "fk_review_patient_idx",
                table: "review",
                column: "Patient_Id");

            migrationBuilder.CreateIndex(
                name: "Id_UNIQUE4",
                table: "review",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "fk_scheduletiming_doctor_idx",
                table: "scheduletimings",
                column: "Doctor_Id");

            migrationBuilder.CreateIndex(
                name: "Id_UNIQUE5",
                table: "scheduletimings",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "fk_socialmediaurl_doctor_idx",
                table: "socialmediaurl",
                column: "Doctor_Id");

            migrationBuilder.CreateIndex(
                name: "Id_UNIQUE6",
                table: "socialmediaurl",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "Id_UNIQUE7",
                table: "specialization",
                column: "Id",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "appointment");

            migrationBuilder.DropTable(
                name: "blog");

            migrationBuilder.DropTable(
                name: "clinic");

            migrationBuilder.DropTable(
                name: "review");

            migrationBuilder.DropTable(
                name: "RoleClaims");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "scheduletimings");

            migrationBuilder.DropTable(
                name: "socialmediaurl");

            migrationBuilder.DropTable(
                name: "UserClaims");

            migrationBuilder.DropTable(
                name: "UserLogins");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "UserTokens");

            migrationBuilder.DropTable(
                name: "patient");

            migrationBuilder.DropTable(
                name: "doctor");

            migrationBuilder.DropTable(
                name: "specialization");
        }
    }
}
