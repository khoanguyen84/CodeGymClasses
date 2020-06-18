using Microsoft.EntityFrameworkCore.Migrations;

namespace EmployeeManagement.Migrations
{
    public partial class SeedEmployeeTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "AvatarPath", "Department", "Email", "Name" },
                values: new object[,]
                {
                    { 1, "~/images/nonavatar.png", 1, "khoa.nguyen@codegym.vn", "Khoa" },
                    { 2, "~/images/nonavatar.png", 2, "khoa.nguyen@codegym.vn", "Phuc" },
                    { 3, "~/images/nonavatar.png", 1, "khoa.nguyen@codegym.vn", "Khanh" },
                    { 4, "~/images/nonavatar.png", 1, "hoang.phan@codegym.vn", "Hoang" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
