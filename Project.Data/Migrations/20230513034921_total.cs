using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.Data.Migrations
{
    public partial class total : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a030a761-b2c1-4805-9df9-f695e841842f");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9f085d25-834d-471a-871c-03ccd65a84f0", "8f15f91c-aade-4d3a-b255-e2009cd73482" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "57227fb2-0ba5-48df-b274-10d4352f5374", "98938ab2-b0f8-4819-bfe7-605a0f786ee8" });

            migrationBuilder.DeleteData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: "8f15f91c-aade-4d3a-b255-e2009cd73482");

            migrationBuilder.DeleteData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: "98938ab2-b0f8-4819-bfe7-605a0f786ee8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "57227fb2-0ba5-48df-b274-10d4352f5374");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9f085d25-834d-471a-871c-03ccd65a84f0");

            migrationBuilder.AddColumn<decimal>(
                name: "TotalPrice",
                table: "Orders",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "TotalPrice",
                table: "Orders");

            migrationBuilder.InsertData(
                table: "AppUser",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreateAt", "DeleteAt", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UpdateAt", "UserName" },
                values: new object[,]
                {
                    { "8f15f91c-aade-4d3a-b255-e2009cd73482", 0, "4e79358d-708a-4eeb-8285-cf29a8690e98", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "user3@hotmail.com", false, false, null, "USER3@HOTMAIL.COM", "USER3@HOTMAIL.COM", "AQAAAAEAACcQAAAAEKTjBs6r+zPrVKPsmIEjq+bbxVJ8qIeObpSsN4w5NgPq73GfJ+Oa/eeI3XjT0Y/+EA==", null, false, "c5186b01-f61f-4e6b-b72a-f874cd84d414", false, null, "user3@hotmail.com" },
                    { "98938ab2-b0f8-4819-bfe7-605a0f786ee8", 0, "de3019fa-2fcd-420f-938f-2c41e139b000", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "user2@hotmail.com", false, false, null, "USER2@HOTMAIL.COM", "USER2@HOTMAIL.COM", "AQAAAAEAACcQAAAAEOisT2E1i5a+Tb4f2Oxajra4b2NifeUkONKSE3UPSPJXsG8zJhpZ6PfoX3wB3cNdBQ==", null, false, "12fe7960-57e8-472f-a7d6-5fdc52252efb", false, null, "user2@hotmail.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "57227fb2-0ba5-48df-b274-10d4352f5374", "d5b965bf-ab2f-4216-b697-b49d51b92b31", "User", "USER" },
                    { "9f085d25-834d-471a-871c-03ccd65a84f0", "4123dbf5-53b8-449e-9431-180fcb752ad9", "Admin", "ADMIN" },
                    { "a030a761-b2c1-4805-9df9-f695e841842f", "9e77ee2d-1981-46fd-bfcb-064c99194dd5", "Shipper", "SHIPPER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "9f085d25-834d-471a-871c-03ccd65a84f0", "8f15f91c-aade-4d3a-b255-e2009cd73482" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "57227fb2-0ba5-48df-b274-10d4352f5374", "98938ab2-b0f8-4819-bfe7-605a0f786ee8" });
        }
    }
}
