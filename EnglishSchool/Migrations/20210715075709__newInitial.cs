using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EnglishSchool.Migrations
{
    public partial class _newInitial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Galleries",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageURL = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Galleries", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "047E7E08-BA55-4BB3-A7B8-3426AD2884D2", "0ce77ead-b98f-48f6-8e04-fcbdb53764ba", "admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3DF7F7A1-CA6D-450C-8D23-368958CA5904", 0, "63ed3b82-f30c-4b03-833a-21bde5872c99", "my@email.com", true, false, null, "MY@EMAIL.COM", "ADMIN", "AQAAAAEAACcQAAAAEOADZZtapBaavd5dY+9o+/uX/RXzA4/w9h0R4vDVv7jdkYBw2PzgcTDdnNOjd5KXmQ==", null, false, "", false, null });

            migrationBuilder.InsertData(
                table: "Galleries",
                columns: new[] { "Id", "ImageURL", "Title" },
                values: new object[] { new Guid("e44b5bd3-ffb0-45a0-a1e5-3d7f8497afaf"), "https://images.pexels.com/photos/256417/pexels-photo-256417.jpeg?cs=srgb&dl=pexels-pixabay-256417.jpg&fm=jpg", "Первое фото" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "047E7E08-BA55-4BB3-A7B8-3426AD2884D2", "3DF7F7A1-CA6D-450C-8D23-368958CA5904" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Galleries");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "047E7E08-BA55-4BB3-A7B8-3426AD2884D2", "3DF7F7A1-CA6D-450C-8D23-368958CA5904" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "047E7E08-BA55-4BB3-A7B8-3426AD2884D2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3DF7F7A1-CA6D-450C-8D23-368958CA5904");
        }
    }
}
