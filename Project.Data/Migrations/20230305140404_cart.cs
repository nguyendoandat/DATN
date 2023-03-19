using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.Data.Migrations
{
    public partial class cart : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "fd59e9f9-63ec-4549-80f5-d06e3c170f9b", "648dbee6-6c13-49b4-bd91-c26d17c9f86d" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8a20ea2b-d20d-4e53-bee7-e3b44b400e6b", "8b315ffe-8eaf-496f-b842-5c7a964fa761" });

            migrationBuilder.DeleteData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: "648dbee6-6c13-49b4-bd91-c26d17c9f86d");

            migrationBuilder.DeleteData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: "8b315ffe-8eaf-496f-b842-5c7a964fa761");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8a20ea2b-d20d-4e53-bee7-e3b44b400e6b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fd59e9f9-63ec-4549-80f5-d06e3c170f9b");

            migrationBuilder.CreateTable(
                name: "Carts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Carts_AppUser_UserId",
                        column: x => x.UserId,
                        principalTable: "AppUser",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Carts_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderDate = table.Column<DateTime>(type: "date", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ShipName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    ShipAddress = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    ShipEmail = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    ShipPhoneNumber = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_AppUser_UserId",
                        column: x => x.UserId,
                        principalTable: "AppUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => new { x.OrderId, x.ProductId });
                    table.ForeignKey(
                        name: "FK_OrderDetails_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Products_ProductId",
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
                    { "0e1ba1cc-dfdc-4ec3-b5a1-2fb5ca4b3b17", 0, "98d89cb1-82d6-4876-9f81-054b5afd5acd", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "user3@hotmail.com", false, false, null, "USER3@HOTMAIL.COM", "USER3@HOTMAIL.COM", "AQAAAAEAACcQAAAAEPLTjXyD7YlagRHxGaZXh7Yu7Lt4PB8kxNAVjKnWfaaBOxlNQF7KoIUH5BhZQGOj+g==", null, false, "806ddd9b-3f30-4cfb-b1ae-f71fb17a86f3", false, null, "user3@hotmail.com" },
                    { "1f2a1de7-a315-4330-b020-d2a7030a6ef8", 0, "966f2250-2faf-46cf-997e-4fb79da78a80", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "user2@hotmail.com", false, false, null, "USER2@HOTMAIL.COM", "USER2@HOTMAIL.COM", "AQAAAAEAACcQAAAAEByxpddRL3bCSFQwpAfGtL6CdxRX8yqwPYV5hvksd9QccdKJC+enGUiNZc/oiDiRtA==", null, false, "ad9f5a62-31a4-4530-afa0-1ddd0b416728", false, null, "user2@hotmail.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "867fac27-09af-44f2-9c74-7f6808a7c1ae", "0078506e-907f-4b15-9b03-de57d45e3306", "Admin", "ADMIN" },
                    { "c98862f7-9f6b-4c18-8242-feb201660129", "b669a5f6-be6f-4b75-ae39-ff0c649338e2", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "867fac27-09af-44f2-9c74-7f6808a7c1ae", "0e1ba1cc-dfdc-4ec3-b5a1-2fb5ca4b3b17" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "c98862f7-9f6b-4c18-8242-feb201660129", "1f2a1de7-a315-4330-b020-d2a7030a6ef8" });

            migrationBuilder.CreateIndex(
                name: "IX_Carts_ProductId",
                table: "Carts",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Carts_UserId",
                table: "Carts",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_ProductId",
                table: "OrderDetails",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserId",
                table: "Orders",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Carts");

            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "867fac27-09af-44f2-9c74-7f6808a7c1ae", "0e1ba1cc-dfdc-4ec3-b5a1-2fb5ca4b3b17" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c98862f7-9f6b-4c18-8242-feb201660129", "1f2a1de7-a315-4330-b020-d2a7030a6ef8" });

            migrationBuilder.DeleteData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: "0e1ba1cc-dfdc-4ec3-b5a1-2fb5ca4b3b17");

            migrationBuilder.DeleteData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: "1f2a1de7-a315-4330-b020-d2a7030a6ef8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "867fac27-09af-44f2-9c74-7f6808a7c1ae");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c98862f7-9f6b-4c18-8242-feb201660129");

            migrationBuilder.InsertData(
                table: "AppUser",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreateAt", "DeleteAt", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UpdateAt", "UserName" },
                values: new object[,]
                {
                    { "648dbee6-6c13-49b4-bd91-c26d17c9f86d", 0, "2aedca9a-45a4-4b86-9a6c-636baade58d4", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "user2@hotmail.com", false, false, null, "USER2@HOTMAIL.COM", "USER2@HOTMAIL.COM", "AQAAAAEAACcQAAAAEAFSQzsqBxe2z2Uvw69syQxpnRxmmD/7crZGCj8TZSo3eZKsg63kp5DESjdmo9TAfA==", null, false, "23d3df3d-e335-44eb-9c98-e8410621620a", false, null, "user2@hotmail.com" },
                    { "8b315ffe-8eaf-496f-b842-5c7a964fa761", 0, "324430c1-acea-4ca7-baaa-ced29d473a51", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "user3@hotmail.com", false, false, null, "USER3@HOTMAIL.COM", "USER3@HOTMAIL.COM", "AQAAAAEAACcQAAAAEFT/Dzc5EeihrHp3ZZg1KSE4lr8e7Kfa79/knkmLwpCWFn+FfAqhrhUpXTVgMT7+aw==", null, false, "844f93b5-8bf2-4455-95e1-4dbf8e8c73c4", false, null, "user3@hotmail.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "8a20ea2b-d20d-4e53-bee7-e3b44b400e6b", "3de1e481-abb3-4506-9c08-268c88fc93fa", "Admin", "ADMIN" },
                    { "fd59e9f9-63ec-4549-80f5-d06e3c170f9b", "0e1a1155-4764-4924-95e6-b2b14eb2a405", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "fd59e9f9-63ec-4549-80f5-d06e3c170f9b", "648dbee6-6c13-49b4-bd91-c26d17c9f86d" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "8a20ea2b-d20d-4e53-bee7-e3b44b400e6b", "8b315ffe-8eaf-496f-b842-5c7a964fa761" });
        }
    }
}
