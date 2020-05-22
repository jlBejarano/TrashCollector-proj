using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Data.Migrations
{
    public partial class AddedCustomerAndEmployeeModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7fb86d2e-3d3e-4526-a9ad-1e399dafcd73");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c5ee1ff5-264a-4a00-92b9-80b2b18f131e", "6f4c4fa8-42c2-42b7-bec1-08e5050dc60a", "Admin", "Admin" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c5ee1ff5-264a-4a00-92b9-80b2b18f131e");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7fb86d2e-3d3e-4526-a9ad-1e399dafcd73", "078ca129-82e5-4c98-91cc-3a59a4b4dbcc", "Admin", "Admin" });
        }
    }
}
