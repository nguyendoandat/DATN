using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.Data.Migrations
{
    public partial class update_ : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_AppUser_AppUserId",
                table: "Categories");

            migrationBuilder.DropTable(
                name: "ImportProducts");

            migrationBuilder.DropTable(
                name: "Medias");

            migrationBuilder.DropTable(
                name: "Imports");

            migrationBuilder.DropIndex(
                name: "IX_Categories_AppUserId",
                table: "Categories");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "18cf7c8e-168d-4522-9a7f-ac2d757213af");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "6a1ef951-11bf-48e9-bcba-56e5b00e38ef", "a1a35fe6-dc85-4542-90e5-b705ec39ab11" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "98e7865b-2d4f-4a0b-b287-755c692b8421", "e3a36f71-f839-4b57-a692-f2aea1e2fabb" });

            migrationBuilder.DeleteData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: "a1a35fe6-dc85-4542-90e5-b705ec39ab11");

            migrationBuilder.DeleteData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: "e3a36f71-f839-4b57-a692-f2aea1e2fabb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6a1ef951-11bf-48e9-bcba-56e5b00e38ef");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "98e7865b-2d4f-4a0b-b287-755c692b8421");

            migrationBuilder.DropColumn(
                name: "AppUserId",
                table: "Categories");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                name: "AppUserId",
                table: "Categories",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Imports",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Imports", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Medias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medias", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Medias_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ImportProducts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImportId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Price = table.Column<decimal>(type: "decimal", nullable: false),
                    Quantity = table.Column<int>(type: "integer", nullable: false)
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
                    { "a1a35fe6-dc85-4542-90e5-b705ec39ab11", 0, "4f7f50c0-2e74-4ab3-87d6-3207edd28fe2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "user2@hotmail.com", false, false, null, "USER2@HOTMAIL.COM", "USER2@HOTMAIL.COM", "AQAAAAEAACcQAAAAELVg+st+4QK8bVAPEHEsgYqNBaKIX7D5HxMZVEZhZA05yUE/MJFw8ZsFR5HvNRFFRA==", null, false, "1b2c925f-a55c-41e9-947a-71aa3a32c0e3", false, null, "user2@hotmail.com" },
                    { "e3a36f71-f839-4b57-a692-f2aea1e2fabb", 0, "7f162d6a-987b-442f-be00-60f93d0912f1", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "user3@hotmail.com", false, false, null, "USER3@HOTMAIL.COM", "USER3@HOTMAIL.COM", "AQAAAAEAACcQAAAAEPIOcIJukrGDm5kv1Nz+nTHISHvWNbwbkeg7+N/VRdM7la3fO+ozsdDTsXhZYw+swQ==", null, false, "6d8bc2ac-254d-45b8-b8ba-41b9e79453a1", false, null, "user3@hotmail.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "18cf7c8e-168d-4522-9a7f-ac2d757213af", "23edbb46-581d-4f07-9b7c-2ce94a9f909d", "Shipper", "SHIPPER" },
                    { "6a1ef951-11bf-48e9-bcba-56e5b00e38ef", "3322a91d-903f-421d-83ee-858b10559476", "User", "USER" },
                    { "98e7865b-2d4f-4a0b-b287-755c692b8421", "2f1d42ba-8855-4d06-8f6f-19179a080f76", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "6a1ef951-11bf-48e9-bcba-56e5b00e38ef", "a1a35fe6-dc85-4542-90e5-b705ec39ab11" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "98e7865b-2d4f-4a0b-b287-755c692b8421", "e3a36f71-f839-4b57-a692-f2aea1e2fabb" });

            migrationBuilder.CreateIndex(
                name: "IX_Categories_AppUserId",
                table: "Categories",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_ImportProducts_ImportId",
                table: "ImportProducts",
                column: "ImportId");

            migrationBuilder.CreateIndex(
                name: "IX_Medias_ProductId",
                table: "Medias",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_AppUser_AppUserId",
                table: "Categories",
                column: "AppUserId",
                principalTable: "AppUser",
                principalColumn: "Id");
        }
    }
}
