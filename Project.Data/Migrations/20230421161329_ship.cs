using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.Data.Migrations
{
    public partial class ship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "87c49833-c6ad-48e4-b761-2675ad9953a3");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "31d2df8f-55e0-4dd2-b515-0af1bcb627c0", "88532908-e511-4aef-b54c-5adcb986959d" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "126c60d3-5e52-42c7-a1ec-800c6b703641", "eee6ae45-880c-405f-ab6a-6e3780ba1837" });

            migrationBuilder.DeleteData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: "88532908-e511-4aef-b54c-5adcb986959d");

            migrationBuilder.DeleteData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: "eee6ae45-880c-405f-ab6a-6e3780ba1837");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "126c60d3-5e52-42c7-a1ec-800c6b703641");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "31d2df8f-55e0-4dd2-b515-0af1bcb627c0");

            migrationBuilder.AddColumn<string>(
                name: "ShipperId",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true);

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

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "fd699c77-cd91-4a6d-870b-d75dc89c1ddb", "0f671310-8da2-498f-b951-934ab87daa48" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "81ffd5b9-34ac-4129-8b6e-2017ab23fff6", "296dc3bb-e97a-4186-93b3-c67f95302bc8" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "ShipperId",
                table: "Orders");

            migrationBuilder.InsertData(
                table: "AppUser",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreateAt", "DeleteAt", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UpdateAt", "UserName" },
                values: new object[,]
                {
                    { "88532908-e511-4aef-b54c-5adcb986959d", 0, "448bc236-7aa8-4db2-a6fa-d2cbf29afe7e", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "user3@hotmail.com", false, false, null, "USER3@HOTMAIL.COM", "USER3@HOTMAIL.COM", "AQAAAAEAACcQAAAAELKXk+q+zCA7XVE9A/qZoRv+W5BRMC9lWAK7//mE7CmR2DvUwA5ey4pFEWIT5WsUsA==", null, false, "4da27221-72a7-43a2-84c6-c392363ad820", false, null, "user3@hotmail.com" },
                    { "eee6ae45-880c-405f-ab6a-6e3780ba1837", 0, "4ee0a256-fa6e-4cf6-8610-8b1a3c0a4cfb", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "user2@hotmail.com", false, false, null, "USER2@HOTMAIL.COM", "USER2@HOTMAIL.COM", "AQAAAAEAACcQAAAAEAli2Va7Tn4JhIlXr1poH6ltlzHtnW0KeqrfnaLYI6ZWXZ4bSWWckLtk8IvFVdxY4A==", null, false, "7dcb8f1f-a2ac-4b48-8738-556f7e7dc803", false, null, "user2@hotmail.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "126c60d3-5e52-42c7-a1ec-800c6b703641", "0292793f-085b-4c3a-afe2-219ac22f9849", "User", "USER" },
                    { "31d2df8f-55e0-4dd2-b515-0af1bcb627c0", "f1f9042e-dcdf-416f-ab0a-e1ba27e5f737", "Admin", "ADMIN" },
                    { "87c49833-c6ad-48e4-b761-2675ad9953a3", "2095e753-0557-40ac-aaac-1cc82e39f558", "Shipper", "SHIPPER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "31d2df8f-55e0-4dd2-b515-0af1bcb627c0", "88532908-e511-4aef-b54c-5adcb986959d" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "126c60d3-5e52-42c7-a1ec-800c6b703641", "eee6ae45-880c-405f-ab6a-6e3780ba1837" });
        }
    }
}
