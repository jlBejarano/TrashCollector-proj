using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Data.Migrations
{
    public partial class EmployeeViewsModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "50a10c04-7d7d-4b9c-8a62-a45a9aa48f98");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b978dee0-554e-4676-af29-70d0476225ae");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c5abca19-7dbf-421e-93ef-4807d3633ef2");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "50a10c04-7d7d-4b9c-8a62-a45a9aa48f98", "39d28d7e-e336-4c7b-b141-00384da182c9", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c5abca19-7dbf-421e-93ef-4807d3633ef2", "27711ad2-297e-4be5-a550-7f5bb74ef1d0", "Employee", "EMPLOYEE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b978dee0-554e-4676-af29-70d0476225ae", "490d1679-0438-48f5-a223-48d3a62ded0d", "Admin", "ADMIN" });
        }
    }
}
