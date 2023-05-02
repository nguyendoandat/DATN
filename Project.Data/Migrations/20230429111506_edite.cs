using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.Data.Migrations
{
    public partial class edite : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "35021343-0234-4f7c-8205-1db5afffa321", 0, "b624e2cc-106a-4e69-83ac-23ccf4a8d54f", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "user2@hotmail.com", false, false, null, "USER2@HOTMAIL.COM", "USER2@HOTMAIL.COM", "AQAAAAEAACcQAAAAEOKh9LSRJsD2z01qnsy6lPV+ypWk2XXmnbbanHurkkJOAYTCV7Q/GqGx7AMNUDAfTA==", null, false, "7b74035c-22bd-4407-8786-e6702eecceb9", false, null, "user2@hotmail.com" },
                    { "cbd60745-ba77-4173-8daf-c0decac6a617", 0, "ed9dea3f-7ff8-4631-947b-558f165ff31b", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "user3@hotmail.com", false, false, null, "USER3@HOTMAIL.COM", "USER3@HOTMAIL.COM", "AQAAAAEAACcQAAAAEIIMY3T3rfmymUmnfPKnh2U6L8MEMQpZ+4B6+UiGfz0GKXsiR8iBl3LkJmmTHzde5Q==", null, false, "e6fffb98-1f6a-42b0-af1b-a400cacbf997", false, null, "user3@hotmail.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "02fed2e6-656c-4a3f-9feb-119c4157fa78", "10077802-630d-4003-9f32-b6319a5a92c2", "Admin", "ADMIN" },
                    { "4b18aedc-f24a-4fc6-962e-ceff793655dc", "dc715062-acd1-4065-811f-1a223e0851ba", "User", "USER" },
                    { "4b241eb3-1fbb-411b-89d8-905ea44f1cd3", "0fb9b4e3-aa83-4668-b7af-20ebae9dc88d", "Shipper", "SHIPPER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "4b18aedc-f24a-4fc6-962e-ceff793655dc", "35021343-0234-4f7c-8205-1db5afffa321" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "02fed2e6-656c-4a3f-9feb-119c4157fa78", "cbd60745-ba77-4173-8daf-c0decac6a617" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4b241eb3-1fbb-411b-89d8-905ea44f1cd3");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "4b18aedc-f24a-4fc6-962e-ceff793655dc", "35021343-0234-4f7c-8205-1db5afffa321" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "02fed2e6-656c-4a3f-9feb-119c4157fa78", "cbd60745-ba77-4173-8daf-c0decac6a617" });

            migrationBuilder.DeleteData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: "35021343-0234-4f7c-8205-1db5afffa321");

            migrationBuilder.DeleteData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: "cbd60745-ba77-4173-8daf-c0decac6a617");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "02fed2e6-656c-4a3f-9feb-119c4157fa78");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4b18aedc-f24a-4fc6-962e-ceff793655dc");

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
    }
}
