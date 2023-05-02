using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.Data.Migrations
{
    public partial class ordercancel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbb57ff2-75ba-46c9-a904-f15f98d459e6");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "798b888a-61eb-4763-a909-942e87fd5acf", "4b79a96b-b502-4575-bdec-a39adae9a308" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3dee17b9-1d74-45e2-9335-0e174246cea6", "7099e6e6-1eea-47e5-9b90-cd023c483a80" });

            migrationBuilder.DeleteData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: "4b79a96b-b502-4575-bdec-a39adae9a308");

            migrationBuilder.DeleteData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: "7099e6e6-1eea-47e5-9b90-cd023c483a80");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3dee17b9-1d74-45e2-9335-0e174246cea6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "798b888a-61eb-4763-a909-942e87fd5acf");

            migrationBuilder.DropColumn(
                name: "Trend",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "View",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Trend",
                table: "Categories");

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateAt",
                table: "Orders",
                type: "datetime2",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "OrderCancels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Thumb = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderCancels", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AppUser",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreateAt", "DeleteAt", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UpdateAt", "UserName" },
                values: new object[,]
                {
                    { "226a5e40-7c7e-4118-be52-92a63f218f19", 0, "bdb414d7-e729-4a44-a4e7-45dedbbbada0", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "user3@hotmail.com", false, false, null, "USER3@HOTMAIL.COM", "USER3@HOTMAIL.COM", "AQAAAAEAACcQAAAAENLM+yQWCuwxjWBMRUPYIXIpVcTCFyC2rKuZfJj7vSYKMWtrT4ILMp8QfvK8aHsDyw==", null, false, "40bc0a52-ba83-49a3-82e0-35e8fa154f62", false, null, "user3@hotmail.com" },
                    { "6662f09b-3838-4214-b40c-9e8ded4ee5cc", 0, "eb4363ac-914c-4b64-958d-3d7ab429f01b", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "user2@hotmail.com", false, false, null, "USER2@HOTMAIL.COM", "USER2@HOTMAIL.COM", "AQAAAAEAACcQAAAAEBwjHEOy+oc6FK6LSGzVj4Q1uOoUZHUnGAuhnlwajnITg/Z3WaeEkTmF58xH4h96NQ==", null, false, "b196ed33-ee45-47cc-90d0-491d89d477b8", false, null, "user2@hotmail.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "17371cd9-23d3-4323-ad5a-062015528175", "dd481ed6-e14a-4e22-aadd-bdd13e971a3d", "Admin", "ADMIN" },
                    { "3038609a-1361-49cc-a51f-75a319c03de7", "c9536456-15e7-4c0c-abdf-013daef24f09", "User", "USER" },
                    { "eaa7ed6f-4a46-474d-8451-b93564634e15", "c71753d5-7d10-4932-b689-61a03eb63fd5", "Shipper", "SHIPPER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "17371cd9-23d3-4323-ad5a-062015528175", "226a5e40-7c7e-4118-be52-92a63f218f19" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "3038609a-1361-49cc-a51f-75a319c03de7", "6662f09b-3838-4214-b40c-9e8ded4ee5cc" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderCancels");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eaa7ed6f-4a46-474d-8451-b93564634e15");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "17371cd9-23d3-4323-ad5a-062015528175", "226a5e40-7c7e-4118-be52-92a63f218f19" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3038609a-1361-49cc-a51f-75a319c03de7", "6662f09b-3838-4214-b40c-9e8ded4ee5cc" });

            migrationBuilder.DeleteData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: "226a5e40-7c7e-4118-be52-92a63f218f19");

            migrationBuilder.DeleteData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: "6662f09b-3838-4214-b40c-9e8ded4ee5cc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "17371cd9-23d3-4323-ad5a-062015528175");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3038609a-1361-49cc-a51f-75a319c03de7");

            migrationBuilder.DropColumn(
                name: "UpdateAt",
                table: "Orders");

            migrationBuilder.AddColumn<bool>(
                name: "Trend",
                table: "Products",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "View",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "Trend",
                table: "Categories",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "AppUser",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreateAt", "DeleteAt", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UpdateAt", "UserName" },
                values: new object[,]
                {
                    { "4b79a96b-b502-4575-bdec-a39adae9a308", 0, "687e83f2-5622-43fd-8d43-d7cc3716b4e8", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "user2@hotmail.com", false, false, null, "USER2@HOTMAIL.COM", "USER2@HOTMAIL.COM", "AQAAAAEAACcQAAAAEB1s3UMfZeJqx5rlOq/iiC2S5G/B77VHcuKYOYzX+ubvISgdo+xVathyR/p31M4m7A==", null, false, "1412f579-64cc-47b7-a2b6-990b2fa492b7", false, null, "user2@hotmail.com" },
                    { "7099e6e6-1eea-47e5-9b90-cd023c483a80", 0, "07c843a5-1d51-46d7-b4a2-3e304a76f7a8", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "user3@hotmail.com", false, false, null, "USER3@HOTMAIL.COM", "USER3@HOTMAIL.COM", "AQAAAAEAACcQAAAAECHZO0VvgKAs2/O+RvvHx9MG+v2VfyoktVtqdu5Q4/6c4iOsFT1X4Ej2CxKc6gTOiw==", null, false, "9c79c1d4-a766-47c7-b243-796b52642aa3", false, null, "user3@hotmail.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3dee17b9-1d74-45e2-9335-0e174246cea6", "c8ad75d2-2cec-406f-a932-2399622270e9", "Admin", "ADMIN" },
                    { "798b888a-61eb-4763-a909-942e87fd5acf", "8f2ea402-72c9-405b-af1d-d7e35adb4284", "User", "USER" },
                    { "cbb57ff2-75ba-46c9-a904-f15f98d459e6", "bb28c1a6-a171-48a9-9032-6209bd94e6e3", "Shipper", "SHIPPER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "798b888a-61eb-4763-a909-942e87fd5acf", "4b79a96b-b502-4575-bdec-a39adae9a308" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "3dee17b9-1d74-45e2-9335-0e174246cea6", "7099e6e6-1eea-47e5-9b90-cd023c483a80" });
        }
    }
}
