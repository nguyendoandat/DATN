using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.Data.Migrations
{
    public partial class edit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                keyValue: "15742601-08a7-42d2-993c-d2080ac6a509");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "03bdcb65-57fd-4e4b-b324-91d0d1114ab4", "6f4c80f2-4639-45e2-b019-6fb435242eb6" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "06d99dd6-21d7-4d74-8234-ae0a364837e5", "d75df800-ee5c-4ea0-b8d4-552da1e47a1c" });

            migrationBuilder.DeleteData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: "6f4c80f2-4639-45e2-b019-6fb435242eb6");

            migrationBuilder.DeleteData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: "d75df800-ee5c-4ea0-b8d4-552da1e47a1c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "03bdcb65-57fd-4e4b-b324-91d0d1114ab4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "06d99dd6-21d7-4d74-8234-ae0a364837e5");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "6f4c80f2-4639-45e2-b019-6fb435242eb6", 0, "1283cf38-fffe-4342-856b-3dbd114e565a", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "user3@hotmail.com", false, false, null, "USER3@HOTMAIL.COM", "USER3@HOTMAIL.COM", "AQAAAAEAACcQAAAAEIe2vLCfFFSe/v2oPJ4dXk1DIiB4PVl/9/qknNFNlqKH1s0khUFssVcdL6uqbzrQ5g==", null, false, "c0188ee1-17b2-4088-a836-7e99c1bcb3c4", false, null, "user3@hotmail.com" },
                    { "d75df800-ee5c-4ea0-b8d4-552da1e47a1c", 0, "3f496bd9-85de-4507-981b-e401dddc4344", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "user2@hotmail.com", false, false, null, "USER2@HOTMAIL.COM", "USER2@HOTMAIL.COM", "AQAAAAEAACcQAAAAEMZUnvICLluDAcnscHqUMuOoKggPF/0jSNzhm089rtImgdfzK72X+gtUFLofEJnCew==", null, false, "3cd813a2-fe39-424a-837e-9fbb0c530aa3", false, null, "user2@hotmail.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "03bdcb65-57fd-4e4b-b324-91d0d1114ab4", "f9e3f12b-cc21-4cd4-b445-baa87938c33e", "Admin", "ADMIN" },
                    { "06d99dd6-21d7-4d74-8234-ae0a364837e5", "c1cfbc5d-419c-4ddc-a422-92c370429c32", "User", "USER" },
                    { "15742601-08a7-42d2-993c-d2080ac6a509", "c5c26d3f-fa0c-4dc8-b388-c44abcec7557", "Shipper", "SHIPPER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "03bdcb65-57fd-4e4b-b324-91d0d1114ab4", "6f4c80f2-4639-45e2-b019-6fb435242eb6" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "06d99dd6-21d7-4d74-8234-ae0a364837e5", "d75df800-ee5c-4ea0-b8d4-552da1e47a1c" });

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
    }
}
