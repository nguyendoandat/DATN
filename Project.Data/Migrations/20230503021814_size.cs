using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.Data.Migrations
{
    public partial class size : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "Size",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AppUser",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreateAt", "DeleteAt", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UpdateAt", "UserName" },
                values: new object[,]
                {
                    { "faeb2ae4-851f-4698-96be-8131fe571246", 0, "95b4b0e8-4ba0-4719-8e3c-8a7966cae824", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "user2@hotmail.com", false, false, null, "USER2@HOTMAIL.COM", "USER2@HOTMAIL.COM", "AQAAAAEAACcQAAAAEPqv3K4irw5GKM44VTtSSpHlb0uTYRw9t2qcGtnqojcf8cvEAcPZtlS4Y29dJhcF4A==", null, false, "7da8c904-a746-49ba-a8cc-1e389bdd3306", false, null, "user2@hotmail.com" },
                    { "fc5ba068-6772-4f14-b26c-5aea24c2b8a7", 0, "49021066-6e73-4924-9240-d6ba50a939bb", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "user3@hotmail.com", false, false, null, "USER3@HOTMAIL.COM", "USER3@HOTMAIL.COM", "AQAAAAEAACcQAAAAEEaj7VKUhpYQJlGlS02DqrUJzSN36W3vxBdI0k46wYGBHq14fXvvmZ9sGDO/q+nFuQ==", null, false, "87140f33-cdf6-4dcf-85b0-c0b610bb1f42", false, null, "user3@hotmail.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "03a70723-c88e-4584-b20a-f3448883b35b", "20b8454a-1318-43bd-b1ea-6ed1bf1dfcba", "Admin", "ADMIN" },
                    { "20c603d8-8001-4a4d-8067-f5b373a85cbc", "414e8afc-a64b-481d-82ff-c328031bf6b9", "User", "USER" },
                    { "e01af917-d4f7-4d4b-9ffa-baa6be16097d", "7b8da04f-0fef-4061-872a-45fc919dda87", "Shipper", "SHIPPER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "20c603d8-8001-4a4d-8067-f5b373a85cbc", "faeb2ae4-851f-4698-96be-8131fe571246" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "03a70723-c88e-4584-b20a-f3448883b35b", "fc5ba068-6772-4f14-b26c-5aea24c2b8a7" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e01af917-d4f7-4d4b-9ffa-baa6be16097d");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "20c603d8-8001-4a4d-8067-f5b373a85cbc", "faeb2ae4-851f-4698-96be-8131fe571246" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "03a70723-c88e-4584-b20a-f3448883b35b", "fc5ba068-6772-4f14-b26c-5aea24c2b8a7" });

            migrationBuilder.DeleteData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: "faeb2ae4-851f-4698-96be-8131fe571246");

            migrationBuilder.DeleteData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: "fc5ba068-6772-4f14-b26c-5aea24c2b8a7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "03a70723-c88e-4584-b20a-f3448883b35b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "20c603d8-8001-4a4d-8067-f5b373a85cbc");

            migrationBuilder.DropColumn(
                name: "Size",
                table: "Products");

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
    }
}
