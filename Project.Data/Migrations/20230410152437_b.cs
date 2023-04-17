using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.Data.Migrations
{
    public partial class b : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<int>(
                name: "DiscountId",
                table: "Categories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Discounts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DiscountPrice = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Discounts", x => x.Id);
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_Discounts_DiscountId",
                table: "Categories");

            migrationBuilder.DropTable(
                name: "Discounts");

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
    }
}
