using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace webPay.Migrations
{
    /// <inheritdoc />
    public partial class populateMemberShipType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO MemberShipType (Id,SignUpFeed,DurationInMonths,DiscountRate) VALUES(0,0,0,0)");
            migrationBuilder.Sql("INSERT INTO MemberShipType (Id,SignUpFeed,DurationInMonths,DiscountRate) VALUES(1,30,1,10)");
            migrationBuilder.Sql("INSERT INTO MemberShipType (Id,SignUpFeed,DurationInMonths,DiscountRate) VALUES(2,90,3,15)");
            migrationBuilder.Sql("INSERT INTO MemberShipType (Id,SignUpFeed,DurationInMonths,DiscountRate) VALUES(3,180,6,20)");
            

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
