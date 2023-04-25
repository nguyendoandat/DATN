using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.Data.Migrations
{
    public partial class ạdhsad : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6a71fed6-b1ea-4375-8e83-49f6641e5da2");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "fd699c77-cd91-4a6d-870b-d75dc89c1ddb", "0f671310-8da2-498f-b951-934ab87daa48" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "81ffd5b9-34ac-4129-8b6e-2017ab23fff6", "296dc3bb-e97a-4186-93b3-c67f95302bc8" });

            migrationBuilder.DeleteData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: "0f671310-8da2-498f-b951-934ab87daa48");

            migrationBuilder.DeleteData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: "296dc3bb-e97a-4186-93b3-c67f95302bc8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "81ffd5b9-34ac-4129-8b6e-2017ab23fff6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fd699c77-cd91-4a6d-870b-d75dc89c1ddb");

            migrationBuilder.InsertData(
                table: "AppUser",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreateAt", "DeleteAt", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UpdateAt", "UserName" },
                values: new object[,]
                {
                    { "4b79a96b-b502-4575-bdec-a39adae9a308", 0, "687e83f2-5622-43fd-8d43-d7cc3716b4e8", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "user2@hotmail.com", false, false, null, "USER2@HOTMAIL.COM", "USER2@HOTMAIL.COM", "AQAAAAEAACcQAAAAEB1s3UMfZeJqx5rlOq/iiC2S5G/B77VHcuKYOYzX+ubvISgdo+xVathyR/p31M4m7A==", null, false, "1412f579-64cc-47b7-a2b6-990b2fa492b7", false, null, "user2@hotmail.com" },
                    { "7099e6e6-1eea-47e5-9b90-cd023c483a80", 0, "07c843a5-1d51-46d7-b4a2-3e304a76f7a8", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "user3@hotmail.com", false, false, null, "USER3@HOTMAIL.COM", "USER3@HOTMAIL.COM", "AQAAAAEAACcQAAAAECHZO0VvgKAs2/O+RvvHx9MG+v2VfyoktVtqdu5Q4/6c4iOsFT1X4Ej2CxKc6gTOiw==", null, false, "9c79c1d4-a766-47c7-b243-796b52642aa3", false, null, "user3@hotmail.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3dee17b9-1d74-45e2-9335-0e174246cea6", "c8ad75d2-2cec-406f-a932-2399622270e9", "Admin", "ADMIN" },
                    { "798b888a-61eb-4763-a909-942e87fd5acf", "8f2ea402-72c9-405b-af1d-d7e35adb4284", "User", "USER" },
                    { "cbb57ff2-75ba-46c9-a904-f15f98d459e6", "bb28c1a6-a171-48a9-9032-6209bd94e6e3", "Shipper", "SHIPPER" }
                });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Xác nhận thành công");

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "Đang được vận chuyển");

            migrationBuilder.InsertData(
                table: "Statuses",
                columns: new[] { "Id", "Name" },
                values: new object[] { 5, "Giao thành công" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "798b888a-61eb-4763-a909-942e87fd5acf", "4b79a96b-b502-4575-bdec-a39adae9a308" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "3dee17b9-1d74-45e2-9335-0e174246cea6", "7099e6e6-1eea-47e5-9b90-cd023c483a80" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbb57ff2-75ba-46c9-a904-f15f98d459e6");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "798b888a-61eb-4763-a909-942e87fd5acf", "4b79a96b-b502-4575-bdec-a39adae9a308" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3dee17b9-1d74-45e2-9335-0e174246cea6", "7099e6e6-1eea-47e5-9b90-cd023c483a80" });

            migrationBuilder.DeleteData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: "4b79a96b-b502-4575-bdec-a39adae9a308");

            migrationBuilder.DeleteData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: "7099e6e6-1eea-47e5-9b90-cd023c483a80");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3dee17b9-1d74-45e2-9335-0e174246cea6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "798b888a-61eb-4763-a909-942e87fd5acf");

            migrationBuilder.InsertData(
                table: "AppUser",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreateAt", "DeleteAt", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UpdateAt", "UserName" },
                values: new object[,]
                {
                    { "0f671310-8da2-498f-b951-934ab87daa48", 0, "7c28b572-ddef-4b17-bee3-87d0cba4d867", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "user2@hotmail.com", false, false, null, "USER2@HOTMAIL.COM", "USER2@HOTMAIL.COM", "AQAAAAEAACcQAAAAEPA6nKm0EUrEFNXt++AFf6S+INYQffOWOQ5hXIWW8ODxa0TDjaEvBxt691e2n6H+sA==", null, false, "bb78ef63-e32d-43f3-b154-7ae2a310bdbd", false, null, "user2@hotmail.com" },
                    { "296dc3bb-e97a-4186-93b3-c67f95302bc8", 0, "68192a9f-1431-44bb-b518-ed0f9e2e9015", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "user3@hotmail.com", false, false, null, "USER3@HOTMAIL.COM", "USER3@HOTMAIL.COM", "AQAAAAEAACcQAAAAENCcmk/tB2JMwRiLTATWf9t3CvF+H0USQBM7e6twFV8O3+t/lWSgab0piQSItfgPtw==", null, false, "e82716b6-3559-4f9a-886c-19d5f6138715", false, null, "user3@hotmail.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "6a71fed6-b1ea-4375-8e83-49f6641e5da2", "91a13149-989e-49b1-864a-24374796cacd", "Shipper", "SHIPPER" },
                    { "81ffd5b9-34ac-4129-8b6e-2017ab23fff6", "4e88b72c-224c-4b56-86e9-52d322ba411c", "Admin", "ADMIN" },
                    { "fd699c77-cd91-4a6d-870b-d75dc89c1ddb", "e7865005-2e33-4697-b119-8abb5bb458ea", "User", "USER" }
                });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Đang được vận chuyển");

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "Đã thanh toán");

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "fd699c77-cd91-4a6d-870b-d75dc89c1ddb", "0f671310-8da2-498f-b951-934ab87daa48" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "81ffd5b9-34ac-4129-8b6e-2017ab23fff6", "296dc3bb-e97a-4186-93b3-c67f95302bc8" });
        }
    }
}
