using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EnglishSchool.Migrations
{
    public partial class Timetable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DateEvents",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ChildName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Day = table.Column<int>(type: "int", nullable: false),
                    Month = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Time = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DateEvents", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "047E7E08-BA55-4BB3-A7B8-3426AD2884D2",
                column: "ConcurrencyStamp",
                value: "cc5e8788-8a2a-468e-9df2-285b355d1dde");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3DF7F7A1-CA6D-450C-8D23-368958CA5904",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9ab9f374-b769-45c9-9f15-efffdd899b0d", "AQAAAAEAACcQAAAAEDUQl4uU3OokW1Gz42T2qcdeEC0GgoJnwXtOOBFYfF4HuKM2RZB3HFXACLFPZ/S+1A==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DateEvents");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "047E7E08-BA55-4BB3-A7B8-3426AD2884D2",
                column: "ConcurrencyStamp",
                value: "0a72b66b-a23d-494e-938c-fcca1baa9671");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3DF7F7A1-CA6D-450C-8D23-368958CA5904",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "15cd917f-7ceb-4d1a-b511-939641a877df", "AQAAAAEAACcQAAAAEJf7+3Y9WjVP79/ds/JUlyOf0I5q/1blX5E4VmUKrOtlJhBIkUUq85OYtaUdqoHbDQ==" });
        }
    }
}
