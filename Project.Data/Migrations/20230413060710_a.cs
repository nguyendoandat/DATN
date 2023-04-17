using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.Data.Migrations
{
    public partial class a : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Discounts_Categories_CategoryId",
                table: "Discounts");

            migrationBuilder.DropIndex(
                name: "IX_Discounts_CategoryId",
                table: "Discounts");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0537fd84-a6b7-415e-bcf5-d9b05aa25d57");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3168d5fa-d140-4891-b1f2-09b34a3fd221", "a87c485f-e257-4b22-8d1a-bb7f93f6e03f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "85d01bcb-80ea-428b-a9a4-0058c5e2d247", "ceec441d-23a4-4d13-ac1c-44ceab6be62f" });

            migrationBuilder.DeleteData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: "a87c485f-e257-4b22-8d1a-bb7f93f6e03f");

            migrationBuilder.DeleteData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: "ceec441d-23a4-4d13-ac1c-44ceab6be62f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3168d5fa-d140-4891-b1f2-09b34a3fd221");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "85d01bcb-80ea-428b-a9a4-0058c5e2d247");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Discounts");

            migrationBuilder.AddColumn<int>(
                name: "DiscountId",
                table: "Categories",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

            migrationBuilder.CreateIndex(
                name: "IX_Categories_DiscountId",
                table: "Categories",
                column: "DiscountId");

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_Discounts_DiscountId",
                table: "Categories",
                column: "DiscountId",
                principalTable: "Discounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_Discounts_DiscountId",
                table: "Categories");

            migrationBuilder.DropIndex(
                name: "IX_Categories_DiscountId",
                table: "Categories");

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

            migrationBuilder.DropColumn(
                name: "DiscountId",
                table: "Categories");

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Discounts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AppUser",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreateAt", "DeleteAt", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UpdateAt", "UserName" },
                values: new object[,]
                {
                    { "a87c485f-e257-4b22-8d1a-bb7f93f6e03f", 0, "60332fdf-081f-484b-896f-b005c7265787", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "user3@hotmail.com", false, false, null, "USER3@HOTMAIL.COM", "USER3@HOTMAIL.COM", "AQAAAAEAACcQAAAAEIw4UufrT2Q0sS6QfkuDK94pOzAvdbcr5A0YYMTb1u/G/kCYs13occ4vL7USKOABUg==", null, false, "bba047c3-831e-406d-b3dc-75c70d6b6f71", false, null, "user3@hotmail.com" },
                    { "ceec441d-23a4-4d13-ac1c-44ceab6be62f", 0, "56f3600b-cd5c-4890-8be8-d5fee73645a9", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "user2@hotmail.com", false, false, null, "USER2@HOTMAIL.COM", "USER2@HOTMAIL.COM", "AQAAAAEAACcQAAAAENODcXisSqzuda+hUw4YdgnQspa/7xadLFSeOx1eBNREtbp4O8qovI7F5yhKqYdUGg==", null, false, "e4807166-b0f9-4633-8cac-653f2814183a", false, null, "user2@hotmail.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0537fd84-a6b7-415e-bcf5-d9b05aa25d57", "9c045c12-670d-4dd9-8362-65aab3e9d24f", "Shipper", "SHIPPER" },
                    { "3168d5fa-d140-4891-b1f2-09b34a3fd221", "6b05ba32-04cc-452a-a85b-d4eb58d4cd97", "Admin", "ADMIN" },
                    { "85d01bcb-80ea-428b-a9a4-0058c5e2d247", "eaf0b10d-4c9c-4136-9e46-0600d4f82e5d", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "3168d5fa-d140-4891-b1f2-09b34a3fd221", "a87c485f-e257-4b22-8d1a-bb7f93f6e03f" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "85d01bcb-80ea-428b-a9a4-0058c5e2d247", "ceec441d-23a4-4d13-ac1c-44ceab6be62f" });

            migrationBuilder.CreateIndex(
                name: "IX_Discounts_CategoryId",
                table: "Discounts",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Discounts_Categories_CategoryId",
                table: "Discounts",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
