using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.Data.Migrations
{
    public partial class status : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8b6cdeac-c846-44df-b55a-63b16e58556d");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "276bc207-58ab-44e2-953c-6a1a1a2a9051", "93cdeb8b-d7c9-4bf7-83b3-8fe393574ce8" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "936d2707-e908-4dbd-86f5-283857c29978", "a355ae85-912d-4935-9b77-4b51678c5bc4" });

            migrationBuilder.DeleteData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: "93cdeb8b-d7c9-4bf7-83b3-8fe393574ce8");

            migrationBuilder.DeleteData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: "a355ae85-912d-4935-9b77-4b51678c5bc4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "276bc207-58ab-44e2-953c-6a1a1a2a9051");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "936d2707-e908-4dbd-86f5-283857c29978");

            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "StatusId",
                table: "Orders",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Statuses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Statuses", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AppUser",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreateAt", "DeleteAt", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UpdateAt", "UserName" },
                values: new object[,]
                {
                    { "6ac038c4-a7d7-4ec7-b1e0-95f01c206853", 0, "7fea59aa-4eea-4fbe-9055-1869a97f733f", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "user2@hotmail.com", false, false, null, "USER2@HOTMAIL.COM", "USER2@HOTMAIL.COM", "AQAAAAEAACcQAAAAEGquKBqyoiPOZJmW/TX7X2lemtqNXQ476HFWIgcmEwiFX47vjsFrzmiioJY4v44guQ==", null, false, "f16944b6-04e9-4d0a-877f-40ef8dcade07", false, null, "user2@hotmail.com" },
                    { "d782d42e-d833-402e-9028-fd4ebbee6ac3", 0, "b365c492-e3b4-4d95-bbd8-0b2dadc316c2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "user3@hotmail.com", false, false, null, "USER3@HOTMAIL.COM", "USER3@HOTMAIL.COM", "AQAAAAEAACcQAAAAEAtDBP9mdYhCNuI1F0pMXddIEpAQmogR3O2UX7Z/SMbIwEdzwI2Rquw+43UBdEe2UQ==", null, false, "57e56b1a-8c68-4355-8a5c-a3e6277a9a88", false, null, "user3@hotmail.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "9aeb4eb2-ceaa-4cf1-a06a-ea360f3c8aeb", "e64d59ee-b3ba-430c-81af-7c21cb65e641", "Admin", "ADMIN" },
                    { "9be8ebfa-1983-4b32-b290-75e9e3509aca", "d71d1942-d786-4100-a1d5-2959074dd1b2", "User", "USER" },
                    { "daf18764-bdc8-4fe3-8e93-74f3223250b9", "8e7854f9-1918-4c63-a671-f949c60f89cc", "Shipper", "SHIPPER" }
                });

            migrationBuilder.InsertData(
                table: "Statuses",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Chờ xét duyệt" },
                    { 2, "Đã hủy" },
                    { 3, "Đang được vận chuyển" },
                    { 4, "Đã thanh toán" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "9be8ebfa-1983-4b32-b290-75e9e3509aca", "6ac038c4-a7d7-4ec7-b1e0-95f01c206853" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "9aeb4eb2-ceaa-4cf1-a06a-ea360f3c8aeb", "d782d42e-d833-402e-9028-fd4ebbee6ac3" });

            migrationBuilder.CreateIndex(
                name: "IX_Orders_StatusId",
                table: "Orders",
                column: "StatusId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Statuses_StatusId",
                table: "Orders",
                column: "StatusId",
                principalTable: "Statuses",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Statuses_StatusId",
                table: "Orders");

            migrationBuilder.DropTable(
                name: "Statuses");

            migrationBuilder.DropIndex(
                name: "IX_Orders_StatusId",
                table: "Orders");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "daf18764-bdc8-4fe3-8e93-74f3223250b9");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9be8ebfa-1983-4b32-b290-75e9e3509aca", "6ac038c4-a7d7-4ec7-b1e0-95f01c206853" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9aeb4eb2-ceaa-4cf1-a06a-ea360f3c8aeb", "d782d42e-d833-402e-9028-fd4ebbee6ac3" });

            migrationBuilder.DeleteData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: "6ac038c4-a7d7-4ec7-b1e0-95f01c206853");

            migrationBuilder.DeleteData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: "d782d42e-d833-402e-9028-fd4ebbee6ac3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9aeb4eb2-ceaa-4cf1-a06a-ea360f3c8aeb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9be8ebfa-1983-4b32-b290-75e9e3509aca");

            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "StatusId",
                table: "Orders");

            migrationBuilder.InsertData(
                table: "AppUser",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreateAt", "DeleteAt", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UpdateAt", "UserName" },
                values: new object[,]
                {
                    { "93cdeb8b-d7c9-4bf7-83b3-8fe393574ce8", 0, "7ac7f195-f395-430c-a240-86a0ada1f12f", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "user2@hotmail.com", false, false, null, "USER2@HOTMAIL.COM", "USER2@HOTMAIL.COM", "AQAAAAEAACcQAAAAEFDvLo4NB14at3ThhTxLHN5K/Dcu74Hs0N6MVTaZVRJlgRs4r3WrTn28JkstnlKGKg==", null, false, "09a60081-b30f-47cd-98a9-c4f94a389e52", false, null, "user2@hotmail.com" },
                    { "a355ae85-912d-4935-9b77-4b51678c5bc4", 0, "e63dfee1-da37-4aca-a421-ffbf0f3d4af2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "user3@hotmail.com", false, false, null, "USER3@HOTMAIL.COM", "USER3@HOTMAIL.COM", "AQAAAAEAACcQAAAAEArcF4wcfwcml7PfHuYCZ8+vlTyPrM6Riz5BDR9CSRSYMNojp+78RQiH05FDZqJqpQ==", null, false, "ce6a0604-0fac-42d1-bb4e-201e45601b0c", false, null, "user3@hotmail.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "276bc207-58ab-44e2-953c-6a1a1a2a9051", "ba64433b-5f94-4fb9-832c-f83d8f0ffa3a", "User", "USER" },
                    { "8b6cdeac-c846-44df-b55a-63b16e58556d", "d0a7f59f-8784-4f69-85a1-ea33b25a99b2", "Shipper", "SHIPPER" },
                    { "936d2707-e908-4dbd-86f5-283857c29978", "8dac4c7e-1fb9-4351-afc5-6374d504ff9d", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "276bc207-58ab-44e2-953c-6a1a1a2a9051", "93cdeb8b-d7c9-4bf7-83b3-8fe393574ce8" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "936d2707-e908-4dbd-86f5-283857c29978", "a355ae85-912d-4935-9b77-4b51678c5bc4" });
        }
    }
}
