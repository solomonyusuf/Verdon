using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Verdon.Migrations.QuizDb
{
    public partial class seer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PrivateAttempt",
                columns: table => new
                {
                    PrivateAttemptId = table.Column<Guid>(type: "TEXT", nullable: false),
                    UserId = table.Column<string>(type: "TEXT", nullable: true),
                    QuizId = table.Column<int>(type: "INTEGER", nullable: false),
                    PrivateQuestionId = table.Column<Guid>(type: "TEXT", nullable: false),
                    Response = table.Column<string>(type: "TEXT", nullable: true),
                    Answer = table.Column<string>(type: "TEXT", nullable: true),
                    DateTime = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PrivateAttempt", x => x.PrivateAttemptId);
                });

            migrationBuilder.CreateTable(
                name: "PrivateQuiz",
                columns: table => new
                {
                    PrivateQuizId = table.Column<Guid>(type: "TEXT", nullable: false),
                    UserId = table.Column<string>(type: "TEXT", nullable: true),
                    QuizId = table.Column<int>(type: "INTEGER", nullable: false),
                    Department = table.Column<string>(type: "TEXT", nullable: true),
                    Password = table.Column<string>(type: "TEXT", nullable: true),
                    Title = table.Column<string>(type: "TEXT", nullable: true),
                    Duration = table.Column<int>(type: "INTEGER", nullable: false),
                    Visible = table.Column<bool>(type: "INTEGER", nullable: false),
                    Factor = table.Column<int>(type: "INTEGER", nullable: false),
                    DateTime = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PrivateQuiz", x => x.PrivateQuizId);
                });

            migrationBuilder.CreateTable(
                name: "Track",
                columns: table => new
                {
                    TrackId = table.Column<string>(type: "TEXT", nullable: false),
                    QId = table.Column<string>(type: "TEXT", nullable: true),
                    DateTime = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Track", x => x.TrackId);
                });

            migrationBuilder.CreateTable(
                name: "PrivateQuestion",
                columns: table => new
                {
                    PrivateQuestionId = table.Column<Guid>(type: "TEXT", nullable: false),
                    PrivateQuizId = table.Column<Guid>(type: "TEXT", nullable: false),
                    Image = table.Column<string>(type: "TEXT", nullable: true),
                    Title = table.Column<string>(type: "TEXT", nullable: true),
                    Answer = table.Column<string>(type: "TEXT", nullable: true),
                    DateTime = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PrivateQuestion", x => x.PrivateQuestionId);
                    table.ForeignKey(
                        name: "FK_PrivateQuestion_PrivateQuiz_PrivateQuizId",
                        column: x => x.PrivateQuizId,
                        principalTable: "PrivateQuiz",
                        principalColumn: "PrivateQuizId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PrivateQuizResult",
                columns: table => new
                {
                    PrivateQuizResultId = table.Column<string>(type: "TEXT", nullable: false),
                    PrivateQuizId = table.Column<Guid>(type: "TEXT", nullable: false),
                    UserId = table.Column<string>(type: "TEXT", nullable: true),
                    FirstName = table.Column<string>(type: "TEXT", nullable: true),
                    LastName = table.Column<string>(type: "TEXT", nullable: true),
                    MiddleName = table.Column<string>(type: "TEXT", nullable: true),
                    Department = table.Column<string>(type: "TEXT", nullable: true),
                    MatricNo = table.Column<string>(type: "TEXT", nullable: true),
                    Score = table.Column<string>(type: "TEXT", nullable: true),
                    DateTime = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PrivateQuizResult", x => x.PrivateQuizResultId);
                    table.ForeignKey(
                        name: "FK_PrivateQuizResult_PrivateQuiz_PrivateQuizId",
                        column: x => x.PrivateQuizId,
                        principalTable: "PrivateQuiz",
                        principalColumn: "PrivateQuizId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PrivateOption",
                columns: table => new
                {
                    OptionId = table.Column<Guid>(type: "TEXT", nullable: false),
                    PrivateQuestionId = table.Column<Guid>(type: "TEXT", nullable: false),
                    Alphabet = table.Column<string>(type: "TEXT", nullable: true),
                    Content = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PrivateOption", x => x.OptionId);
                    table.ForeignKey(
                        name: "FK_PrivateOption_PrivateQuestion_PrivateQuestionId",
                        column: x => x.PrivateQuestionId,
                        principalTable: "PrivateQuestion",
                        principalColumn: "PrivateQuestionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PrivateOption_PrivateQuestionId",
                table: "PrivateOption",
                column: "PrivateQuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_PrivateQuestion_PrivateQuizId",
                table: "PrivateQuestion",
                column: "PrivateQuizId");

            migrationBuilder.CreateIndex(
                name: "IX_PrivateQuizResult_PrivateQuizId",
                table: "PrivateQuizResult",
                column: "PrivateQuizId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PrivateAttempt");

            migrationBuilder.DropTable(
                name: "PrivateOption");

            migrationBuilder.DropTable(
                name: "PrivateQuizResult");

            migrationBuilder.DropTable(
                name: "Track");

            migrationBuilder.DropTable(
                name: "PrivateQuestion");

            migrationBuilder.DropTable(
                name: "PrivateQuiz");
        }
    }
}
