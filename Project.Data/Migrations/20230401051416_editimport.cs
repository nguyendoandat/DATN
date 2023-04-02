using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.Data.Migrations
{
    public partial class editimport : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "5a8ed0b2-d66c-4c40-8427-bdb828bf98b8", "03ff802d-08a1-4a7b-be7a-231deda7f4c7" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2d4fa73f-eac1-49fe-b31f-7fbcd54ec5d5", "7cb617d6-60c0-458c-bc77-f92e8cc8dab9" });

            migrationBuilder.DeleteData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: "03ff802d-08a1-4a7b-be7a-231deda7f4c7");

            migrationBuilder.DeleteData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: "7cb617d6-60c0-458c-bc77-f92e8cc8dab9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2d4fa73f-eac1-49fe-b31f-7fbcd54ec5d5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5a8ed0b2-d66c-4c40-8427-bdb828bf98b8");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "Imports");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "Categories");

            migrationBuilder.AddColumn<int>(
                name: "ImportProductId",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "ImportProducts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Quantity = table.Column<int>(type: "integer", nullable: false),
                    Price = table.Column<decimal>(type: "decimal", nullable: false),
                    ImportId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImportProducts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ImportProducts_Imports_ImportId",
                        column: x => x.ImportId,
                        principalTable: "Imports",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AppUser",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreateAt", "DeleteAt", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UpdateAt", "UserName" },
                values: new object[,]
                {
                    { "5ff55939-da40-4e50-8a0c-76c7e96d7815", 0, "d673beeb-dc33-497e-8811-46b506e84dbf", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "user3@hotmail.com", false, false, null, "USER3@HOTMAIL.COM", "USER3@HOTMAIL.COM", "AQAAAAEAACcQAAAAEPfsnFgiB64RJHNBi0NyOw6di7oFkazmMOgeg5sFtSm0kpIc7zo0lIeEB3u0cPTzrQ==", null, false, "c3c4597a-c12b-41a1-ba63-e70b3045f928", false, null, "user3@hotmail.com" },
                    { "c535a650-ea1f-4b38-b453-28415c80c22d", 0, "4038ba68-1e4a-4ab8-a1dc-cd15d4dab065", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "user2@hotmail.com", false, false, null, "USER2@HOTMAIL.COM", "USER2@HOTMAIL.COM", "AQAAAAEAACcQAAAAEH6D2BJ5GvsxmTsOxJqnDBwWNNRayHhhY2u7B4l0TB9hWZ4pRRtpE+h08RNnbUOoGw==", null, false, "bb294ae1-76bd-448d-9995-6e61197b3674", false, null, "user2@hotmail.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3a185112-23ca-4088-89f8-2c4ec0c88107", "217ecffa-efa7-4c70-9e14-4b15ebc358c1", "User", "USER" },
                    { "4ba6888f-822f-4c0f-adae-1222fa88f6fd", "641db8a1-157a-4ca3-bb88-8b7b7621134e", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "4ba6888f-822f-4c0f-adae-1222fa88f6fd", "5ff55939-da40-4e50-8a0c-76c7e96d7815" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "3a185112-23ca-4088-89f8-2c4ec0c88107", "c535a650-ea1f-4b38-b453-28415c80c22d" });

            migrationBuilder.CreateIndex(
                name: "IX_Products_ImportProductId",
                table: "Products",
                column: "ImportProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ImportProducts_ImportId",
                table: "ImportProducts",
                column: "ImportId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ImportProducts_ImportProductId",
                table: "Products",
                column: "ImportProductId",
                principalTable: "ImportProducts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_ImportProducts_ImportProductId",
                table: "Products");

            migrationBuilder.DropTable(
                name: "ImportProducts");

            migrationBuilder.DropIndex(
                name: "IX_Products_ImportProductId",
                table: "Products");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "4ba6888f-822f-4c0f-adae-1222fa88f6fd", "5ff55939-da40-4e50-8a0c-76c7e96d7815" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3a185112-23ca-4088-89f8-2c4ec0c88107", "c535a650-ea1f-4b38-b453-28415c80c22d" });

            migrationBuilder.DeleteData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: "5ff55939-da40-4e50-8a0c-76c7e96d7815");

            migrationBuilder.DeleteData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: "c535a650-ea1f-4b38-b453-28415c80c22d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3a185112-23ca-4088-89f8-2c4ec0c88107");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4ba6888f-822f-4c0f-adae-1222fa88f6fd");

            migrationBuilder.DropColumn(
                name: "ImportProductId",
                table: "Products");

            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                table: "Imports",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                table: "Categories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AppUser",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreateAt", "DeleteAt", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UpdateAt", "UserName" },
                values: new object[,]
                {
                    { "03ff802d-08a1-4a7b-be7a-231deda7f4c7", 0, "8ab999a4-05c9-44f2-94f2-bea6034e4c77", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "user3@hotmail.com", false, false, null, "USER3@HOTMAIL.COM", "USER3@HOTMAIL.COM", "AQAAAAEAACcQAAAAEN6pTAY45AsmqAwcIZE/Hl7J1eY2uMH+OBJyNlSM51k1qKu9EYE6ihaBOwN3kyNBrQ==", null, false, "f3f9d1dc-afb5-43ee-9669-054cf2d37a41", false, null, "user3@hotmail.com" },
                    { "7cb617d6-60c0-458c-bc77-f92e8cc8dab9", 0, "03f4507b-f351-409b-804e-49a6715e80f5", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "user2@hotmail.com", false, false, null, "USER2@HOTMAIL.COM", "USER2@HOTMAIL.COM", "AQAAAAEAACcQAAAAEFV1fTj7918k93bCnapulYij2jJVp2lOMRP7ewnWLqBhz6mcxQ+7vrJFNY8Te1nQZQ==", null, false, "f08f44b4-9947-4fcb-931b-104793be2097", false, null, "user2@hotmail.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2d4fa73f-eac1-49fe-b31f-7fbcd54ec5d5", "4fb778d1-918d-4933-b20c-c8088920eb1f", "User", "USER" },
                    { "5a8ed0b2-d66c-4c40-8427-bdb828bf98b8", "0912aad0-ead7-401c-bc32-b7d613e263c1", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "5a8ed0b2-d66c-4c40-8427-bdb828bf98b8", "03ff802d-08a1-4a7b-be7a-231deda7f4c7" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "2d4fa73f-eac1-49fe-b31f-7fbcd54ec5d5", "7cb617d6-60c0-458c-bc77-f92e8cc8dab9" });
        }
    }
}
