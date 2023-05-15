using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.Data.Migrations
{
    public partial class updatecart : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cart");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "Cart",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cart", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cart_AppUser_UserId",
                        column: x => x.UserId,
                        principalTable: "AppUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cart_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Cart_ProductId",
                table: "Cart",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Cart_UserId",
                table: "Cart",
                column: "UserId");
        }
    }
}
