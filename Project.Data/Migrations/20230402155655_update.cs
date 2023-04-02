using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.Data.Migrations
{
    public partial class update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_ImportProducts_ImportProductId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Imports_ImportId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_ImportId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_ImportProductId",
                table: "Products");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "4ba6888f-822f-4c0f-adae-1222fa88f6fd", "5ff55939-da40-4e50-8a0c-76c7e96d7815" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3a185112-23ca-4088-89f8-2c4ec0c88107", "c535a650-ea1f-4b38-b453-28415c80c22d" });

            migrationBuilder.DeleteData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: "5ff55939-da40-4e50-8a0c-76c7e96d7815");

            migrationBuilder.DeleteData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: "c535a650-ea1f-4b38-b453-28415c80c22d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3a185112-23ca-4088-89f8-2c4ec0c88107");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4ba6888f-822f-4c0f-adae-1222fa88f6fd");

            migrationBuilder.DropColumn(
                name: "ImportId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ImportProductId",
                table: "Products");

            migrationBuilder.InsertData(
                table: "AppUser",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreateAt", "DeleteAt", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UpdateAt", "UserName" },
                values: new object[,]
                {
                    { "0517a899-316e-42ab-bfa3-d05d462f0e2a", 0, "9922f91f-fd9e-4dc1-af18-803182872666", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "user2@hotmail.com", false, false, null, "USER2@HOTMAIL.COM", "USER2@HOTMAIL.COM", "AQAAAAEAACcQAAAAEPAY2T7gfLRdvSehhXrv98WXfsxrYtOlv0akD8zuo2zj/fHlOdT9LuOYorfu0/wEWw==", null, false, "fb7b7711-3099-404e-93d4-9132bf3e0b17", false, null, "user2@hotmail.com" },
                    { "34af47ea-a8cd-4ea5-bc8d-d0314c28fc42", 0, "4702719a-4dcc-4a7b-86cd-0cb106b01af6", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "user3@hotmail.com", false, false, null, "USER3@HOTMAIL.COM", "USER3@HOTMAIL.COM", "AQAAAAEAACcQAAAAEKdI6yYWYnX2jmphUaW9rQfgAth1WUHfDuQrUrL5xrXzehbpk1fh7ZJ5gMOtsdzzTg==", null, false, "d572d608-ed49-4249-a2fb-b8430ecd84b9", false, null, "user3@hotmail.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0f5ce6d4-fbce-4bbc-b9d3-bd8551273bc2", "b26f6425-053e-48c7-8170-91dd5870edd5", "User", "USER" },
                    { "1d563074-1679-4d75-bf54-28a0a283a609", "ad8c635c-666c-4d75-b3f4-2a08712c0d1c", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "0f5ce6d4-fbce-4bbc-b9d3-bd8551273bc2", "0517a899-316e-42ab-bfa3-d05d462f0e2a" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "1d563074-1679-4d75-bf54-28a0a283a609", "34af47ea-a8cd-4ea5-bc8d-d0314c28fc42" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0f5ce6d4-fbce-4bbc-b9d3-bd8551273bc2", "0517a899-316e-42ab-bfa3-d05d462f0e2a" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1d563074-1679-4d75-bf54-28a0a283a609", "34af47ea-a8cd-4ea5-bc8d-d0314c28fc42" });

            migrationBuilder.DeleteData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: "0517a899-316e-42ab-bfa3-d05d462f0e2a");

            migrationBuilder.DeleteData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: "34af47ea-a8cd-4ea5-bc8d-d0314c28fc42");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0f5ce6d4-fbce-4bbc-b9d3-bd8551273bc2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1d563074-1679-4d75-bf54-28a0a283a609");

            migrationBuilder.AddColumn<int>(
                name: "ImportId",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ImportProductId",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AppUser",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreateAt", "DeleteAt", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UpdateAt", "UserName" },
                values: new object[,]
                {
                    { "5ff55939-da40-4e50-8a0c-76c7e96d7815", 0, "d673beeb-dc33-497e-8811-46b506e84dbf", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "user3@hotmail.com", false, false, null, "USER3@HOTMAIL.COM", "USER3@HOTMAIL.COM", "AQAAAAEAACcQAAAAEPfsnFgiB64RJHNBi0NyOw6di7oFkazmMOgeg5sFtSm0kpIc7zo0lIeEB3u0cPTzrQ==", null, false, "c3c4597a-c12b-41a1-ba63-e70b3045f928", false, null, "user3@hotmail.com" },
                    { "c535a650-ea1f-4b38-b453-28415c80c22d", 0, "4038ba68-1e4a-4ab8-a1dc-cd15d4dab065", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "user2@hotmail.com", false, false, null, "USER2@HOTMAIL.COM", "USER2@HOTMAIL.COM", "AQAAAAEAACcQAAAAEH6D2BJ5GvsxmTsOxJqnDBwWNNRayHhhY2u7B4l0TB9hWZ4pRRtpE+h08RNnbUOoGw==", null, false, "bb294ae1-76bd-448d-9995-6e61197b3674", false, null, "user2@hotmail.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3a185112-23ca-4088-89f8-2c4ec0c88107", "217ecffa-efa7-4c70-9e14-4b15ebc358c1", "User", "USER" },
                    { "4ba6888f-822f-4c0f-adae-1222fa88f6fd", "641db8a1-157a-4ca3-bb88-8b7b7621134e", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "4ba6888f-822f-4c0f-adae-1222fa88f6fd", "5ff55939-da40-4e50-8a0c-76c7e96d7815" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "3a185112-23ca-4088-89f8-2c4ec0c88107", "c535a650-ea1f-4b38-b453-28415c80c22d" });

            migrationBuilder.CreateIndex(
                name: "IX_Products_ImportId",
                table: "Products",
                column: "ImportId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ImportProductId",
                table: "Products",
                column: "ImportProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ImportProducts_ImportProductId",
                table: "Products",
                column: "ImportProductId",
                principalTable: "ImportProducts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Imports_ImportId",
                table: "Products",
                column: "ImportId",
                principalTable: "Imports",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
