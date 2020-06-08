using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Data.Migrations
{
    public partial class Employee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3eda881a-4c7a-487e-b698-a767d985492d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "68a30733-c006-4fcf-94c7-6e48d3c25928");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "74954226-4eff-4743-8e83-0c4e69ca6a90");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Employees",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Employees",
                nullable: false,
                defaultValue: "");

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                name: "Address",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "City",
                table: "Employees");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "68a30733-c006-4fcf-94c7-6e48d3c25928", "be0352ea-6d92-47c5-9270-2798ce5799af", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3eda881a-4c7a-487e-b698-a767d985492d", "47ba22c1-5a17-45df-9b74-c1e1e3e3c16f", "Employee", "EMPLOYEE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "74954226-4eff-4743-8e83-0c4e69ca6a90", "3fce147a-3743-484d-8830-f7e86e92020d", "Admin", "ADMIN" });
        }
    }
}
