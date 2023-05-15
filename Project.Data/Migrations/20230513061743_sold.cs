using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.Data.Migrations
{
    public partial class sold : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "99de49f6-b7f6-49b4-87c6-de54e14fe836");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f1b574bf-c8b0-4be2-8ee4-d78886ca38d7", "2b7cf863-852c-4eef-8c56-198051a4f5d7" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "04c8593e-3c0e-4db2-8617-de3c8fa49920", "6c17c202-1b03-44f5-9f9e-e7c319004443" });

            migrationBuilder.DeleteData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: "2b7cf863-852c-4eef-8c56-198051a4f5d7");

            migrationBuilder.DeleteData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: "6c17c202-1b03-44f5-9f9e-e7c319004443");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "04c8593e-3c0e-4db2-8617-de3c8fa49920");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f1b574bf-c8b0-4be2-8ee4-d78886ca38d7");

            migrationBuilder.AddColumn<int>(
                name: "QuantitySold",
                table: "Products",
                type: "int",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AppUser",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreateAt", "DeleteAt", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UpdateAt", "UserName" },
                values: new object[,]
                {
                    { "49c21a24-27c0-48b2-9836-9e34629b6643", 0, "a2c60869-285e-45d3-9f2d-a6ff0979fce0", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "user2@hotmail.com", false, false, null, "USER2@HOTMAIL.COM", "USER2@HOTMAIL.COM", "AQAAAAEAACcQAAAAEPSooVAyaCW0P/VU4wyfYm8M0Dzl2/p5w8vAucFl3aZtIzN5vOAyZny5T9jhn2k+lg==", null, false, "ac5994ab-84c8-4b4e-9b41-b302a715b57b", false, null, "user2@hotmail.com" },
                    { "a11033f3-7541-4cf2-b1db-6b59f1081647", 0, "e87ab246-00ce-4242-b6ef-58cc1270908a", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "user3@hotmail.com", false, false, null, "USER3@HOTMAIL.COM", "USER3@HOTMAIL.COM", "AQAAAAEAACcQAAAAEPtF15GX8qUjnMd7xXUu5h5wEY+zjJoQXvz2D0xbnA0zs0MnTBFb5t88ZsiJMZsHPw==", null, false, "ee82a64a-cbe3-4e8a-90ad-2f5a9b82c5ce", false, null, "user3@hotmail.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "440569ac-7e2a-4ee0-888f-4574b63bb672", "56e6b5a5-5cee-4fd1-b630-f3f7d75dadf8", "User", "USER" },
                    { "ec01cdda-c402-4735-a423-774280cb0dc6", "514764a4-081e-43da-9f02-cee1cd2dcc03", "Admin", "ADMIN" },
                    { "fab196e1-1bb7-446b-82d3-c9ef6228f372", "98407792-6e0f-4d7d-ab0b-91fe917a5dc0", "Shipper", "SHIPPER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "440569ac-7e2a-4ee0-888f-4574b63bb672", "49c21a24-27c0-48b2-9836-9e34629b6643" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ec01cdda-c402-4735-a423-774280cb0dc6", "a11033f3-7541-4cf2-b1db-6b59f1081647" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fab196e1-1bb7-446b-82d3-c9ef6228f372");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "440569ac-7e2a-4ee0-888f-4574b63bb672", "49c21a24-27c0-48b2-9836-9e34629b6643" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ec01cdda-c402-4735-a423-774280cb0dc6", "a11033f3-7541-4cf2-b1db-6b59f1081647" });

            migrationBuilder.DeleteData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: "49c21a24-27c0-48b2-9836-9e34629b6643");

            migrationBuilder.DeleteData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: "a11033f3-7541-4cf2-b1db-6b59f1081647");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "440569ac-7e2a-4ee0-888f-4574b63bb672");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ec01cdda-c402-4735-a423-774280cb0dc6");

            migrationBuilder.DropColumn(
                name: "QuantitySold",
                table: "Products");

            migrationBuilder.InsertData(
                table: "AppUser",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreateAt", "DeleteAt", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UpdateAt", "UserName" },
                values: new object[,]
                {
                    { "2b7cf863-852c-4eef-8c56-198051a4f5d7", 0, "6043b872-7276-4241-a281-4cdfe3f59ee6", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "user3@hotmail.com", false, false, null, "USER3@HOTMAIL.COM", "USER3@HOTMAIL.COM", "AQAAAAEAACcQAAAAEMPbDWCM5156z90A5K8gLHvsEpGK0Rl2G4/zZBfS0xYPuWXExrxH2bFG4hGYevXSQA==", null, false, "852a3ddb-915a-4107-9aa5-bcee01b7986d", false, null, "user3@hotmail.com" },
                    { "6c17c202-1b03-44f5-9f9e-e7c319004443", 0, "fac7f245-27e2-4435-8b5b-2ba60ebf812a", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "user2@hotmail.com", false, false, null, "USER2@HOTMAIL.COM", "USER2@HOTMAIL.COM", "AQAAAAEAACcQAAAAEPuoj1v67PdKWgEjixzse6t/6DLTFqMOqIES0fh7bEzqNA7PrDVaDqwtTRukrwdXcA==", null, false, "6b1011ff-c0de-49f8-9d45-81edfe831c9e", false, null, "user2@hotmail.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "04c8593e-3c0e-4db2-8617-de3c8fa49920", "24a772c2-05b5-4945-9701-4967ee52118d", "User", "USER" },
                    { "99de49f6-b7f6-49b4-87c6-de54e14fe836", "dd43ea71-a7b4-4746-8324-3158984c500b", "Shipper", "SHIPPER" },
                    { "f1b574bf-c8b0-4be2-8ee4-d78886ca38d7", "e2b53511-f0a2-48f5-be60-e659bac05cd4", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "f1b574bf-c8b0-4be2-8ee4-d78886ca38d7", "2b7cf863-852c-4eef-8c56-198051a4f5d7" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "04c8593e-3c0e-4db2-8617-de3c8fa49920", "6c17c202-1b03-44f5-9f9e-e7c319004443" });
        }
    }
}
