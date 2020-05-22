using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Data.Migrations
{
    public partial class CustomerViewModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "272d5f6c-85f0-4f7a-8f27-00a2b5a3c808");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2ee98a46-c764-4581-bb3a-cfb8aa528b6e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "922e8297-9ad8-482e-b9fc-32262ff90052");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9add1339-3153-4b1c-93c9-bc839724902f", "a2196734-36e8-44e2-aece-bf02dc4321fb", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "56f23f47-fc5f-4d0c-859d-5c3fa3aa50a5", "4be2c6f1-fdd7-4d70-8f91-e2afa23fbe31", "Employee", "EMPLOYEE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "16ca23bb-a3c9-4253-a427-209977bd4050", "9e139136-13f6-4f91-af38-5de219462955", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "16ca23bb-a3c9-4253-a427-209977bd4050");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "56f23f47-fc5f-4d0c-859d-5c3fa3aa50a5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9add1339-3153-4b1c-93c9-bc839724902f");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2ee98a46-c764-4581-bb3a-cfb8aa528b6e", "24c6c718-a998-4ae7-b991-d988168c5f89", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "922e8297-9ad8-482e-b9fc-32262ff90052", "9a56ec8f-fe3a-4300-b00f-9f1444df6950", "Employee", "EMPLOYEE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "272d5f6c-85f0-4f7a-8f27-00a2b5a3c808", "0acd7be2-161d-4965-8c7f-8e5ec0174d3a", "Admin", "ADMIN" });
        }
    }
}
