using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.Data.Migrations
{
    public partial class delete : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderCancels");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "OrderCancels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Thumb = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderCancels", x => x.Id);
                });

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
    }
}
