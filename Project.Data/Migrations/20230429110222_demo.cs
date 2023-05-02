using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.Data.Migrations
{
    public partial class demo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AppUser",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreateAt", "DeleteAt", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UpdateAt", "UserName" },
                values: new object[,]
                {
                    { "675553ab-b359-4b31-bfc5-18c089c2185b", 0, "2eaa5917-9001-44d2-a41c-05d9f3cf3e43", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "user3@hotmail.com", false, false, null, "USER3@HOTMAIL.COM", "USER3@HOTMAIL.COM", "AQAAAAEAACcQAAAAEJicqyUOxLoS7MsW3W+zyvMdoSg8B8y9xsoCpgPscq3atcPtqPUas++TxfI3gVVYdQ==", null, false, "b1cf5e75-c7aa-4330-a523-02ae73a36d06", false, null, "user3@hotmail.com" },
                    { "979c3805-00a0-413e-9dda-bc1f9f287ecf", 0, "f6976685-3720-481b-bd0b-72a8c6a5584b", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "user2@hotmail.com", false, false, null, "USER2@HOTMAIL.COM", "USER2@HOTMAIL.COM", "AQAAAAEAACcQAAAAECroPD6gI21jPapm2lzlQLwayJomCXbcRppXhx4CBR/GOjw6KBKgMAF9o8R7zhHPvQ==", null, false, "6813c9fe-c18b-468a-8224-ca003d145a98", false, null, "user2@hotmail.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "094eccdd-5c42-4373-a9dc-9832500de24e", "1c5b9cde-fe28-468a-9993-fb68dcbd88cd", "Admin", "ADMIN" },
                    { "b1bb0393-a9ce-4afa-8dcc-1e91500cdd41", "867f2218-fd57-4dc3-850c-6a4c2516b3c1", "User", "USER" },
                    { "defbd961-b056-4595-8a7c-714a504974b6", "90384766-b349-43be-9d5b-3cc6ccfa7cbd", "Shipper", "SHIPPER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "094eccdd-5c42-4373-a9dc-9832500de24e", "675553ab-b359-4b31-bfc5-18c089c2185b" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "b1bb0393-a9ce-4afa-8dcc-1e91500cdd41", "979c3805-00a0-413e-9dda-bc1f9f287ecf" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "defbd961-b056-4595-8a7c-714a504974b6");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "094eccdd-5c42-4373-a9dc-9832500de24e", "675553ab-b359-4b31-bfc5-18c089c2185b" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b1bb0393-a9ce-4afa-8dcc-1e91500cdd41", "979c3805-00a0-413e-9dda-bc1f9f287ecf" });

            migrationBuilder.DeleteData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: "675553ab-b359-4b31-bfc5-18c089c2185b");

            migrationBuilder.DeleteData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: "979c3805-00a0-413e-9dda-bc1f9f287ecf");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "094eccdd-5c42-4373-a9dc-9832500de24e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b1bb0393-a9ce-4afa-8dcc-1e91500cdd41");

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
    }
}
