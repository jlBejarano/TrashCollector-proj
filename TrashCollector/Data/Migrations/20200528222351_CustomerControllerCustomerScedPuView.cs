using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Data.Migrations
{
    public partial class CustomerControllerCustomerScedPuView : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5962b184-764b-4caa-8d1f-9f67b53d6525");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "81d9be49-aff2-48e1-85d6-429b1e9f4734");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ae23687b-9a83-4dfc-80ce-ffcda6c48a6d");

            migrationBuilder.CreateTable(
                name: "CustomerSchedulePU",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Address = table.Column<string>(nullable: true),
                    ZipCode = table.Column<double>(nullable: false),
                    City = table.Column<string>(nullable: true),
                    DayOfWeek = table.Column<string>(nullable: false),
                    SuspendStartDate = table.Column<DateTime>(nullable: false),
                    SuspendEndDate = table.Column<DateTime>(nullable: false),
                    IdentityUserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerSchedulePU", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CustomerSchedulePU_AspNetUsers_IdentityUserId",
                        column: x => x.IdentityUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "20b9a144-f502-46e2-9c16-756698d021b1", "28b8ab53-f5fe-42da-bf6f-90d5b38d207e", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "dde79189-bd62-4354-84dc-e6a0334d5f57", "7e0d894e-7378-4e9f-b3dc-c19e22ccab06", "Employee", "EMPLOYEE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c91750ae-48ba-4f1f-8264-4c64e5eaf8ff", "123bd1fa-da8a-4d5d-bf06-9c23848863e9", "Admin", "ADMIN" });

            migrationBuilder.CreateIndex(
                name: "IX_CustomerSchedulePU_IdentityUserId",
                table: "CustomerSchedulePU",
                column: "IdentityUserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CustomerSchedulePU");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "20b9a144-f502-46e2-9c16-756698d021b1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c91750ae-48ba-4f1f-8264-4c64e5eaf8ff");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dde79189-bd62-4354-84dc-e6a0334d5f57");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ae23687b-9a83-4dfc-80ce-ffcda6c48a6d", "1930d82c-7ed2-4e22-820c-672a6e61d17c", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "81d9be49-aff2-48e1-85d6-429b1e9f4734", "6bf5e3c8-af98-446f-a6b6-5edfcf2a674c", "Employee", "EMPLOYEE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5962b184-764b-4caa-8d1f-9f67b53d6525", "58ef5e39-adb2-4ee6-bab6-b8f79896ce99", "Admin", "ADMIN" });
        }
    }
}
