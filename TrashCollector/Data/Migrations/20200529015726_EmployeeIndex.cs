using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Data.Migrations
{
    public partial class EmployeeIndex : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                values: new object[] { "39f914e3-ca60-43e5-8359-43add3bafdbb", "774b0c03-c9ae-496b-97d5-d9fe2eeb1dd3", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "bfe3089c-0733-4797-a234-c41ad0da32dd", "6265a15b-d07b-48a9-8eed-213d8fc0d519", "Employee", "EMPLOYEE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a493ec65-9905-4fc8-843c-cebd14d3509b", "2b4c93de-807c-490f-8bc0-2307034b9675", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "39f914e3-ca60-43e5-8359-43add3bafdbb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a493ec65-9905-4fc8-843c-cebd14d3509b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bfe3089c-0733-4797-a234-c41ad0da32dd");

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
        }
    }
}
