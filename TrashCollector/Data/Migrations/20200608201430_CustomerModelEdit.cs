using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Data.Migrations
{
    public partial class CustomerModelEdit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CustomerSchedulePU");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "05b4fb0b-5c6a-4132-b502-a64cfeca5cfd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8820f5fc-0a82-4142-b5a2-00eb028c6f7c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c148885d-1382-40c0-a6c6-4e63c05795d5");

            migrationBuilder.DropColumn(
                name: "City",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "State",
                table: "Customers");

            migrationBuilder.AddColumn<bool>(
                name: "ConfirmPickUp",
                table: "Customers",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "DayOfWeek",
                table: "Customers",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "EndDate",
                table: "Customers",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "ExtraPickUp",
                table: "Customers",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "StartDate",
                table: "Customers",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "SuspendEndDate",
                table: "Customers",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "SuspendStartDate",
                table: "Customers",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0619d567-c937-4362-9a9c-53513cd3bc01", "99875841-c2f6-428f-ab12-a7581c8fe009", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "46b90f1c-006a-4706-8af2-ffeb65ee268d", "a447f0a9-bc74-41aa-9aac-64a61c002a3d", "Employee", "EMPLOYEE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0a361289-72bb-412d-a0fe-94db1b406430", "c4090577-f74d-4e35-a6cb-68705957984d", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0619d567-c937-4362-9a9c-53513cd3bc01");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0a361289-72bb-412d-a0fe-94db1b406430");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "46b90f1c-006a-4706-8af2-ffeb65ee268d");

            migrationBuilder.DropColumn(
                name: "ConfirmPickUp",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "DayOfWeek",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "EndDate",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "ExtraPickUp",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "StartDate",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "SuspendEndDate",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "SuspendStartDate",
                table: "Customers");

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "State",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "CustomerSchedulePU",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DayOfWeek = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdentityUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    SuspendEndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SuspendStartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ZipCode = table.Column<double>(type: "float", nullable: false)
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
                values: new object[] { "c148885d-1382-40c0-a6c6-4e63c05795d5", "cffd36c1-46ee-4f7a-81ec-9dbb897f5fd8", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "05b4fb0b-5c6a-4132-b502-a64cfeca5cfd", "f55826b5-8ef1-4544-887d-1b3ec9973b9f", "Employee", "EMPLOYEE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8820f5fc-0a82-4142-b5a2-00eb028c6f7c", "97175c48-a6e4-4ac0-8324-1893cc7116fd", "Admin", "ADMIN" });

            migrationBuilder.CreateIndex(
                name: "IX_CustomerSchedulePU_IdentityUserId",
                table: "CustomerSchedulePU",
                column: "IdentityUserId");
        }
    }
}
