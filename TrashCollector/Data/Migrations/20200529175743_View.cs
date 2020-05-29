using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Data.Migrations
{
    public partial class View : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
