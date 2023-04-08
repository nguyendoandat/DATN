using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.Data.Migrations
{
    public partial class shipper : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AppUser",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreateAt", "DeleteAt", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UpdateAt", "UserName" },
                values: new object[,]
                {
                    { "3250f566-b8ce-4646-99c8-0f602af8125b", 0, "c6f1db68-920c-4e58-bec5-73bbcf874194", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "user3@hotmail.com", false, false, null, "USER3@HOTMAIL.COM", "USER3@HOTMAIL.COM", "AQAAAAEAACcQAAAAEMo1Td09dvqL2UbXFns9lwz6m9epbLK7okQSgfAZiWHuYU0+B+oaMEB8p/SIZcOIRw==", null, false, "7bacfd56-8ce7-401d-9841-8d9e12abaea5", false, null, "user3@hotmail.com" },
                    { "c4f48809-4deb-4164-a3b5-6b63edb71eed", 0, "3f76182a-613d-4a3f-a140-e7c57a84d45f", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "user2@hotmail.com", false, false, null, "USER2@HOTMAIL.COM", "USER2@HOTMAIL.COM", "AQAAAAEAACcQAAAAEODIX1Zin17Rk7djOOsDI8mKfRtIKO21Y99cEX7x1FA4F/DjVeM4XeSov2pOlMzcBA==", null, false, "71d6deba-e309-4a9e-aa9b-3e9af9b7b5da", false, null, "user2@hotmail.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4383302e-f86c-4787-b6ba-343e3355c9ae", "c1bbcfb5-3907-4426-923b-a38fdc0f5493", "Admin", "ADMIN" },
                    { "4544ef44-fcad-46a4-b011-4c543b5f5700", "3d2eac03-5238-4d50-83d9-e73c5f178ec8", "User", "USER" },
                    { "e79f829a-fea4-4282-9b51-cd2b7116d695", "f2f62134-5106-478a-9866-2480b8cbc553", "Shipper", "SHIPPER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "4383302e-f86c-4787-b6ba-343e3355c9ae", "3250f566-b8ce-4646-99c8-0f602af8125b" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "4544ef44-fcad-46a4-b011-4c543b5f5700", "c4f48809-4deb-4164-a3b5-6b63edb71eed" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e79f829a-fea4-4282-9b51-cd2b7116d695");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "4383302e-f86c-4787-b6ba-343e3355c9ae", "3250f566-b8ce-4646-99c8-0f602af8125b" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "4544ef44-fcad-46a4-b011-4c543b5f5700", "c4f48809-4deb-4164-a3b5-6b63edb71eed" });

            migrationBuilder.DeleteData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: "3250f566-b8ce-4646-99c8-0f602af8125b");

            migrationBuilder.DeleteData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: "c4f48809-4deb-4164-a3b5-6b63edb71eed");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4383302e-f86c-4787-b6ba-343e3355c9ae");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4544ef44-fcad-46a4-b011-4c543b5f5700");

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
    }
}
