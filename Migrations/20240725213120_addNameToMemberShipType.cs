using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace webPay.Migrations
{
    /// <inheritdoc />
    public partial class addNameToMemberShipType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "MemberShipType",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "MemberShipType");
        }
    }
}
