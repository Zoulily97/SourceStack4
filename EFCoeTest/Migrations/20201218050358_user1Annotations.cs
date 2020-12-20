using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCoeTest.Migrations
{
    public partial class user1Annotations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Register1",
                columns: table => new
                {
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HelpMoney = table.Column<int>(type: "int", nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Register1", x => x.UserName);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Register1_CreateTime",
                table: "Register1",
                column: "CreateTime",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Register1");
        }
    }
}
