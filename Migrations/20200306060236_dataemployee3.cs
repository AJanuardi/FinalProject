using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HR_App.Migrations
{
    public partial class dataemployee3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "employees",
                columns: table => new
                {
                    id = table.Column<Guid>(nullable: false),
                    name = table.Column<string>(nullable: true),
                    photo = table.Column<string>(nullable: true),
                    email = table.Column<string>(nullable: true),
                    phone = table.Column<string>(nullable: true),
                    gender = table.Column<string>(nullable: true),
                    bhirtdate = table.Column<DateTime>(nullable: false),
                    bhirtplace = table.Column<string>(nullable: true),
                    position = table.Column<string>(nullable: true),
                    department = table.Column<string>(nullable: true),
                    address = table.Column<string>(nullable: true),
                    nameugd1 = table.Column<string>(nullable: true),
                    emergency1 = table.Column<string>(nullable: true),
                    nameugd2 = table.Column<string>(nullable: true),
                    emergency2 = table.Column<string>(nullable: true),
                    nameugd3 = table.Column<string>(nullable: true),
                    emergency3 = table.Column<string>(nullable: true),
                    status = table.Column<string>(nullable: true),
                    contract = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_employees", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "employees");
        }
    }
}
