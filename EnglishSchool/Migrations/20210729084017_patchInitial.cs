using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EnglishSchool.Migrations
{
    public partial class patchInitial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("1f2dbf89-4137-487e-9a45-535d002d68c0"),
                column: "CodeWord",
                value: "PageCourse");

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("d9ab7aeb-f309-4dde-986d-18456f6e26b5"),
                column: "CodeWord",
                value: "PageGallery");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "047E7E08-BA55-4BB3-A7B8-3426AD2884D2",
                column: "ConcurrencyStamp",
                value: "07059a3e-3111-4768-892b-65a2da20fe60");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3DF7F7A1-CA6D-450C-8D23-368958CA5904",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "af88d846-5dcd-4cf3-bb61-54f373cb5097", "AQAAAAEAACcQAAAAEFzLtbubZQD/AC1qygLyO+fbF7EHUBwRXz3hTwnQcWUEctopzBwn+wE8tsvgMurz7w==" });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("1f2dbf89-4137-487e-9a45-535d002d68c0"),
                column: "CodeWord",
                value: "PageHome");

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("d9ab7aeb-f309-4dde-986d-18456f6e26b5"),
                column: "CodeWord",
                value: "PageGallegy");
        }
    }
}
