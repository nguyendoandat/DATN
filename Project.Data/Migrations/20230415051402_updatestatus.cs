using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.Data.Migrations
{
    public partial class updatestatus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Statuses_StatusId",
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

            migrationBuilder.AlterColumn<int>(
                name: "StatusId",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AppUser",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreateAt", "DeleteAt", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UpdateAt", "UserName" },
                values: new object[,]
                {
                    { "a1a35fe6-dc85-4542-90e5-b705ec39ab11", 0, "4f7f50c0-2e74-4ab3-87d6-3207edd28fe2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "user2@hotmail.com", false, false, null, "USER2@HOTMAIL.COM", "USER2@HOTMAIL.COM", "AQAAAAEAACcQAAAAELVg+st+4QK8bVAPEHEsgYqNBaKIX7D5HxMZVEZhZA05yUE/MJFw8ZsFR5HvNRFFRA==", null, false, "1b2c925f-a55c-41e9-947a-71aa3a32c0e3", false, null, "user2@hotmail.com" },
                    { "e3a36f71-f839-4b57-a692-f2aea1e2fabb", 0, "7f162d6a-987b-442f-be00-60f93d0912f1", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "user3@hotmail.com", false, false, null, "USER3@HOTMAIL.COM", "USER3@HOTMAIL.COM", "AQAAAAEAACcQAAAAEPIOcIJukrGDm5kv1Nz+nTHISHvWNbwbkeg7+N/VRdM7la3fO+ozsdDTsXhZYw+swQ==", null, false, "6d8bc2ac-254d-45b8-b8ba-41b9e79453a1", false, null, "user3@hotmail.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "18cf7c8e-168d-4522-9a7f-ac2d757213af", "23edbb46-581d-4f07-9b7c-2ce94a9f909d", "Shipper", "SHIPPER" },
                    { "6a1ef951-11bf-48e9-bcba-56e5b00e38ef", "3322a91d-903f-421d-83ee-858b10559476", "User", "USER" },
                    { "98e7865b-2d4f-4a0b-b287-755c692b8421", "2f1d42ba-8855-4d06-8f6f-19179a080f76", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "6a1ef951-11bf-48e9-bcba-56e5b00e38ef", "a1a35fe6-dc85-4542-90e5-b705ec39ab11" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "98e7865b-2d4f-4a0b-b287-755c692b8421", "e3a36f71-f839-4b57-a692-f2aea1e2fabb" });

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Statuses_StatusId",
                table: "Orders",
                column: "StatusId",
                principalTable: "Statuses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Statuses_StatusId",
                table: "Orders");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "18cf7c8e-168d-4522-9a7f-ac2d757213af");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "6a1ef951-11bf-48e9-bcba-56e5b00e38ef", "a1a35fe6-dc85-4542-90e5-b705ec39ab11" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "98e7865b-2d4f-4a0b-b287-755c692b8421", "e3a36f71-f839-4b57-a692-f2aea1e2fabb" });

            migrationBuilder.DeleteData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: "a1a35fe6-dc85-4542-90e5-b705ec39ab11");

            migrationBuilder.DeleteData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: "e3a36f71-f839-4b57-a692-f2aea1e2fabb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6a1ef951-11bf-48e9-bcba-56e5b00e38ef");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "98e7865b-2d4f-4a0b-b287-755c692b8421");

            migrationBuilder.AlterColumn<int>(
                name: "StatusId",
                table: "Orders",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

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
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "9be8ebfa-1983-4b32-b290-75e9e3509aca", "6ac038c4-a7d7-4ec7-b1e0-95f01c206853" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "9aeb4eb2-ceaa-4cf1-a06a-ea360f3c8aeb", "d782d42e-d833-402e-9028-fd4ebbee6ac3" });

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Statuses_StatusId",
                table: "Orders",
                column: "StatusId",
                principalTable: "Statuses",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }
    }
}
