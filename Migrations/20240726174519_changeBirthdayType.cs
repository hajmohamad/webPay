using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace webPay.Migrations
{
    /// <inheritdoc />
    public partial class changeBirthdayType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfBirth",
                table: "Customers",
                type: "datetime(6)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .OldAnnotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "DateOfBirth",
                keyValue: null,
                column: "DateOfBirth",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "DateOfBirth",
                table: "Customers",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");
        }
    }
}
