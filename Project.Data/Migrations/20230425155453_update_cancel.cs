using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.Data.Migrations
{
    public partial class update_cancel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AddColumn<DateTime>(
                name: "EndAt",
                table: "Orders",
                type: "datetime2",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AppUser",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreateAt", "DeleteAt", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UpdateAt", "UserName" },
                values: new object[,]
                {
                    { "a7282019-76b7-415c-93ec-8eb8b7d2604b", 0, "de867136-d399-438f-9df9-106bc58ec9dc", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "user2@hotmail.com", false, false, null, "USER2@HOTMAIL.COM", "USER2@HOTMAIL.COM", "AQAAAAEAACcQAAAAEKSVxlgH3eC08Sywm6ArK7KK5+mLpaQ3wHZoimrBO6hDenxo6kSXHjStusQBCc28hA==", null, false, "add8f70e-4867-4271-8a2a-d363ca86f2a6", false, null, "user2@hotmail.com" },
                    { "bb75609b-270b-404e-abd5-cea67a6f910f", 0, "58caa997-f77c-4043-90bf-e2c609a1325e", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "user3@hotmail.com", false, false, null, "USER3@HOTMAIL.COM", "USER3@HOTMAIL.COM", "AQAAAAEAACcQAAAAENt84ZNFvtnmTKB2ptrbCvS3jb5jeAkpETffH30YLWWc2SD9JH77S3HAflGQ2FJKtw==", null, false, "928baceb-5f62-4504-9652-88ce3650a291", false, null, "user3@hotmail.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "b52a0a23-0057-4a24-948d-eca110318b36", "03cb7a90-43d8-43aa-9bef-a643a78cfd00", "Admin", "ADMIN" },
                    { "cb66ca5a-b626-4606-bdd2-05e4e9743ae3", "12a586a3-3c0f-4101-a8f2-4b06aa38ef7c", "Shipper", "SHIPPER" },
                    { "cf1cf3b9-8fa4-4717-9aef-cd01514a9c01", "f1142759-7119-4311-97e6-3f3fed0caaf9", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "cf1cf3b9-8fa4-4717-9aef-cd01514a9c01", "a7282019-76b7-415c-93ec-8eb8b7d2604b" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "b52a0a23-0057-4a24-948d-eca110318b36", "bb75609b-270b-404e-abd5-cea67a6f910f" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cb66ca5a-b626-4606-bdd2-05e4e9743ae3");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "cf1cf3b9-8fa4-4717-9aef-cd01514a9c01", "a7282019-76b7-415c-93ec-8eb8b7d2604b" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b52a0a23-0057-4a24-948d-eca110318b36", "bb75609b-270b-404e-abd5-cea67a6f910f" });

            migrationBuilder.DeleteData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: "a7282019-76b7-415c-93ec-8eb8b7d2604b");

            migrationBuilder.DeleteData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: "bb75609b-270b-404e-abd5-cea67a6f910f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b52a0a23-0057-4a24-948d-eca110318b36");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cf1cf3b9-8fa4-4717-9aef-cd01514a9c01");

            migrationBuilder.DropColumn(
                name: "EndAt",
                table: "Orders");

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
    }
}
