using Microsoft.EntityFrameworkCore.Migrations;

namespace KocTasMall.Migrations
{
    public partial class mig_4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_PCategories_pCategoryId",
                table: "Products");

            migrationBuilder.RenameColumn(
                name: "pCategoryId",
                table: "Products",
                newName: "PCategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Products_pCategoryId",
                table: "Products",
                newName: "IX_Products_PCategoryId");

            migrationBuilder.AlterColumn<int>(
                name: "PCategoryId",
                table: "Products",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_PCategories_PCategoryId",
                table: "Products",
                column: "PCategoryId",
                principalTable: "PCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_PCategories_PCategoryId",
                table: "Products");

            migrationBuilder.RenameColumn(
                name: "PCategoryId",
                table: "Products",
                newName: "pCategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Products_PCategoryId",
                table: "Products",
                newName: "IX_Products_pCategoryId");

            migrationBuilder.AlterColumn<int>(
                name: "pCategoryId",
                table: "Products",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Products_PCategories_pCategoryId",
                table: "Products",
                column: "pCategoryId",
                principalTable: "PCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
