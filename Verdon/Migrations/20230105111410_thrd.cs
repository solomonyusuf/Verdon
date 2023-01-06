using Microsoft.EntityFrameworkCore.Migrations;

namespace Verdon.Migrations
{
    public partial class thrd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Department",
                table: "PrivateQuiz",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Department",
                table: "Lecture",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Department",
                table: "PrivateQuiz");

            migrationBuilder.DropColumn(
                name: "Department",
                table: "Lecture");
        }
    }
}
