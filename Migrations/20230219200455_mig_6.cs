﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace KocTasMall.Migrations
{
    public partial class mig_6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_PCategories_PCategoryId",
                table: "Products");

            migrationBuilder.AlterColumn<int>(
                name: "PCategoryId",
                table: "Products",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_PCategories_PCategoryId",
                table: "Products",
                column: "PCategoryId",
                principalTable: "PCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_PCategories_PCategoryId",
                table: "Products");

            migrationBuilder.AlterColumn<int>(
                name: "PCategoryId",
                table: "Products",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_PCategories_PCategoryId",
                table: "Products",
                column: "PCategoryId",
                principalTable: "PCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
