using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace tecweb2.webapi.Migrations
{
    public partial class _10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Careers",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Active = table.Column<bool>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Careers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Semesters",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Active = table.Column<bool>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Start = table.Column<DateTimeOffset>(nullable: false),
                    End = table.Column<DateTimeOffset>(nullable: false),
                    Year = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Semesters", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Subjectives",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Active = table.Column<bool>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subjectives", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Active = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Username = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Roles = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CareerSubjectives",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Active = table.Column<bool>(nullable: false),
                    CareerId = table.Column<Guid>(nullable: false),
                    SubjectiveId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CareerSubjectives", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CareerSubjectives_Careers_CareerId",
                        column: x => x.CareerId,
                        principalTable: "Careers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CareerSubjectives_Subjectives_SubjectiveId",
                        column: x => x.SubjectiveId,
                        principalTable: "Subjectives",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Classes",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Active = table.Column<bool>(nullable: false),
                    DayOfWeek = table.Column<int>(nullable: false),
                    SubjectiveId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Classes_Subjectives_SubjectiveId",
                        column: x => x.SubjectiveId,
                        principalTable: "Subjectives",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Itens",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Active = table.Column<bool>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Type = table.Column<int>(nullable: false),
                    SubjectiveId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Itens", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Itens_Subjectives_SubjectiveId",
                        column: x => x.SubjectiveId,
                        principalTable: "Subjectives",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SubjectiveSemesters",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Active = table.Column<bool>(nullable: false),
                    SubjectiveId = table.Column<Guid>(nullable: false),
                    SemesterId = table.Column<Guid>(nullable: false),
                    EndDateTeachingPlan = table.Column<DateTimeOffset>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubjectiveSemesters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubjectiveSemesters_Semesters_SemesterId",
                        column: x => x.SemesterId,
                        principalTable: "Semesters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SubjectiveSemesters_Subjectives_SubjectiveId",
                        column: x => x.SubjectiveId,
                        principalTable: "Subjectives",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TeachingPlans",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Active = table.Column<bool>(nullable: false),
                    MasterId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeachingPlans", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TeachingPlans_Users_MasterId",
                        column: x => x.MasterId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserCareers",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Active = table.Column<bool>(nullable: false),
                    UserId = table.Column<Guid>(nullable: false),
                    CareerId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserCareers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserCareers_Careers_CareerId",
                        column: x => x.CareerId,
                        principalTable: "Careers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserCareers_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserSubjectives",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Active = table.Column<bool>(nullable: false),
                    UserId = table.Column<Guid>(nullable: false),
                    SubjectiveId = table.Column<Guid>(nullable: false),
                    Master = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserSubjectives", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserSubjectives_Subjectives_SubjectiveId",
                        column: x => x.SubjectiveId,
                        principalTable: "Subjectives",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserSubjectives_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TeachingPlanItens",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Active = table.Column<bool>(nullable: false),
                    TeachingPlanId = table.Column<Guid>(nullable: false),
                    ItemId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeachingPlanItens", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TeachingPlanItens_Itens_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Itens",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TeachingPlanItens_TeachingPlans_TeachingPlanId",
                        column: x => x.TeachingPlanId,
                        principalTable: "TeachingPlans",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TeachingPlanLogs",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Active = table.Column<bool>(nullable: false),
                    Date = table.Column<DateTimeOffset>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    TeachingPlanId = table.Column<Guid>(nullable: false),
                    TeacingPlanId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeachingPlanLogs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TeachingPlanLogs_TeachingPlans_TeacingPlanId",
                        column: x => x.TeacingPlanId,
                        principalTable: "TeachingPlans",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CareerSubjectives_CareerId",
                table: "CareerSubjectives",
                column: "CareerId");

            migrationBuilder.CreateIndex(
                name: "IX_CareerSubjectives_SubjectiveId",
                table: "CareerSubjectives",
                column: "SubjectiveId");

            migrationBuilder.CreateIndex(
                name: "IX_Classes_SubjectiveId",
                table: "Classes",
                column: "SubjectiveId");

            migrationBuilder.CreateIndex(
                name: "IX_Itens_SubjectiveId",
                table: "Itens",
                column: "SubjectiveId");

            migrationBuilder.CreateIndex(
                name: "IX_SubjectiveSemesters_SemesterId",
                table: "SubjectiveSemesters",
                column: "SemesterId");

            migrationBuilder.CreateIndex(
                name: "IX_SubjectiveSemesters_SubjectiveId",
                table: "SubjectiveSemesters",
                column: "SubjectiveId");

            migrationBuilder.CreateIndex(
                name: "IX_TeachingPlanItens_ItemId",
                table: "TeachingPlanItens",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_TeachingPlanItens_TeachingPlanId",
                table: "TeachingPlanItens",
                column: "TeachingPlanId");

            migrationBuilder.CreateIndex(
                name: "IX_TeachingPlanLogs_TeacingPlanId",
                table: "TeachingPlanLogs",
                column: "TeacingPlanId");

            migrationBuilder.CreateIndex(
                name: "IX_TeachingPlans_MasterId",
                table: "TeachingPlans",
                column: "MasterId");

            migrationBuilder.CreateIndex(
                name: "IX_UserCareers_CareerId",
                table: "UserCareers",
                column: "CareerId");

            migrationBuilder.CreateIndex(
                name: "IX_UserCareers_UserId",
                table: "UserCareers",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserSubjectives_SubjectiveId",
                table: "UserSubjectives",
                column: "SubjectiveId");

            migrationBuilder.CreateIndex(
                name: "IX_UserSubjectives_UserId",
                table: "UserSubjectives",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CareerSubjectives");

            migrationBuilder.DropTable(
                name: "Classes");

            migrationBuilder.DropTable(
                name: "SubjectiveSemesters");

            migrationBuilder.DropTable(
                name: "TeachingPlanItens");

            migrationBuilder.DropTable(
                name: "TeachingPlanLogs");

            migrationBuilder.DropTable(
                name: "UserCareers");

            migrationBuilder.DropTable(
                name: "UserSubjectives");

            migrationBuilder.DropTable(
                name: "Semesters");

            migrationBuilder.DropTable(
                name: "Itens");

            migrationBuilder.DropTable(
                name: "TeachingPlans");

            migrationBuilder.DropTable(
                name: "Careers");

            migrationBuilder.DropTable(
                name: "Subjectives");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
