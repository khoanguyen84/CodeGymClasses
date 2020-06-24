using Microsoft.EntityFrameworkCore.Migrations;

namespace WBDDemo.Migrations
{
    public partial class SeedingEmployee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "AvatarPath", "Department", "Email", "Name" },
                values: new object[] { 1, "images/nonavatar.png", 0, "trung.nguyen@codegym.vn", "Trung Nguyễn" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "AvatarPath", "Department", "Email", "Name" },
                values: new object[] { 2, "images/nonavatar.png", 1, "quang.nguyen@codegym.vn", "Quang Nguyễn" });
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
        }
    }
}
