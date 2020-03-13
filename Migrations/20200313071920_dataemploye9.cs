using Microsoft.EntityFrameworkCore.Migrations;

namespace HR_App.Migrations
{
    public partial class dataemploye9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "reason",
                table: "leaves",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "cv",
                table: "employees",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "posisi",
                table: "applicants",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "reason",
                table: "leaves");

            migrationBuilder.DropColumn(
                name: "cv",
                table: "employees");

            migrationBuilder.DropColumn(
                name: "posisi",
                table: "applicants");
        }
    }
}
