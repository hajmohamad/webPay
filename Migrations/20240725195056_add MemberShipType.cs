using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace webPay.Migrations
{
    /// <inheritdoc />
    public partial class addMemberShipType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte>(
                name: "MemberShipTypeId",
                table: "Customers",
                type: "tinyint unsigned",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.CreateTable(
                name: "MemberShipType",
                columns: table => new
                {
                    Id = table.Column<byte>(type: "tinyint unsigned", nullable: false),
                    SignUpFeed = table.Column<short>(type: "smallint", nullable: false),
                    DurationInMonths = table.Column<byte>(type: "tinyint unsigned", nullable: false),
                    DiscountRate = table.Column<byte>(type: "tinyint unsigned", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MemberShipType", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_MemberShipTypeId",
                table: "Customers",
                column: "MemberShipTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_MemberShipType_MemberShipTypeId",
                table: "Customers",
                column: "MemberShipTypeId",
                principalTable: "MemberShipType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_MemberShipType_MemberShipTypeId",
                table: "Customers");

            migrationBuilder.DropTable(
                name: "MemberShipType");

            migrationBuilder.DropIndex(
                name: "IX_Customers_MemberShipTypeId",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "MemberShipTypeId",
                table: "Customers");
        }
    }
}
