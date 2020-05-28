using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Data.Migrations
{
    public partial class EmployeeController : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "795d7645-8b72-41bc-a66b-92164ac2df70");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "932e9099-93b6-4f21-94c2-2f1da9847fc8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "edf9eb17-f257-4cff-b246-790ca7360abf");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "edf9eb17-f257-4cff-b246-790ca7360abf", "3f45d296-0ce9-41c1-b2d2-c723c9a3c867", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "932e9099-93b6-4f21-94c2-2f1da9847fc8", "e49001c4-c1e0-4df1-b75b-c8f4202d822f", "Employee", "EMPLOYEE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "795d7645-8b72-41bc-a66b-92164ac2df70", "acad5ebb-ded8-439e-83f9-5650a292e1b8", "Admin", "ADMIN" });
        }
    }
}
