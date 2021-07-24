using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EnglishSchool.Migrations
{
    public partial class updateInitial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TextFields",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CodeWord = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TextFields", x => x.Id);
                });

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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "UserName" },
                values: new object[] { "af88d846-5dcd-4cf3-bb61-54f373cb5097", "AQAAAAEAACcQAAAAEFzLtbubZQD/AC1qygLyO+fbF7EHUBwRXz3hTwnQcWUEctopzBwn+wE8tsvgMurz7w==", "admin" });

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: new Guid("e44b5bd3-ffb0-45a0-a1e5-3d7f8497afaf"),
                column: "ImageURL",
                value: "https://images.pexels.com/photos/267669/pexels-photo-267669.jpeg?cs=srgb&dl=pexels-pixabay-267669.jpg&fm=jpg");

            migrationBuilder.InsertData(
                table: "TextFields",
                columns: new[] { "Id", "CodeWord", "Text", "Title" },
                values: new object[,]
                {
                    { new Guid("1f2dbf89-4137-487e-9a45-535d002d68c0"), "PageHome", "заполняется администратором", "Курсы" },
                    { new Guid("d9ab7aeb-f309-4dde-986d-18456f6e26b5"), "PageGallegy", "заполняется администратором", "Галерея" },
                    { new Guid("a66318d7-27e9-47d4-a461-b3a6cab89323"), "PageTimetable", "заполняется администратором", "Расписание" },
                    { new Guid("fd4880de-40bf-49e1-87e9-44bc45ae8546"), "PageAbout", "заполняется администратором", "Преподаватель" },
                    { new Guid("9e66054e-9230-49e4-a52b-b55a00af64e3"), "PageRequest", "заполняется администратором", "Заявка" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TextFields");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "047E7E08-BA55-4BB3-A7B8-3426AD2884D2",
                column: "ConcurrencyStamp",
                value: "0ce77ead-b98f-48f6-8e04-fcbdb53764ba");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3DF7F7A1-CA6D-450C-8D23-368958CA5904",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "UserName" },
                values: new object[] { "63ed3b82-f30c-4b03-833a-21bde5872c99", "AQAAAAEAACcQAAAAEOADZZtapBaavd5dY+9o+/uX/RXzA4/w9h0R4vDVv7jdkYBw2PzgcTDdnNOjd5KXmQ==", null });

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: new Guid("e44b5bd3-ffb0-45a0-a1e5-3d7f8497afaf"),
                column: "ImageURL",
                value: "https://images.pexels.com/photos/256417/pexels-photo-256417.jpeg?cs=srgb&dl=pexels-pixabay-256417.jpg&fm=jpg");
        }
    }
}
