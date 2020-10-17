using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FinalProject.Data.Migrations
{
    public partial class PortfolioTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "About",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "CV",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfBirth",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Gender",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MajorName",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "PersonalImage",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PortfolioEmail",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SecondName",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Vision",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Degrees",
                columns: table => new
                {
                    DegreeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DegreeName = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Degrees", x => x.DegreeId);
                });

            migrationBuilder.CreateTable(
                name: "InterpersonalSkills",
                columns: table => new
                {
                    InterpersonalSkillId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InterpersonalName = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InterpersonalSkills", x => x.InterpersonalSkillId);
                });

            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    ProjectId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectImage = table.Column<byte[]>(nullable: false),
                    ProjectName = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: false),
                    uploadProject = table.Column<byte[]>(nullable: false),
                    UserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.ProjectId);
                    table.ForeignKey(
                        name: "FK_Projects_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TechnicalSkills",
                columns: table => new
                {
                    TechnicalSkillId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TechnicalName = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TechnicalSkills", x => x.TechnicalSkillId);
                });

            migrationBuilder.CreateTable(
                name: "Universites",
                columns: table => new
                {
                    UniversityId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UniversityName = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Universites", x => x.UniversityId);
                });

            migrationBuilder.CreateTable(
                name: "UserSkills",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    InterpersonalSkillId = table.Column<int>(nullable: false),
                    TechnicalSkillId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserSkills", x => new { x.UserId, x.InterpersonalSkillId, x.TechnicalSkillId });
                    table.ForeignKey(
                        name: "FK_UserSkills_InterpersonalSkills_InterpersonalSkillId",
                        column: x => x.InterpersonalSkillId,
                        principalTable: "InterpersonalSkills",
                        principalColumn: "InterpersonalSkillId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserSkills_TechnicalSkills_TechnicalSkillId",
                        column: x => x.TechnicalSkillId,
                        principalTable: "TechnicalSkills",
                        principalColumn: "TechnicalSkillId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserSkills_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserUniversities",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    UniversityId = table.Column<int>(nullable: false),
                    DegreeId = table.Column<int>(nullable: false),
                    major = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserUniversities", x => new { x.UserId, x.UniversityId, x.DegreeId });
                    table.ForeignKey(
                        name: "FK_UserUniversities_Degrees_DegreeId",
                        column: x => x.DegreeId,
                        principalTable: "Degrees",
                        principalColumn: "DegreeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserUniversities_Universites_UniversityId",
                        column: x => x.UniversityId,
                        principalTable: "Universites",
                        principalColumn: "UniversityId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserUniversities_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Projects_UserId",
                table: "Projects",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserSkills_InterpersonalSkillId",
                table: "UserSkills",
                column: "InterpersonalSkillId");

            migrationBuilder.CreateIndex(
                name: "IX_UserSkills_TechnicalSkillId",
                table: "UserSkills",
                column: "TechnicalSkillId");

            migrationBuilder.CreateIndex(
                name: "IX_UserUniversities_DegreeId",
                table: "UserUniversities",
                column: "DegreeId");

            migrationBuilder.CreateIndex(
                name: "IX_UserUniversities_UniversityId",
                table: "UserUniversities",
                column: "UniversityId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Projects");

            migrationBuilder.DropTable(
                name: "UserSkills");

            migrationBuilder.DropTable(
                name: "UserUniversities");

            migrationBuilder.DropTable(
                name: "InterpersonalSkills");

            migrationBuilder.DropTable(
                name: "TechnicalSkills");

            migrationBuilder.DropTable(
                name: "Degrees");

            migrationBuilder.DropTable(
                name: "Universites");

            migrationBuilder.DropColumn(
                name: "About",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "CV",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "DateOfBirth",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "MajorName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "PersonalImage",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "PortfolioEmail",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "SecondName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Vision",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUsers");
        }
    }
}
