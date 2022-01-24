using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAPIApp2.Data.Migrations
{
    public partial class CreateProductTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 255, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValue: 0m),
                    Count = table.Column<int>(nullable: false, defaultValue: 0),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValue: false),
                    CreatedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "GETUTCDATE()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Count", "Name", "Price" },
                values: new object[] { 1, 2, "pro1", 12.99m });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Count", "Name", "Price" },
                values: new object[] { 2, 5, "pro2", 24.99m });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Count", "Name", "Price" },
                values: new object[] { 3, 3, "pro3", 15.99m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
