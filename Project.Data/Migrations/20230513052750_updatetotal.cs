using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.Data.Migrations
{
    public partial class updatetotal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "10ede721-8a9c-4575-a297-6b84ad0955ae");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "79aa03ef-191e-498a-a094-b153b4be0418", "7887cfa6-e99f-4028-ab3f-60c9db1f72fa" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c4fd85a2-2d52-4e7e-a3a3-f3e2236f5c34", "7c348f56-8dad-4b5d-9369-7e1e69cc6c6c" });

            migrationBuilder.DeleteData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: "7887cfa6-e99f-4028-ab3f-60c9db1f72fa");

            migrationBuilder.DeleteData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: "7c348f56-8dad-4b5d-9369-7e1e69cc6c6c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "79aa03ef-191e-498a-a094-b153b4be0418");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c4fd85a2-2d52-4e7e-a3a3-f3e2236f5c34");

            migrationBuilder.AlterColumn<decimal>(
                name: "TotalPrice",
                table: "Orders",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.InsertData(
                table: "AppUser",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreateAt", "DeleteAt", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UpdateAt", "UserName" },
                values: new object[,]
                {
                    { "75f14843-7233-4012-9517-ab29243ab262", 0, "19632d57-b0a3-46ef-81e3-13b8fb356d29", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "user3@hotmail.com", false, false, null, "USER3@HOTMAIL.COM", "USER3@HOTMAIL.COM", "AQAAAAEAACcQAAAAEKL5i7g+jVnMWWJfZEmX/T5ErRENfi8jwvDl/w/PWecHswPuZF9t7xD/+L3AQS/nYg==", null, false, "86f204e2-a33d-45bb-8efc-855b7717338c", false, null, "user3@hotmail.com" },
                    { "8971adfb-0134-41e4-af17-5031e2a02d6e", 0, "c459ef66-fccc-43f1-afed-0142d613baf7", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "user2@hotmail.com", false, false, null, "USER2@HOTMAIL.COM", "USER2@HOTMAIL.COM", "AQAAAAEAACcQAAAAEB/KvsRMx0/CPyGO6GYOlB5xZ37u3lPmC4TOZTKTvIdtOa4IYWKhQ/IA/iA1wi+Dmw==", null, false, "18f039a7-404e-4f83-b674-22baa7fb7d84", false, null, "user2@hotmail.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0452446d-8846-4f85-b3cb-7f45df5c44f5", "a8d0ad01-6d37-4275-83f1-128947328228", "User", "USER" },
                    { "26b28cf3-8ab4-4055-b26b-429c59ba48d0", "ca5134f6-0175-46c3-bcb9-7a6ecfa24106", "Admin", "ADMIN" },
                    { "4fd28457-3958-46c2-a796-39d719faeeed", "deddb425-46c3-4703-8cdb-5bbf6f432bfa", "Shipper", "SHIPPER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "26b28cf3-8ab4-4055-b26b-429c59ba48d0", "75f14843-7233-4012-9517-ab29243ab262" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "0452446d-8846-4f85-b3cb-7f45df5c44f5", "8971adfb-0134-41e4-af17-5031e2a02d6e" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4fd28457-3958-46c2-a796-39d719faeeed");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "26b28cf3-8ab4-4055-b26b-429c59ba48d0", "75f14843-7233-4012-9517-ab29243ab262" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0452446d-8846-4f85-b3cb-7f45df5c44f5", "8971adfb-0134-41e4-af17-5031e2a02d6e" });

            migrationBuilder.DeleteData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: "75f14843-7233-4012-9517-ab29243ab262");

            migrationBuilder.DeleteData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: "8971adfb-0134-41e4-af17-5031e2a02d6e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0452446d-8846-4f85-b3cb-7f45df5c44f5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "26b28cf3-8ab4-4055-b26b-429c59ba48d0");

            migrationBuilder.AlterColumn<decimal>(
                name: "TotalPrice",
                table: "Orders",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AppUser",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreateAt", "DeleteAt", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UpdateAt", "UserName" },
                values: new object[,]
                {
                    { "7887cfa6-e99f-4028-ab3f-60c9db1f72fa", 0, "23a9105a-d82c-4659-ab25-44be341bacaa", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "user3@hotmail.com", false, false, null, "USER3@HOTMAIL.COM", "USER3@HOTMAIL.COM", "AQAAAAEAACcQAAAAEJtJPTT2oJTZc7EIhkBXwjqv8QNDYT6VenxjbFOCmIYQKVeuZLlkBr60hLQtcyFcAQ==", null, false, "20b377dc-c764-4787-a6dc-565026d08c75", false, null, "user3@hotmail.com" },
                    { "7c348f56-8dad-4b5d-9369-7e1e69cc6c6c", 0, "9a5a86b6-a44e-4888-b9bf-79aebf990a8a", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "user2@hotmail.com", false, false, null, "USER2@HOTMAIL.COM", "USER2@HOTMAIL.COM", "AQAAAAEAACcQAAAAEDSevBPr9evKBZ2U/HJ3S5fhyCVBflkAIH+nAirBAIeOVsOQNB2gb32Chk1hycKa/Q==", null, false, "f763d4ef-2d2e-49e4-ad5b-f3243433584c", false, null, "user2@hotmail.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "10ede721-8a9c-4575-a297-6b84ad0955ae", "1ad32ac1-81cc-4ecc-b3ce-bc9f9aedc550", "Shipper", "SHIPPER" },
                    { "79aa03ef-191e-498a-a094-b153b4be0418", "003b8d1d-9029-4f11-b40c-2bf47a5ed4f6", "Admin", "ADMIN" },
                    { "c4fd85a2-2d52-4e7e-a3a3-f3e2236f5c34", "099f04e8-5248-46f0-b0e4-73a1e47623e7", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "79aa03ef-191e-498a-a094-b153b4be0418", "7887cfa6-e99f-4028-ab3f-60c9db1f72fa" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "c4fd85a2-2d52-4e7e-a3a3-f3e2236f5c34", "7c348f56-8dad-4b5d-9369-7e1e69cc6c6c" });
        }
    }
}
