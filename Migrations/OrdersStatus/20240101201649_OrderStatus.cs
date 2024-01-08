using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hardware4You.Migrations.OrdersStatus
{
    public partial class OrderStatus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OrdersStatus",
                columns: table => new
                {
                    OrderID = table.Column<long>(type: "bigint", nullable: false),
                    orderStatus = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrdersStatus", x => x.OrderID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrdersStatus");
        }
    }
}
