using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.Data.Migrations
{
    public partial class deletecart : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Carts_AppUser_UserId",
                table: "Carts");

            migrationBuilder.DropForeignKey(
                name: "FK_Carts_Products_ProductId",
                table: "Carts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Carts",
                table: "Carts");

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

            migrationBuilder.RenameTable(
                name: "Carts",
                newName: "Cart");

            migrationBuilder.RenameIndex(
                name: "IX_Carts_UserId",
                table: "Cart",
                newName: "IX_Cart_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Carts_ProductId",
                table: "Cart",
                newName: "IX_Cart_ProductId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cart",
                table: "Cart",
                column: "Id");

            migrationBuilder.InsertData(
                table: "AppUser",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreateAt", "DeleteAt", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UpdateAt", "UserName" },
                values: new object[,]
                {
                    { "2d8d100e-2c39-4c38-b943-f850cbe8b9d7", 0, "84c77a80-6cd9-4598-94ae-b94b652dec83", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "user2@hotmail.com", false, false, null, "USER2@HOTMAIL.COM", "USER2@HOTMAIL.COM", "AQAAAAEAACcQAAAAEFcbnkFGFp/asrwmy09t9bulCjcTE+DFsXf3cPA1/2Bg1WfkszVY/1f2zP40PK7WYg==", null, false, "00313b60-8004-4bf1-bf88-ea56aaee2f09", false, null, "user2@hotmail.com" },
                    { "be23d63f-f7a0-4f90-a3e3-0a39e7ba93f2", 0, "735d0276-d335-44e6-bf94-57fcbfc82173", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "user3@hotmail.com", false, false, null, "USER3@HOTMAIL.COM", "USER3@HOTMAIL.COM", "AQAAAAEAACcQAAAAEE31cIbcm6MGf6e3TbMrHmGTz7UVoCoV0YSH85dapxWga7GgH3GqYe61OTlEGMua9g==", null, false, "51dcac90-a3f7-4705-af54-a1c9ea25d9bb", false, null, "user3@hotmail.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "004ecb06-7bf1-4ce8-83fc-9d236bcb1feb", "56bfffe8-7e37-48a8-a5af-0cf6dbdd5e80", "Admin", "ADMIN" },
                    { "72a46b81-b046-4f72-886d-0f6afc85a68b", "24a21dec-adc5-4d68-b603-395558170562", "Shipper", "SHIPPER" },
                    { "a691af00-7c2c-4217-ae2c-e89165c617df", "a50d99a8-0b40-46c5-a872-f0b297eb0fde", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "a691af00-7c2c-4217-ae2c-e89165c617df", "2d8d100e-2c39-4c38-b943-f850cbe8b9d7" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "004ecb06-7bf1-4ce8-83fc-9d236bcb1feb", "be23d63f-f7a0-4f90-a3e3-0a39e7ba93f2" });

            migrationBuilder.AddForeignKey(
                name: "FK_Cart_AppUser_UserId",
                table: "Cart",
                column: "UserId",
                principalTable: "AppUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cart_Products_ProductId",
                table: "Cart",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cart_AppUser_UserId",
                table: "Cart");

            migrationBuilder.DropForeignKey(
                name: "FK_Cart_Products_ProductId",
                table: "Cart");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cart",
                table: "Cart");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "72a46b81-b046-4f72-886d-0f6afc85a68b");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a691af00-7c2c-4217-ae2c-e89165c617df", "2d8d100e-2c39-4c38-b943-f850cbe8b9d7" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "004ecb06-7bf1-4ce8-83fc-9d236bcb1feb", "be23d63f-f7a0-4f90-a3e3-0a39e7ba93f2" });

            migrationBuilder.DeleteData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: "2d8d100e-2c39-4c38-b943-f850cbe8b9d7");

            migrationBuilder.DeleteData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: "be23d63f-f7a0-4f90-a3e3-0a39e7ba93f2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "004ecb06-7bf1-4ce8-83fc-9d236bcb1feb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a691af00-7c2c-4217-ae2c-e89165c617df");

            migrationBuilder.RenameTable(
                name: "Cart",
                newName: "Carts");

            migrationBuilder.RenameIndex(
                name: "IX_Cart_UserId",
                table: "Carts",
                newName: "IX_Carts_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Cart_ProductId",
                table: "Carts",
                newName: "IX_Carts_ProductId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Carts",
                table: "Carts",
                column: "Id");

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
                name: "FK_Carts_AppUser_UserId",
                table: "Carts",
                column: "UserId",
                principalTable: "AppUser",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Carts_Products_ProductId",
                table: "Carts",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
