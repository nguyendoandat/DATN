using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.Data.Migrations
{
    public partial class editrreview : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_AppUser_UserId",
                table: "Reviews");

            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Products_ProductId",
                table: "Reviews");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4fd28457-3958-46c2-a796-39d719faeeed");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "26b28cf3-8ab4-4055-b26b-429c59ba48d0", "75f14843-7233-4012-9517-ab29243ab262" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0452446d-8846-4f85-b3cb-7f45df5c44f5", "8971adfb-0134-41e4-af17-5031e2a02d6e" });

            migrationBuilder.DeleteData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: "75f14843-7233-4012-9517-ab29243ab262");

            migrationBuilder.DeleteData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: "8971adfb-0134-41e4-af17-5031e2a02d6e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0452446d-8846-4f85-b3cb-7f45df5c44f5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "26b28cf3-8ab4-4055-b26b-429c59ba48d0");

            migrationBuilder.InsertData(
                table: "AppUser",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreateAt", "DeleteAt", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UpdateAt", "UserName" },
                values: new object[,]
                {
                    { "4c9e17d4-bf17-4d37-a20e-4ea5cbab40d2", 0, "185b9b46-8b92-4022-9833-2163a5c94149", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "user2@hotmail.com", false, false, null, "USER2@HOTMAIL.COM", "USER2@HOTMAIL.COM", "AQAAAAEAACcQAAAAEMUyCfeMeLv7QqJLKPrCF5EwMLs0C1z2yzcpo1IplMzi7G4jDI8FuF3Ns3qdweq3gQ==", null, false, "3e306f62-3120-4e1b-9900-956855723ced", false, null, "user2@hotmail.com" },
                    { "c3db4871-e1ab-48ed-91b4-3c188710a632", 0, "44ca3462-789a-4cbc-bcc3-3ff20eaaac9d", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "user3@hotmail.com", false, false, null, "USER3@HOTMAIL.COM", "USER3@HOTMAIL.COM", "AQAAAAEAACcQAAAAEIQ6uSdF46kB+r3YOjYLxw2RgwKFKCJmbPHlUZdYkx0rmXCFhqWSSKMs7jBvU+q0Og==", null, false, "8b401ef1-0beb-426a-a6ab-2ceb08c5925a", false, null, "user3@hotmail.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "882eb464-ec13-40db-adfa-2526255bf803", "b4f76f0c-78ca-49f1-894c-2ee7c8ce88d2", "Admin", "ADMIN" },
                    { "c8b7fcc0-dedb-4298-bad7-0230efaed3ef", "1bc12a3f-43cb-4a83-9c92-0a6a399f395e", "Shipper", "SHIPPER" },
                    { "d1dbb90c-6a83-4c28-b144-55971fc58de3", "aa6c5543-e8e3-4628-ae35-f2dbdb225b32", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "d1dbb90c-6a83-4c28-b144-55971fc58de3", "4c9e17d4-bf17-4d37-a20e-4ea5cbab40d2" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "882eb464-ec13-40db-adfa-2526255bf803", "c3db4871-e1ab-48ed-91b4-3c188710a632" });

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_AppUser_UserId",
                table: "Reviews",
                column: "UserId",
                principalTable: "AppUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Products_ProductId",
                table: "Reviews",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_AppUser_UserId",
                table: "Reviews");

            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Products_ProductId",
                table: "Reviews");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c8b7fcc0-dedb-4298-bad7-0230efaed3ef");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "d1dbb90c-6a83-4c28-b144-55971fc58de3", "4c9e17d4-bf17-4d37-a20e-4ea5cbab40d2" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "882eb464-ec13-40db-adfa-2526255bf803", "c3db4871-e1ab-48ed-91b4-3c188710a632" });

            migrationBuilder.DeleteData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: "4c9e17d4-bf17-4d37-a20e-4ea5cbab40d2");

            migrationBuilder.DeleteData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: "c3db4871-e1ab-48ed-91b4-3c188710a632");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "882eb464-ec13-40db-adfa-2526255bf803");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d1dbb90c-6a83-4c28-b144-55971fc58de3");

            migrationBuilder.InsertData(
                table: "AppUser",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreateAt", "DeleteAt", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UpdateAt", "UserName" },
                values: new object[,]
                {
                    { "75f14843-7233-4012-9517-ab29243ab262", 0, "19632d57-b0a3-46ef-81e3-13b8fb356d29", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "user3@hotmail.com", false, false, null, "USER3@HOTMAIL.COM", "USER3@HOTMAIL.COM", "AQAAAAEAACcQAAAAEKL5i7g+jVnMWWJfZEmX/T5ErRENfi8jwvDl/w/PWecHswPuZF9t7xD/+L3AQS/nYg==", null, false, "86f204e2-a33d-45bb-8efc-855b7717338c", false, null, "user3@hotmail.com" },
                    { "8971adfb-0134-41e4-af17-5031e2a02d6e", 0, "c459ef66-fccc-43f1-afed-0142d613baf7", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "user2@hotmail.com", false, false, null, "USER2@HOTMAIL.COM", "USER2@HOTMAIL.COM", "AQAAAAEAACcQAAAAEB/KvsRMx0/CPyGO6GYOlB5xZ37u3lPmC4TOZTKTvIdtOa4IYWKhQ/IA/iA1wi+Dmw==", null, false, "18f039a7-404e-4f83-b674-22baa7fb7d84", false, null, "user2@hotmail.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0452446d-8846-4f85-b3cb-7f45df5c44f5", "a8d0ad01-6d37-4275-83f1-128947328228", "User", "USER" },
                    { "26b28cf3-8ab4-4055-b26b-429c59ba48d0", "ca5134f6-0175-46c3-bcb9-7a6ecfa24106", "Admin", "ADMIN" },
                    { "4fd28457-3958-46c2-a796-39d719faeeed", "deddb425-46c3-4703-8cdb-5bbf6f432bfa", "Shipper", "SHIPPER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "26b28cf3-8ab4-4055-b26b-429c59ba48d0", "75f14843-7233-4012-9517-ab29243ab262" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "0452446d-8846-4f85-b3cb-7f45df5c44f5", "8971adfb-0134-41e4-af17-5031e2a02d6e" });

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_AppUser_UserId",
                table: "Reviews",
                column: "UserId",
                principalTable: "AppUser",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Products_ProductId",
                table: "Reviews",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id");
        }
    }
}
