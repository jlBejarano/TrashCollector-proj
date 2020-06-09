using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Data.Migrations
{
    public partial class CustomerScheduleModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1bf80f07-7314-4024-85f7-cc1cb61c61d5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "37e5e266-5a94-45c2-bdb9-7903a0deec1d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4cfa3b06-7218-415f-8a85-b44c81fa3885");

            migrationBuilder.AddColumn<string>(
                name: "DayOfWeek",
                table: "CustomerSchedulePUs",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "055e77e7-a069-4fee-ba15-47561b9d9988", "bac6bc1b-51aa-4a40-b1ba-3d0d16a55304", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6cca2bdc-ff83-43b2-9d1d-721c0e628962", "1162fbf9-9cfb-4892-be4e-b6adddac1ca2", "Employee", "EMPLOYEE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "39c147d4-9592-4614-8009-c96fee269638", "d52129b5-0bcf-4000-bfdf-4dc39b8889c0", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "055e77e7-a069-4fee-ba15-47561b9d9988");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "39c147d4-9592-4614-8009-c96fee269638");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6cca2bdc-ff83-43b2-9d1d-721c0e628962");

            migrationBuilder.DropColumn(
                name: "DayOfWeek",
                table: "CustomerSchedulePUs");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "37e5e266-5a94-45c2-bdb9-7903a0deec1d", "6c6613ad-4908-4ca2-beed-bd159201004a", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4cfa3b06-7218-415f-8a85-b44c81fa3885", "495e904c-fbf6-4685-b6a0-71ac37ae0e94", "Employee", "EMPLOYEE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1bf80f07-7314-4024-85f7-cc1cb61c61d5", "5dfff44f-1b38-40d9-8090-7bfa4d20f77d", "Admin", "ADMIN" });
        }
    }
}
