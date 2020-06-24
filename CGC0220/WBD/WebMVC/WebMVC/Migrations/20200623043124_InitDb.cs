using Microsoft.EntityFrameworkCore.Migrations;

namespace WebMVC.Migrations
{
    public partial class InitDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 20, nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Department = table.Column<int>(nullable: false),
                    AvatarPath = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "AvatarPath", "Department", "Email", "Name" },
                values: new object[] { 1, "", 0, "khoa.nguyen@codegym.vn", "Khoa" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "AvatarPath", "Department", "Email", "Name" },
                values: new object[] { 2, "", 1, "phap.phan@codegym.vn", "Pháp" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
