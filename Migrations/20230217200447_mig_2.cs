using Microsoft.EntityFrameworkCore.Migrations;

namespace KocTasMall.Migrations
{
    public partial class mig_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "pCategoryId",
                table: "Products",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "departmentsId",
                table: "Employees",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Products_pCategoryId",
                table: "Products",
                column: "pCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_departmentsId",
                table: "Employees",
                column: "departmentsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Departments_departmentsId",
                table: "Employees",
                column: "departmentsId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_PCategories_pCategoryId",
                table: "Products",
                column: "pCategoryId",
                principalTable: "PCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Departments_departmentsId",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_PCategories_pCategoryId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_pCategoryId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Employees_departmentsId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "pCategoryId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "departmentsId",
                table: "Employees");
        }
    }
}
